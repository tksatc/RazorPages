﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPages.Models;

namespace RazorPages.Migrations
{
    [DbContext(typeof(SpaContext))]
    partial class SpaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPages.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServicesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ServicesID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContactEmail = "wilma@flint.net",
                            Name = "Wilma Flintstone",
                            ServicesID = 1
                        },
                        new
                        {
                            ID = 2,
                            ContactEmail = "Barn@rubb.com",
                            Name = "Barney Rubble",
                            ServicesID = 7
                        },
                        new
                        {
                            ID = 3,
                            ContactEmail = "betts@rubb.com",
                            Name = "Betty Rubble",
                            ServicesID = 5
                        });
                });

            modelBuilder.Entity("RazorPages.Models.Services", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Classification = "Full",
                            Fee = 450.0,
                            Name = "Full-Day Treatment Package"
                        },
                        new
                        {
                            ID = 2,
                            Classification = "Half",
                            Fee = 300.0,
                            Name = "Half-Day Treatment Package"
                        },
                        new
                        {
                            ID = 3,
                            Classification = "Two",
                            Fee = 225.0,
                            Name = "Two-Hour Treatment Package"
                        },
                        new
                        {
                            ID = 4,
                            Classification = "One",
                            Fee = 100.0,
                            Name = "One-Hour Treatment Package"
                        },
                        new
                        {
                            ID = 5,
                            Classification = "Other",
                            Fee = 200.0,
                            Name = "Custom Treatment Package"
                        },
                        new
                        {
                            ID = 6,
                            Classification = "Salon",
                            Fee = 45.0,
                            Name = "Haircut or Trim"
                        },
                        new
                        {
                            ID = 7,
                            Classification = "Salon",
                            Fee = 100.0,
                            Name = "Full Foil Color"
                        });
                });

            modelBuilder.Entity("RazorPages.Models.Contact", b =>
                {
                    b.HasOne("RazorPages.Models.Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
