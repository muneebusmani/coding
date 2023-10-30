using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sir_Faizan_Method.Models;

public partial class SirFaizanMethodContext : DbContext
{
    public SirFaizanMethodContext()
    {
    }

    public SirFaizanMethodContext(DbContextOptions<SirFaizanMethodContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SirFaizanMethodTable> SirFaizanMethodTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=Sir_Faizan_Method;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SirFaizanMethodTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sir_Faiz__3214EC07685999E3");

            entity.ToTable("Sir_Faizan_Method_Table");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
