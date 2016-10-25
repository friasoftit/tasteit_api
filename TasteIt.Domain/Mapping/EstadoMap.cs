using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            //Primary Key
            this.HasKey(t => t.idEstado);

            //Properties
            this.Property(t => t.nombre)
                .HasMaxLength(100);

            //Table & Column mappings
            this.ToTable("Estados", "Catalogos");
            this.Property(t => t.idEstado).HasColumnName("Id");
            this.Property(t => t.nombre).HasColumnName("Nombre");
        }
    }
}
