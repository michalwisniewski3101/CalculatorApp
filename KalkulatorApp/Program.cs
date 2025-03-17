using KalkulatorApp.Interfaces;
using KalkulatorApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KalkulatorApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<CalculatorContext>();
                    context.Database.EnsureCreated();
                }

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(serviceProvider.GetRequiredService<Form1>());
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var connection = new Microsoft.Data.Sqlite.SqliteConnection("Data Source=:memory:");
            connection.Open();

            services.AddDbContext<CalculatorContext>(options =>
                options.UseSqlite(connection));

            services.AddScoped<ICalculationRepository, CalculationRepository>();
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<ICalcHistoryRepository, CalcHistoryRepository>();
            services.AddScoped<Form1>();
        }

    }
}