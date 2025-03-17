using KalkulatorApp.Interfaces;
using System.Data;
using System.Text.RegularExpressions;

namespace KalkulatorApp.Services;

public class CalculationRepository : ICalculationRepository
{
    public double EvaluateExpression(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            throw new ArgumentException("The expression cannot be empty.");

        string allowedPattern = @"^[0-9+\-*/().\s]+$";
        if (!Regex.IsMatch(expression, allowedPattern))
            throw new Exception("Invalid mathematical expression.");

        string invalidOperatorPattern = @"([+\-*/]{2,})";
        if (Regex.IsMatch(expression, invalidOperatorPattern))
            throw new Exception("Invalid mathematical expression.");

        if (expression.Contains("/0"))
            throw new DivideByZeroException("Division by zero is not allowed.");

        try
        {
            DataTable table = new DataTable();
            object result = table.Compute(expression, "");

            if (result is DBNull)
                throw new Exception("Invalid mathematical expression.");

            return Convert.ToDouble(result);
        }
        catch (DivideByZeroException)
        {
            throw;
        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new Exception("Invalid mathematical expression.", ex);
        }
    }
}
