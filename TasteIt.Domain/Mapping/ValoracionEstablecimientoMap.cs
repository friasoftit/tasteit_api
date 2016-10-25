using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class ValoracionEstablecimientoMap : EntityTypeConfiguration<ValoracionEstablecimiento>
    {
        public ValoracionEstablecimientoMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.fecha);

            //Table & Column mappings
            this.ToTable("ValoracionEstablecimientos", "Entidades");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.fecha).HasColumnName("Fecha");

            //Relationships
            this.HasRequired(t => t.usuario)
                .WithMany(t => t.ValoracionEstablecimientos)
                .HasForeignKey(d => d.idUsuario);

            this.HasRequired(t => t.establecimiento)
                .WithMany(t => t.ValoracionEstablecimientos)
                .HasForeignKey(d => d.idEstablecimiento);

            this.HasRequired(t => t.calificacion)
                .WithMany(t => t.ValoracionEstablecimientos)
                .HasForeignKey(d => d.idCalificacion);
        }
    }
}
