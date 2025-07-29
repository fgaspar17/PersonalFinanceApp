using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalFinanceApp.Data;
using PersonalFinanceApp.Data.Models;

Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<PersonalFinanceAppContext>(options =>
            options
            .UseSqlite("Data Source=personalfinance.db", b => b.MigrationsAssembly("PersonalFinanceApp.Migrations"))
            .UseSeeding((context, _) =>
            {
                var defaultMethods = new[]
                {
                "Cash", "Credit Card", "Debit Card", "Bank Transfer", "PayPal", "Bizum", "Revolut", "Other"
            };

                var existingNames = context.Set<PaymentMethod>()
                    .IgnoreQueryFilters()
                    .Select(pm => pm.Name)
                    .ToHashSet();

                foreach (var name in defaultMethods)
                {
                    if (!existingNames.Contains(name))
                    {
                        context.Set<PaymentMethod>().Add(new PaymentMethod { Name = name });
                    }
                }

                context.SaveChanges();
            })
            .UseAsyncSeeding(async (context, _, cancellationToken) =>
            {
                var defaultMethods = new[]
                {
                    "Cash", "Credit Card", "Debit Card", "Bank Transfer", "PayPal", "Bizum", "Revolut", "Other"
                };

                var existingNames = await context.Set<PaymentMethod>()
                    .IgnoreQueryFilters()
                    .Select(pm => pm.Name)
                    .ToListAsync(cancellationToken);

                var toAdd = defaultMethods
                    .Where(name => !existingNames.Contains(name))
                    .Select(name => new PaymentMethod { Name = name });

                await context.Set<PaymentMethod>().AddRangeAsync(toAdd, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }));
    })
    .Build()
    .Run();