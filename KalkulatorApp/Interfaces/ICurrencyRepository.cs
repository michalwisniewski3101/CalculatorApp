namespace KalkulatorApp.Interfaces;

public interface ICurrencyRepository
{
    Task FetchAndSaveExchangeRates(DateTime startDate, DateTime endDate, string currencyCode);
    string GetBestExchangeDate(string fromCurrency, string toCurrency, DateTime startDate, DateTime endDate, decimal amount = 0);
}
