﻿// <auto-generated />
using CurriculumVitae.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CurriculumVitae.Data.Migrations
{
    [DbContext(typeof(CurriculumVitaeDbContext))]
    [Migration("20231111115701_Initial-Cv")]
    partial class InitialCv
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.24");

            modelBuilder.Entity("CurriculumVitae.Data.Entities.ComputerVaardigheid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Niveau")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Omschrijving")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("computerVaardigheiden");
                });

            modelBuilder.Entity("CurriculumVitae.Data.Entities.TaalModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Niveau")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Taal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Talen");
                });
#pragma warning restore 612, 618
        }
    }
}
