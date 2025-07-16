using Microsoft.EntityFrameworkCore;
using PersonalFinanceApp.Data.Models;

namespace PersonalFinanceApp.Data;

public class PersonalFinanceAppContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    public DbSet<MovementType> MovementTypes { get; set; }
    public DbSet<MoneyMovement> MoneyMovements { get; set; }
    public PersonalFinanceAppContext(DbContextOptions<PersonalFinanceAppContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonalFinanceAppContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}