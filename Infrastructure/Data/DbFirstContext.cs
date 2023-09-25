using System;
using System.Collections.Generic;
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class DbFirstContext : DbContext
{
    public DbFirstContext()
    {
    }

    public DbFirstContext(DbContextOptions<DbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<UbicacionPersona> UbicacionPersonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");
/*
        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ciudad");

            entity.HasIndex(e => e.IddepartamentoFk, "FK_iddepartamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IddepartamentoFk).HasColumnName("iddepartamentoFk");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IddepartamentoFkNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.IddepartamentoFk)
                .HasConstraintName("FK_iddepartamento");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("departamento");

            entity.HasIndex(e => e.IdpaisFk, "FK_idpais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdpaisFk).HasColumnName("idpaisFk");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdpaisFkNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdpaisFk)
                .HasConstraintName("FK_idpais");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pais");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("persona");

            entity.HasIndex(e => e.IdDocumento, "Fk_idDocumento");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("id");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.IdDocumento).HasColumnName("idDocumento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("Fk_idDocumento");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipoDocumento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<UbicacionPersona>(entity =>
        {
            entity.HasKey(e => e.IdDireccion).HasName("PRIMARY");

            entity.ToTable("ubicacionPersona");

            entity.HasIndex(e => e.IdCiudad, "FK_idCiudad");

            entity.HasIndex(e => e.IdPersona, "FK_idPersona");

            entity.Property(e => e.IdDireccion).HasColumnName("idDireccion");
            entity.Property(e => e.Bis)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("bis");
            entity.Property(e => e.Cardinal)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinal");
            entity.Property(e => e.CardinalSec)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cardinalSec");
            entity.Property(e => e.Complemento)
                .HasMaxLength(50)
                .HasColumnName("complemento");
            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.IdPersona)
                .HasMaxLength(20)
                .HasColumnName("idPersona");
            entity.Property(e => e.Letra)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letra");
            entity.Property(e => e.LetraSec)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letraSec");
            entity.Property(e => e.LetraTer)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("letraTer");
            entity.Property(e => e.NumeroPri).HasColumnName("numeroPri");
            entity.Property(e => e.NumeroSec).HasColumnName("numeroSec");
            entity.Property(e => e.NumeroTer).HasColumnName("numeroTer");
            entity.Property(e => e.TipoDeVia)
                .HasMaxLength(50)
                .HasColumnName("tipoDeVia");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.UbicacionPersonas)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("FK_idCiudad");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.UbicacionPersonas)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("FK_idPersona");
        });
*/
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
