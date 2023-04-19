using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WFEmployees.Models;

namespace WFEmployees.Data;

public partial class Db302EmployeesContext : DbContext
{
    public Db302EmployeesContext()
    {
    }

    public Db302EmployeesContext(DbContextOptions<Db302EmployeesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CRM-UC-3914\\SQLEXPRESS;Initial Catalog=db302_employees;User ID=db302_employees_user;Password=azer;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__employee__1299A861EF060E90");

            entity.ToTable("employees");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.EmpFirstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emp_firstname");
            entity.Property(e => e.EmpHiredate)
                .HasColumnType("date")
                .HasColumnName("emp_hiredate");
            entity.Property(e => e.EmpLastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emp_lastname");
            entity.Property(e => e.EmpManagerId).HasColumnName("emp_manager_id");
            entity.Property(e => e.EmpSalary).HasColumnName("emp_salary");

            entity.HasOne(d => d.EmpManager).WithMany(p => p.InverseEmpManager)
                .HasForeignKey(d => d.EmpManagerId)
                .HasConstraintName("fk_emp_manager_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
