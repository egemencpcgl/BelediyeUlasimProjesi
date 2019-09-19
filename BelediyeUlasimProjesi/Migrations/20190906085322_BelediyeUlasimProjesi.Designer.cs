﻿// <auto-generated />
using System;
using BelediyeUlasimProjesi.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BelediyeUlasimProjesi.Migrations
{
    [DbContext(typeof(BelediyeUlasimProjesiDbContext))]
    [Migration("20190906085322_BelediyeUlasimProjesi")]
    partial class BelediyeUlasimProjesi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BelediyeUlasimProjesi.Data.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<TimeSpan>("FirstDepartureTime");

                    b.Property<TimeSpan>("LastDepartureTime");

                    b.Property<int?>("StationId");

                    b.Property<string>("StationName");

                    b.HasKey("Id");

                    b.HasIndex("StationId");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("BelediyeUlasimProjesi.Data.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("StationName");

                    b.HasKey("Id");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("BelediyeUlasimProjesi.Data.Bus", b =>
                {
                    b.HasOne("BelediyeUlasimProjesi.Data.Station", "Station")
                        .WithMany("Buses")
                        .HasForeignKey("StationId");
                });
#pragma warning restore 612, 618
        }
    }
}
