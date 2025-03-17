using KalkulatorApp.Interfaces;
using KalkulatorApp.Models;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KalkulatorApp.Services
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly CalculatorContext _context;

        public CurrencyRepository(CalculatorContext context)
        {
            _context = context;
        }

        public string GetBestExchangeDate(string fromCurrency, string toCurrency, DateTime startDate, DateTime endDate, decimal amount = 0)
        {
            if (fromCurrency == "PLN" || toCurrency == "PLN")
            {

                if (fromCurrency == "PLN" && toCurrency == "PLN")
                {
                    return "No conversion needed. Both currencies are PLN.";
                }

                var rates = new List<CurrencyRate>();
                decimal convertedAmount= 0;

                rates = _context.CurrencyRates
                    .Where(rate => rate.Code == toCurrency || rate.Code == fromCurrency && rate.RateDate >= startDate && rate.RateDate <= endDate)
                    .OrderBy(r => r.RateDate).ToList();


                var rate = (fromCurrency == "PLN")
                    ? rates.OrderByDescending(x => x.Rate).FirstOrDefault()
                    : rates.OrderBy(x => x.Rate).FirstOrDefault();

                if (rate != null)
                {
                    var currentRate = 0m;
                    if (fromCurrency == "PLN")
                    {
                        convertedAmount = amount / rate.Rate;
                        currentRate = 1/rate.Rate;

                    }
                    else if (toCurrency == "PLN")
                    {
                        convertedAmount = amount * rate.Rate;
                        currentRate = rate.Rate;
                    }


                    return $"Best day: {rate.RateDate:yyyy-MM-dd}, Rate: {currentRate:F4}\nConverted amount: {convertedAmount:F2} {toCurrency}";
                }
                else
                {
                    return "No data for the given range.";
                }

            }


            var fromRates = _context.CurrencyRates
                .Where(rate => rate.Code == fromCurrency && rate.RateDate >= startDate && rate.RateDate <= endDate)
                .Select(rate => new { rate.RateDate, Rate = rate.Rate });

            var toRates = _context.CurrencyRates
                .Where(rate => rate.Code == toCurrency && rate.RateDate >= startDate && rate.RateDate <= endDate)
                .Select(rate => new { rate.RateDate, Rate = rate.Rate });

            var joinedRates = from fr in fromRates
                              join tr in toRates on fr.RateDate equals tr.RateDate
                              select new
                              {
                                  RateDate = fr.RateDate,
                                  ConversionRate = fr.Rate / tr.Rate
                              };


            var bestRateRecord = joinedRates
                .AsEnumerable()
                .OrderByDescending(x => x.ConversionRate)
                .FirstOrDefault();

            if (bestRateRecord != null)
            {
                string result = $"Best day: {bestRateRecord.RateDate:yyyy-MM-dd}, Rate: {bestRateRecord.ConversionRate:F4}";

                if (amount > 0)
                {
                    decimal convertedAmount = amount * bestRateRecord.ConversionRate;
                    result += $"\nConverted amount: {convertedAmount:F2} {toCurrency}";
                }

                return result;
            }

            return "No data for the given range.";
        }


        public async Task FetchAndSaveExchangeRates(DateTime startDate, DateTime endDate, string currencyCode)
        {
            string formattedstartDate = startDate.ToString("yyyy-MM-dd");
            string formattedendDate = endDate.ToString("yyyy-MM-dd");
            string url = $"https://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{formattedstartDate}/{formattedendDate}/?format=json";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var table = JsonConvert.DeserializeObject<NbpResponse>(json);
                    if (table != null)
                    {
                        var rates = table.Rates?.Select(rate => new CurrencyRate
                        {
                            Code = currencyCode,
                            Rate = rate.Mid,
                            RateDate = rate.EffectiveDate,
                        }).ToList();
                        if (rates != null)
                        {
                            _context.CurrencyRates.AddRange(rates);
                            await _context.SaveChangesAsync();
                        }

                    }
                }
            }
        }
    }
}
