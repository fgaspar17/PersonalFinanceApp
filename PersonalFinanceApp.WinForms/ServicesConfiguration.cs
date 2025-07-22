using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceApp.Data;
using PersonalFinanceApp.Services.Services;

namespace PersonalFinanceApp.WinForms;

internal class ServicesConfiguration
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<PersonalFinanceAppContext>(options =>
        {
            options.UseSqlite("Data Source=personalfinance.db");
        });

        services.AddScoped<IPaymentMethodService, PaymentMethodService>();
        services.AddScoped<Form1>();
    }
}