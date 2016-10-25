using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class AsentamientoMap : EntityTypeConfiguration<Asentamiento>
    {
        public AsentamientoMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.codigoPostal);

            this.Property(t => t.nombre)
                .HasMaxLength(200);

            //Table & Column mappings
            this.ToTable("Asentamientos", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.nombre).HasColumnName("Nombre");
            this.Property(t => t.codigoPostal).HasColumnName("CodigoPostal");
            this.Property(t => t.idMunicipio).HasColumnName("IdMunicipio");
            this.Property(t => t.idTipoAsentamiento).HasColumnName("IdTipoAsentamiento");

            //Relationships
            this.HasRequired(t => t.tipoAsentamiento)
                .WithMany(t => t.Asentamientos)
                .HasForeignKey(d => d.idTipoAsentamiento);

            this.HasRequired(t => t.municipio)
                .WithMany(t => t.Asentamientos)
                .HasForeignKey(d => d.idMunicipio);
        }
    }
}
