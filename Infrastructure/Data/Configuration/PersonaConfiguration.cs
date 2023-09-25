using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("persona");

            builder.HasIndex(e => e.IdDocumento, "Fk_idDocumento");

            builder.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("id");
            builder.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            builder.Property(e => e.IdDocumento).HasColumnName("idDocumento");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdDocumento)
                .HasConstraintName("Fk_idDocumento");
    }
}