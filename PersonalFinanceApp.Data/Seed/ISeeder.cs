using Microsoft.EntityFrameworkCore;

namespace PersonalFinanceApp.Data.Seed;

public interface ISeeder
{
    void Seed(DbContext context);
    Task SeedAsync(DbContext context, CancellationToken ct);
}