using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class EcfSqlContext : DbContext
{
    public EcfSqlContext()
    {
    }

    public EcfSqlContext(DbContextOptions<EcfSqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductionDone> ProductionDones { get; set; }

    public virtual DbSet<ProductionLine> ProductionLines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=CRM-UC-3914\\SQLEXPRESS;Initial Catalog=ECF_SQL;User ID=Ecf_Sql_user;Password=azer; Trust Server Certificate = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__products__47027DF5EDC64392");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductionDone>(entity =>
        {
            entity.HasKey(e => e.ForgeId).HasName("PK__producti__A1B658BCE4E5A533");

            entity.Property(e => e.ForgeId).ValueGeneratedNever();
            entity.Property(e => e.LineId).IsFixedLength();

            entity.HasOne(d => d.Line).WithMany(p => p.ProductionDones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_production_done_production_line");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductionDones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_production_done_products");
        });

        modelBuilder.Entity<ProductionLine>(entity =>
        {
            entity.HasKey(e => e.LineId).HasName("PK__producti__F5AE5F6289E3D252");

            entity.Property(e => e.LineId).IsFixedLength();

            entity.HasOne(d => d.Product).WithMany(p => p.ProductionLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_production_lines_products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
