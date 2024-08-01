using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database
{
    public class GameStopContext: DbContext
    {
        public GameStopContext()
        {

        }

        public GameStopContext(DbContextOptions<GameStopContext> options)
            : base(options) 
        {

        }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Console> Consoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.ID).HasName("Pk_Company");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(e => e.CEO)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Console>(entity =>
            {

                entity.HasKey(e => e.ID).HasName("Pk_Console");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

                entity.Property(e => e.Price)
                .HasColumnType("decimal(6,2)")
                .HasDefaultValue(0);

                entity.HasOne<Company>(d => d.Company)
                .WithMany(p => p.Consoles)
                .HasForeignKey(d => d.CompanyID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Console_Company");
            });
        }
    }
}
