﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Actividad_S9_Almacen_de_productos.Models;

public partial class AlmacenContext : DbContext
{
    public AlmacenContext()
    {
    }

    public AlmacenContext(DbContextOptions<AlmacenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Productos> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("DESKTOP-34LHMKA\\SQLEXPRESS;Database=Almacen;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>(entity =>
        {
            entity.ToTable("Productos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(6, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
