using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceApp.Data.Models;

namespace PersonalFinanceApp.Data.Configurations;

internal class MovementTypeConfiguration : IEntityTypeConfiguration<MovementType>
{
    public void Configure(EntityTypeBuilder<MovementType> builder)
    {
        builder
            .HasIndex(mt => mt.Name)
            .IsUnique();

        builder
            .Property(mt => mt.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasQueryFilter(mt => mt.IsActive);
    }
}