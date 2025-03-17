using KalkulatorApp.Models;


namespace KalkulatorApp.Interfaces;

public interface ICalcHistoryRepository
{

    public List<Calculation> GetCalcHistory();

    public void SaveCalculation(string expression, double result);
}
