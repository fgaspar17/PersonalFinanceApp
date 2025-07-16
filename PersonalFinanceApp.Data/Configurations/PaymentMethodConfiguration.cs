using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceApp.Data.Models;

namespace PersonalFinanceApp.Data.Configurations;

internal class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
{
    public void Configure(EntityTypeBuilder<PaymentMethod> builder)
    {
        builder
            .HasIndex(p => p.Name)
            .IsUnique();

        builder
            .Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasQueryFilter(p => p.IsActive);
    }
}