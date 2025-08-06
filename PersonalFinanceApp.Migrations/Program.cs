using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalFinanceApp.Data;
using PersonalFinanceApp.Data.Seed;

Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<PersonalFinanceAppContext>(options =>
            options
            .UseSqlite("Data Source=personalfinance.db", b => b.MigrationsAssembly("PersonalFinanceApp.Migrations"))
            .UseSeeding((context, _) =>
            {
                MasterSeeder seeder = new([new PaymentMethodSeed(), new CategorySeed()]);
                seeder.Seed(context);
            })
            .UseAsyncSeeding(async (context, _, ct) =>
            {
                MasterSeeder seeder = new([new PaymentMethodSeed(), new CategorySeed()]);
                await seeder.SeedAsync(context, ct);
            }));
    })
    .Build()
    .Run();