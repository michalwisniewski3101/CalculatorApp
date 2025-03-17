using NUnit.Framework;
using KalkulatorApp.Services;
using System;
using KalkulatorApp.Interfaces;

namespace KalkulatorApp.Tests
{
    [TestFixture]
    public class CalculationRepositoryTests
    {
        private CalculationRepository _repository;

        [SetUp]
        public void Setup()
        {
            _repository = new CalculationRepository();
        }

        [Test]
        public void EvaluateExpression_ValidExpression_ShouldReturnCorrectResult()
        {
            string expression = "2+3*4";
            double result = _repository.EvaluateExpression(expression);
            Assert.That(result, Is.EqualTo(14));
        }

        [Test]
        public void EvaluateExpression_DivisionByZero_ShouldThrowDivideByZeroException()
        {
            string expression = "10/0";
            Assert.Throws<DivideByZeroException>(() => _repository.EvaluateExpression(expression));
        }

        [Test]
        public void EvaluateExpression_EmptyExpression_ShouldThrowArgumentException()
        {
            string expression = "";
            var ex = Assert.Throws<ArgumentException>(() => _repository.EvaluateExpression(expression));
            Assert.That(ex.Message, Is.EqualTo("The expression cannot be empty."));
        }

        [Test]
        public void EvaluateExpression_InvalidExpression_ShouldThrowException()
        {
            string expression = "2++2";
            var ex = Assert.Throws<Exception>(() => _repository.EvaluateExpression(expression));
            Assert.That(ex.Message, Is.EqualTo("Invalid mathematical expression."));
        }

        [Test]
        public void EvaluateExpression_ComplexExpression_ShouldReturnCorrectResult()
        {
            string expression = "(5+3)*2-4/2";
            double result = _repository.EvaluateExpression(expression);
            Assert.That(result, Is.EqualTo(14));
        }
    }
}
