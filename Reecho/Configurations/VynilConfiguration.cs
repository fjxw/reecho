
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class VynilConfiguration : IEntityTypeConfiguration<Vynil>
{
    public void Configure(EntityTypeBuilder<Vynil> builder)
    {
        builder.ToTable("Vynils").HasKey(x => x.Id).HasName("VynilId");
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Genre).HasConversion<string>();
        builder.Property(x => x.Price).HasMaxLength(1000000);
        builder.Property(x => x.Quantity).HasMaxLength(100);
    }
}