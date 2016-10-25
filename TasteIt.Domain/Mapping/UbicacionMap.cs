using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class UbicacionMap : EntityTypeConfiguration<Ubicacion>
    {
        public UbicacionMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.direccion)
                .HasMaxLength(100);

            //Table & Column mappings
            this.ToTable("Ubicaciones", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.direccion).HasColumnName("Direccion");

            //Relationships
            this.HasRequired(t => t.municipio)
                .WithMany(t => t.Ubicaciones)
                .HasForeignKey(d => d.idMunicipio);
        }
    }
}
