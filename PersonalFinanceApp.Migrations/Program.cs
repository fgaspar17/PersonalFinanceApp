using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalFinanceApp.Data;

Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<PersonalFinanceAppContext>(options =>
            options.UseSqlite("Data Source=personalfinance.db", b => b.MigrationsAssembly("PersonalFinanceApp.Migrations")));
    })
    .Build()
    .Run();