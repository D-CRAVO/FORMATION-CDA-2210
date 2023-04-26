using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WFSpa.Models;

namespace WFSpa.Data;

public partial class SpaContext : DbContext
{
    public SpaContext()
    {
    }

    public SpaContext(DbContextOptions<SpaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CRM-UC-3914\\SQLEXPRESS;Initial Catalog=SPA;User ID=Ecf_Winform;Password=azer;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.NumeroPuce).HasName("PK__CHATS__8100B327F379200B");

            entity.ToTable("CHATS");

            entity.Property(e => e.NumeroPuce)
                .ValueGeneratedNever()
                .HasColumnName("Numero_Puce");
            entity.Property(e => e.Nom)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Race).HasDefaultValueSql("((2))");

            entity.HasOne(d => d.RaceNavigation).WithMany(p => p.Chats)
                .HasForeignKey(d => d.Race)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RACES");
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RACES__3214EC27E259E0FE");

            entity.ToTable("RACES");

            entity.HasIndex(e => e.Race1, "UQ__RACES__DF84295578777CBB").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Race1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Race");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
