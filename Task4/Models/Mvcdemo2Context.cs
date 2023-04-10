using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Task4.Models;

public partial class Mvcdemo2Context : DbContext
{
    public Mvcdemo2Context()
    {
    }

    public Mvcdemo2Context(DbContextOptions<Mvcdemo2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(" server=localhost\\SQLEXPRESS; database=MVCDemo2; Trusted_connection=true; TrustServercertifiCate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC0765C76857");

            entity.ToTable("Student");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
