﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TourOfHeroesCore.Migrations
{
    [DbContext(typeof(HeroesContext))]
    [Migration("20200417052026_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("TourOfHeroesCore.Data.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mr. Nice"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Narco"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bombasto"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Celeritas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Magneta"
                        },
                        new
                        {
                            Id = 6,
                            Name = "RubberMan"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Dynama"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dr IQ"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Magma"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tornado"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
