using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WFCarsOwners.Models;

namespace WFCarsOwners.Data;

public partial class Db303CarsownersContext : DbContext
{
    public Db303CarsownersContext()
    {
    }

    public Db303CarsownersContext(DbContextOptions<Db303CarsownersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CRM-UC-3914\\SQLEXPRESS;Initial Catalog=db303_carsowners;User ID=db303_carsowners_user;Password=azer;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__brands__5E5A8E27AE084A6F");

            entity.ToTable("brands");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("brand_name");
            entity.Property(e => e.BrandSlogan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("brand_slogan");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__cars__4C9A0DB3355149D3");

            entity.ToTable("cars");

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CarName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("car_name");

            entity.HasOne(d => d.Brand).WithMany(p => p.Cars)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cars_brands");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasName("PK__owners__3C4FBEE467148A1F");

            entity.ToTable("owners");

            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.OwnerFirstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("owner_firstname");
            entity.Property(e => e.OwnerLastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("owner_lastname");
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => new { e.CarId, e.CarOwnerId }).HasName("PK__registra__0A3F450491D88215");

            entity.ToTable("registrations");

            entity.HasIndex(e => e.CarRegistration, "UQ__registra__DC479F05578B751D").IsUnique();

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarOwnerId).HasColumnName("car_owner_id");
            entity.Property(e => e.CarRegistration)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("car_registration");

            entity.HasOne(d => d.Car).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_registration_cars");

            entity.HasOne(d => d.CarOwner).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.CarOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_registration_owners");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
