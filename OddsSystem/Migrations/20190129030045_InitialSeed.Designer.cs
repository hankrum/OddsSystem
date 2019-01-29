﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OddsSystem.Data;

namespace OddsSystem.Migrations
{
    [DbContext(typeof(MsSqlDbContext))]
    [Migration("20190129030045_InitialSeed")]
    partial class InitialSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OddsSystem.Data.Model.SportEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventName")
                        .IsRequired();

                    b.Property<DateTime>("EventStartDate");

                    b.Property<double>("OddsForDraw");

                    b.Property<double>("OddsForFirstTeam");

                    b.Property<double>("OddsForSecondTeam");

                    b.HasKey("Id");

                    b.ToTable("SportEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
