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
        }
    }
}
