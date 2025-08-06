using Microsoft.EntityFrameworkCore;

namespace PersonalFinanceApp.Data.Seed;

public class MasterSeeder : ISeeder
{
    private readonly IEnumerable<ISeeder> _seeders;

    public MasterSeeder(IEnumerable<ISeeder> seeders)
    {
        _seeders = seeders;
    }

    public void Seed(DbContext context)
    {
        foreach (var seeder in _seeders)
        {
            seeder.Seed(context);
        }
    }

    public async Task SeedAsync(DbContext context, CancellationToken ct)
    {
        foreach (var seeder in _seeders)
        {
            await seeder.SeedAsync(context, ct);
        }
    }
}
