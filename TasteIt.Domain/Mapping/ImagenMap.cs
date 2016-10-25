using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class ImagenMap : EntityTypeConfiguration<Imagen>
    {
        public ImagenMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.ruta)
                .HasMaxLength(4000);

            //Table & Column mappings
            this.ToTable("Imagenes", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.ruta).HasColumnName("Ruta");

            //Relationships
            this.HasRequired(t => t.origenImagen)
                .WithMany(t => t.Imagenes)
                .HasForeignKey(d => d.idOrigenImagen);

            this.HasRequired(t => t.tipoImagen)
                .WithMany(t => t.Imagenes)
                .HasForeignKey(d => d.idTipoImagen);
        }
    }
}
