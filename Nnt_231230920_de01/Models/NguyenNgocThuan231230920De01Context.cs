using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nnt_231230920_de01.Models;

public partial class NguyenNgocThuan231230920De01Context : DbContext
{
    public NguyenNgocThuan231230920De01Context()
    {
    }

    public NguyenNgocThuan231230920De01Context(DbContextOptions<NguyenNgocThuan231230920De01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NntComputer> NntComputers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS01; Database=NguyenNgocThuan_231230920_de01;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NntComputer>(entity =>
        {
            entity.HasKey(e => e.NntComId).HasName("PK__NntCompu__9EB8B4293C4E239C");

            entity.ToTable("NntComputer");

            entity.Property(e => e.NntComId).HasMaxLength(20);
            entity.Property(e => e.NntComImage).HasMaxLength(200);
            entity.Property(e => e.NntComName).HasMaxLength(100);
            entity.Property(e => e.NntComPrice).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
