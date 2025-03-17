namespace KalkulatorApp.Models;

public class Calculation
{
    public int Id { get; set; }
    public string? Expression { get; set; }
    public string? Result { get; set; }
    public DateTime CalculationDate { get; set; }
}
