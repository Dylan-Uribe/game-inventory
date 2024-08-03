using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database.Configs;

public class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder
            .HasKey(e => e.Id)
            .HasName("Pk_Game");

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);

        builder
            .Property (e => e.Genre)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);

        builder
            .Property(e => e.Description)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);
    }
}
