using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class ComentarioEstablecimientoMap : EntityTypeConfiguration<ComentarioEstablecimiento>
    {
        public ComentarioEstablecimientoMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.comentario)
                .HasMaxLength(8000);

            this.Property(t => t.fecha);

            //Table & Column mappings
            this.ToTable("ComentarioEstablecimientos", "Entidades");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.comentario).HasColumnName("Comentario");
            this.Property(t => t.fecha).HasColumnName("Fecha");

            //Relationships
            this.HasRequired(t => t.establecimiento)
                .WithMany(t => t.ComentarioEstablecimientos)
                .HasForeignKey(d => d.idEstablecimiento);

            this.HasRequired(t => t.usuario)
                .WithMany(t => t.ComentarioEstablecimientos)
                .HasForeignKey(d => d.idUsuario);
        }
    }
}
