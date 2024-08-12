using Game_Inventory.Database.Configs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Inventory.Database;

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

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<GameConsole> GameConsoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new CompanyEntityTypeConfiguration()
             .Configure(modelBuilder.Entity<Company>());

        new ConsoleEntityTypeConfiguration()
            .Configure(modelBuilder.Entity<Console>());

        new GameEntityTypeConfiguration()
            .Configure(modelBuilder.Entity<Game>());

        new GameConsoleEntityTypeConfiguration()
            .Configure(modelBuilder.Entity<GameConsole>());
    }
}
