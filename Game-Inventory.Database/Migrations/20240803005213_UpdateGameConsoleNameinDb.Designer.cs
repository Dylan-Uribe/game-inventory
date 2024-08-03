﻿// <auto-generated />
using System;
using Game_Inventory.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Game_Inventory.Database.Migrations
{
    [DbContext(typeof(GameStopContext))]
    [Migration("20240803005213_UpdateGameConsoleNameinDb")]
    partial class UpdateGameConsoleNameinDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Game_Inventory.Database.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CEO")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("Pk_Company");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Game_Inventory.Database.Console", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(6,2)")
                        .HasDefaultValue(0m);

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("Pk_Console");

                    b.HasIndex("CompanyId");

                    b.ToTable("Consoles");
                });

            modelBuilder.Entity("Game_Inventory.Database.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.HasKey("Id")
                        .HasName("Pk_Game");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Game_Inventory.Database.GameConsole", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("ConsoleId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(6,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateOnly>("ReleaseDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("GameId", "ConsoleId")
                        .HasName("Pk_GameConsole");

                    b.HasIndex("ConsoleId");

                    b.ToTable("GameConsoles");
                });

            modelBuilder.Entity("Game_Inventory.Database.Console", b =>
                {
                    b.HasOne("Game_Inventory.Database.Company", "Company")
                        .WithMany("Consoles")
                        .HasForeignKey("CompanyId")
                        .IsRequired()
                        .HasConstraintName("Fk_Console_Company");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Game_Inventory.Database.GameConsole", b =>
                {
                    b.HasOne("Game_Inventory.Database.Console", "Console")
                        .WithMany("GameConsoles")
                        .HasForeignKey("ConsoleId")
                        .IsRequired()
                        .HasConstraintName("Fk_GameConsole_Console");

                    b.HasOne("Game_Inventory.Database.Game", "Game")
                        .WithMany("GameConsoles")
                        .HasForeignKey("GameId")
                        .IsRequired()
                        .HasConstraintName("Fk_GameConsole_Game");

                    b.Navigation("Console");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Game_Inventory.Database.Company", b =>
                {
                    b.Navigation("Consoles");
                });

            modelBuilder.Entity("Game_Inventory.Database.Console", b =>
                {
                    b.Navigation("GameConsoles");
                });

            modelBuilder.Entity("Game_Inventory.Database.Game", b =>
                {
                    b.Navigation("GameConsoles");
                });
#pragma warning restore 612, 618
        }
    }
}
