using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class PromocionMap : EntityTypeConfiguration<Promocion>
    {
        public PromocionMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.descripcion)
                .HasMaxLength(200);

            this.Property(t => t.fechaPublicacion);

            this.Property(t => t.fechaTermino);

            this.Property(t => t.fechaAlta);

            //Table & Column mappings
            this.ToTable("Promociones", "Entidades");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.descripcion).HasColumnName("Descripcion");
            this.Property(t => t.fechaPublicacion).HasColumnName("FechaPublicacion");
            this.Property(t => t.fechaTermino).HasColumnName("FechaTermino");
            this.Property(t => t.fechaAlta).HasColumnName("FechaAlta");

            //Relationships
            this.HasRequired(t => t.establecimiento)
                .WithMany(t => t.Promociones)
                .HasForeignKey(d => d.idEstablecimiento);

            this.HasRequired(t => t.usuario)
                .WithMany(t => t.Promociones)
                .HasForeignKey(d => d.idUsuario);

            this.HasRequired(t => t.imagen)
                .WithMany(t => t.Promociones)
                .HasForeignKey(d => d.idImagen);
        }
    }
}
