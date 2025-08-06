using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonalFinanceApp.Data.Models;

namespace PersonalFinanceApp.Data.Seed
{
    public class PaymentMethodSeed : ISeeder
    {
        private readonly string[] defaultMethods = 
        [
            "Cash", "Credit Card", "Debit Card", 
            "Bank Transfer", "PayPal", "Bizum", 
            "Revolut", "Other"
        ];

        public void Seed(DbContext context)
        {
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
        }

        public async Task SeedAsync(DbContext context, CancellationToken ct)
        {
            var existingNames = await context.Set<PaymentMethod>()
                .IgnoreQueryFilters()
                .Select(pm => pm.Name)
                .ToListAsync(ct);

            var toAdd = defaultMethods
                .Where(name => !existingNames.Contains(name))
                .Select(name => new PaymentMethod { Name = name });

            await context.Set<PaymentMethod>().AddRangeAsync(toAdd, ct);
            await context.SaveChangesAsync(ct);
        }
    }
}
