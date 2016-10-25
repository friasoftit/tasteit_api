using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class EstablecimientoMap : EntityTypeConfiguration<Establecimiento>
    {
        public EstablecimientoMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.nombre)
                .HasMaxLength(100);

            this.Property(t => t.telefono)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(50);

            this.Property(t => t.latitud);

            this.Property(t => t.longitud);

            //Table & Column mappings
            this.ToTable("Establecimientos", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.nombre).HasColumnName("Nombre");
            this.Property(t => t.contacto).HasColumnName("Contacto");
            this.Property(t => t.telefono).HasColumnName("Telefono");
            this.Property(t => t.email).HasColumnName("CorreoElectronico");
            this.Property(t => t.latitud).HasColumnName("Latitud");
            this.Property(t => t.longitud).HasColumnName("Longitud");

            //Relationships
            this.HasRequired(t => t.categoria)
                .WithMany(t => t.Establecimientos)
                .HasForeignKey(d => d.idCategoria);

            this.HasRequired(t => t.ubicacion)
                .WithMany(t => t.Establecimientos)
                .HasForeignKey(d => d.idUbicacion);

            this.HasRequired(t => t.imagen)
                .WithMany(t => t.Establecimientos)
                .HasForeignKey(d => d.idImagen);

            this.HasRequired(t => t.tipoEstablecimiento)
                .WithMany(t => t.Establecimientos)
                .HasForeignKey(d => d.idTipoEstablecimiento);
        }
    }
}
