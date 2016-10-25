using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class MunicipioMap : EntityTypeConfiguration<Municipio>
    {
        public MunicipioMap()
        {
            //Primary Key
            this.HasKey(t => t.idMunicipio);

            //Properties
            this.Property(t => t.nombre)
                .HasMaxLength(50);

            //Table & Column mappings
            this.ToTable("Municipios", "Catalogos");
            this.Property(t => t.idMunicipio).HasColumnName("Id");
            this.Property(t => t.nombre).HasColumnName("Nombre");
            this.Property(t => t.idEstado).HasColumnName("IdEstado");

            //Relationships
            this.HasRequired(t => t.estado)
                .WithMany(t => t.Municipios)
                .HasForeignKey(d => d.idEstado);
        }
    }
}
