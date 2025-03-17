using NUnit.Framework;
using KalkulatorApp.Services;
using KalkulatorApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KalkulatorApp.Tests
{
    [TestFixture]
    public class CurrencyRepositorySQLiteTests
    {
        private CalculatorContext _context;
        private CurrencyRepository _repository;

        [SetUp]
        public void Setup()
        {
            
            var options = new DbContextOptionsBuilder<CalculatorContext>()
                .UseSqlite("DataSource=:memory:")
                .Options;

            _context = new CalculatorContext(options);
            _context.Database.OpenConnection();
            _context.Database.EnsureCreated();

            _repository = new CurrencyRepository(_context);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Database.CloseConnection();
            _context.Dispose();
        }

        [Test]
        public void GetBestExchangeDate_BothCurrenciesPLN_ShouldReturnNoConversionNeeded()
        {
            var result = _repository.GetBestExchangeDate("PLN", "PLN", DateTime.Now.AddDays(-7), DateTime.Now);
            Assert.That(result, Is.EqualTo("No conversion needed. Both currencies are PLN."));
        }

        [Test]
        public void GetBestExchangeDate_NoData_ShouldReturnNoDataMessage()
        {
            var result = _repository.GetBestExchangeDate("USD", "EUR", DateTime.Now.AddDays(-7), DateTime.Now);
            Assert.That(result, Is.EqualTo("No data for the given range."));
        }

        [Test]
        public void GetBestExchangeDate_ValidCurrencies_ReturnsBestExchangeRate()
        {
            var date = DateTime.Now.AddDays(-2).Date;
            var usdRate = new CurrencyRate { Code = "USD", Rate = 4.5m, RateDate = date };
            var eurRate = new CurrencyRate { Code = "EUR", Rate = 4.0m, RateDate = date };
            _context.CurrencyRates.AddRange(usdRate, eurRate);
            _context.SaveChanges();
            var result = _repository.GetBestExchangeDate("USD", "EUR", DateTime.Now.AddDays(-7), DateTime.Now, 100);
            StringAssert.Contains("Best day", result);
            StringAssert.Contains("Converted amount", result);
        }

        [Test]
        public async Task FetchAndSaveExchangeRates_InvalidCurrency_ShouldNotSave()
        {
            string invalidCurrency = "XYZ";
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;
            await _repository.FetchAndSaveExchangeRates(startDate, endDate, invalidCurrency);
            var count = _context.CurrencyRates.Count();
            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public async Task FetchAndSaveExchangeRates_ValidCurrency_ShouldSaveData()
        {
            string validCurrency = "USD";
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;
            await _repository.FetchAndSaveExchangeRates(startDate, endDate, validCurrency);
            var count = _context.CurrencyRates.Count();
            Assert.That(count, Is.GreaterThan(0));
        }
    }
}
