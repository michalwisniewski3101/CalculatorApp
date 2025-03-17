using KalkulatorApp.Interfaces;
using KalkulatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KalkulatorApp.Services
{
    public class CalcHistoryRepository : ICalcHistoryRepository
    {
        private readonly CalculatorContext _context;

        public CalcHistoryRepository(CalculatorContext context)
        {
            _context = context;
        }

        public void SaveCalculation(string expression, double result)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression), "Expression cannot be null.");

            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Expression cannot be empty.", nameof(expression));

            var calculation = new Calculation
            {
                Expression = expression,
                Result = result.ToString(),
                CalculationDate = DateTime.Now
            };

            _context.Calculations.Add(calculation);
            _context.SaveChanges();
        }

        public List<Calculation> GetCalcHistory()
        {
            return _context.Calculations
                .OrderByDescending(c => c.CalculationDate)
                .ToList();
        }
    }
}
