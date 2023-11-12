using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models;

public partial class CrudDbContext : DbContext
{
    public CrudDbContext()
    {
    }

    public CrudDbContext(DbContextOptions<CrudDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CrudTb> CrudTbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1DR9999;Database=crud_db;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CrudTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__crud_tb__3214EC270AA5B44C");

            entity.ToTable("crud_tb");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First Name");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last  Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
