using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace booksestoreApi.Models;

public partial class BooksestoreDbContext : DbContext
{
    public BooksestoreDbContext()
    {
    }

    public BooksestoreDbContext(DbContextOptions<BooksestoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Resume> Resumes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Resume>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Resume__3213E83F0056C146");

            entity.ToTable("Resume");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .HasColumnName("full_name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("phone_number");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
