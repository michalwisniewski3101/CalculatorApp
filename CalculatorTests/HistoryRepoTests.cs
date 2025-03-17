using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using KalkulatorApp.Models;
using KalkulatorApp.Services;
using System.Collections.Generic;

namespace KalkulatorApp.Tests
{
    [TestFixture]
    public class CalcHistoryRepositoryTests
    {
        private CalcHistoryRepository _repository;
        private CalculatorContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<CalculatorContext>()
                .UseSqlite("Filename=:memory:")
                .Options;

            _context = new CalculatorContext(options);
            _context.Database.OpenConnection();
            _context.Database.EnsureCreated();

            _repository = new CalcHistoryRepository(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.CloseConnection();
            _context.Dispose();
        }

        [Test]
        public void SaveCalculation_ShouldAddCalculationToContext()
        {
            string expression = "2 + 2";
            double result = 4;
            _repository.SaveCalculation(expression, result);
            var savedCalc = _context.Calculations.FirstOrDefault();
            Assert.IsNotNull(savedCalc);
            Assert.That(savedCalc.Expression, Is.EqualTo(expression));
            Assert.That(savedCalc.Result, Is.EqualTo("4"));
        }

        [Test]
        public void GetCalcHistory_ShouldReturnOrderedCalculations()
        {
            _context.Calculations.AddRange(new List<Calculation>
            {
                new Calculation { Expression = "2+2", Result = "4", CalculationDate = DateTime.Now.AddMinutes(-10) },
                new Calculation { Expression = "3+3", Result = "6", CalculationDate = DateTime.Now }
            });
            _context.SaveChanges();
            var result = _repository.GetCalcHistory();
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Expression, Is.EqualTo("3+3")); // Powinno byæ posortowane malej¹co
        }

        [Test]
        public void SaveCalculation_NullExpression_ShouldThrowArgumentNullException()
        {
            string expression = null;
            double result = 5;
            Assert.Throws<ArgumentNullException>(() => _repository.SaveCalculation(expression, result));
        }

        [Test]
        public void SaveCalculation_EmptyExpression_ShouldThrowArgumentException()
        {
            string expression = "";
            double result = 5;
            Assert.Throws<ArgumentException>(() => _repository.SaveCalculation(expression, result));
        }
    }
}