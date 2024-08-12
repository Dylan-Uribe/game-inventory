using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database.Configs
{
    public class GameConsoleEntityTypeConfiguration : IEntityTypeConfiguration<GameConsole>
    {
        public void Configure(EntityTypeBuilder<GameConsole> builder)
        {
            builder
                .HasKey(e => new { e.GameId, e.ConsoleId })
                .HasName("Pk_GameConsole");

            builder
                .Property(e => e.ReleaseDate)
                .HasDefaultValueSql("(getdate())")
                .IsRequired();

            builder
                .Property(e => e.Price)
                .HasColumnType("decimal(6,2)")
                .HasDefaultValue(0);

            builder
                .HasOne<Game>(e => e.Game)
                .WithMany(p => p.GameConsoles)
                .HasForeignKey(e => e.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_GameConsole_Game");

            builder
                .HasOne<Console>(e => e.Console)
                .WithMany(p => p.GameConsoles)
                .HasForeignKey(e => e.ConsoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_GameConsole_Console");
        }
    }
}
