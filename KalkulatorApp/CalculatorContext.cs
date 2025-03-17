namespace KalkulatorApp;

using KalkulatorApp.Models;
using Microsoft.EntityFrameworkCore;

public class CalculatorContext : DbContext
{
    public virtual DbSet<Calculation> Calculations { get; set; }
    public virtual DbSet<CurrencyRate> CurrencyRates { get; set; }

    public CalculatorContext(DbContextOptions<CalculatorContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=:memory:");
        }
    }
}
