using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database.Configs;

public class ConsoleEntityTypeConfiguration :IEntityTypeConfiguration<Console>
{
    public void Configure(EntityTypeBuilder<Console> builder)
    {
        builder
            .HasKey(e => e.Id)
            .HasName("Pk_Console");

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);

        builder
            .Property(e => e.Price)
            .HasColumnType("decimal(6,2)")
            .HasDefaultValue(0);

        builder
            .HasOne<Company>(d => d.Company)
            .WithMany(p => p.Consoles)
            .HasForeignKey(d => d.CompanyID)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Fk_Console_Company");
    }
}
