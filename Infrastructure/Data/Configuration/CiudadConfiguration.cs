using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("ciudad");

            builder.HasIndex(e => e.IddepartamentoFk, "FK_iddepartamento");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.IddepartamentoFk).HasColumnName("iddepartamentoFk");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IddepartamentoFkNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.IddepartamentoFk)
                .HasConstraintName("FK_iddepartamento");
    }
}