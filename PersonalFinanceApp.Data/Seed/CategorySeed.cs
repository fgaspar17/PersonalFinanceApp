using Microsoft.EntityFrameworkCore;
using PersonalFinanceApp.Data.Models;

namespace PersonalFinanceApp.Data.Seed;

public class CategorySeed : ISeeder
{
    private readonly string[] defaultCategories =
        {
                "Food & Groceries",
                "Transportation",
                "Insurance",
                "Healthcare",
                "Entertainment",
                "Dining Out",
                "Clothing",
                "Subscriptions",
                "Education",
                "Travel",
                "Gifts & Donations",
                "Debt Payments",
                "Household Supplies",
                "Miscellaneous",
                "Salary",
                "Investments",
                "Gifts",
                "Bonuses",
        };

    public void Seed(DbContext context)
    {
        var existingNames = context.Set<Category>()
            .IgnoreQueryFilters()
            .Select(c => c.Name)
            .ToHashSet();

        foreach (var name in defaultCategories)
        {
            if (!existingNames.Contains(name))
            {
                context.Set<Category>().Add(new Category { Name = name });
            }
        }

        context.SaveChanges();
    }

    public async Task SeedAsync(DbContext context, CancellationToken ct)
    {
        var existingNames = await context.Set<Category>()
                .IgnoreQueryFilters()
                .Select(c => c.Name)
                .ToListAsync(ct);

        var toAdd = defaultCategories
            .Where(name => !existingNames.Contains(name))
            .Select(name => new Category { Name = name });

        await context.Set<Category>().AddRangeAsync(toAdd, ct);
        await context.SaveChangesAsync(ct);
    }
}
