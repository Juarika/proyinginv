using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
        builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("departamento");

            builder.HasIndex(e => e.IdpaisFk, "FK_idpais");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.IdpaisFk).HasColumnName("idpaisFk");
            builder.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IdpaisFkNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdpaisFk)
                .HasConstraintName("FK_idpais");
    }
}