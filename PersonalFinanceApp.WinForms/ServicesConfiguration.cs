using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceApp.Data;
using PersonalFinanceApp.Services.DTOs;
using PersonalFinanceApp.Services.Services;
using PersonalFinanceApp.Services.Validators;

namespace PersonalFinanceApp.WinForms;

internal class ServicesConfiguration
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<PersonalFinanceAppContext>(options =>
        {
            options.UseSqlite("Data Source=personalfinance.db");
        });

        services.AddScoped<IValidator<PaymentMethodDto>, PaymentMethodValidator>();
        services.AddScoped<IPaymentMethodService, PaymentMethodService>();
        services.AddScoped<PaymentMethodForm>();
    }
}