    using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database.Configs;

public class CompanyEntityTypeConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder
            .HasKey(e => e.Id)
            .HasName("Pk_Company");

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(e => e.CEO)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);
    }
}
