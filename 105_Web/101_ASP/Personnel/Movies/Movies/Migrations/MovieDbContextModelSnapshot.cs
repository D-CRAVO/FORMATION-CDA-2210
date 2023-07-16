﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Db;

#nullable disable

namespace Movies.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"));

                    b.Property<string>("Actor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("movie_actor");

                    b.Property<string>("Actress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("movie_actress");

                    b.Property<bool>("Awards")
                        .HasColumnType("bit")
                        .HasColumnName("movie_awards");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("movie_director");

                    b.Property<int>("Length")
                        .HasColumnType("int")
                        .HasColumnName("movie_length");

                    b.Property<int>("Popularity")
                        .HasColumnType("int")
                        .HasColumnName("movie_popularity");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("movie_subject");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("movie_title");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2")
                        .HasColumnName("movie_year");

                    b.HasKey("MovieId");

                    b.ToTable("tbl_movies");
                });
#pragma warning restore 612, 618
        }
    }
}
