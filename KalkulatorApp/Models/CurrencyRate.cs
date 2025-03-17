namespace KalkulatorApp.Models
{

    public class CurrencyRate
    {
        public int Id { get; set; }
        public string? Currency { get; set; }
        public decimal Rate { get; set; }
        public DateTime RateDate { get; set; }
        public string? Code { get; set; }
    }
}
