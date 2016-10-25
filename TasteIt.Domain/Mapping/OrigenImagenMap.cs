using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class OrigenImagenMap : EntityTypeConfiguration<OrigenImagen>
    {
        public OrigenImagenMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.nombre)
                .HasMaxLength(100);

            //Table & Column mappings
            this.ToTable("OrigenImagenes", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.nombre).HasColumnName("Nombre");
        }
    }
}
