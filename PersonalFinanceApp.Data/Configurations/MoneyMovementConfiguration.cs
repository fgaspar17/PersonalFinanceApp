using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceApp.Data.Models;

namespace PersonalFinanceApp.Data.Configurations;

internal class MoneyMovementConfiguration : IEntityTypeConfiguration<MoneyMovement>
{
    public void Configure(EntityTypeBuilder<MoneyMovement> builder)
    {
        builder
            .HasOne(m => m.Category)
            .WithMany(c => c.MoneyMovements)
            .HasForeignKey(m => m.CategoryId);

        builder
            .HasOne(m => m.PaymentMethod)
            .WithMany(p => p.MoneyMovements)
            .HasForeignKey(m => m.PaymentMethodId);

        builder
            .HasOne(m => m.MovementType)
            .WithMany(mt => mt.MoneyMovements)
            .HasForeignKey(m => m.MovementTypeId);

        builder
          .HasIndex(m => m.Description)
          .IsUnique();

        builder
           .Property(m => m.Description)
           .IsRequired()
           .HasMaxLength(100);

        builder
            .HasQueryFilter(m => m.IsActive);
    }
}