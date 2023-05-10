﻿// <auto-generated />
using Legumos.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Legumos.Migrations
{
    [DbContext(typeof(VegetablesDbContext))]
    partial class VegetablesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Legumos.Models.Vegetable", b =>
                {
                    b.Property<int>("VegetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VegetableId"));

                    b.Property<int>("Fresh")
                        .HasColumnType("int");

                    b.Property<int>("Lifetime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("PrimaryColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variety")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VegetableId");

                    b.ToTable("tbl_vegetables");
                });
#pragma warning restore 612, 618
        }
    }
}