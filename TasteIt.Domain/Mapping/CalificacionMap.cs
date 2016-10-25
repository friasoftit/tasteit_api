using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class CalificacionMap : EntityTypeConfiguration<Calificacion>
    {
        public CalificacionMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.descripcion)
                .HasMaxLength(50);

            this.Property(t => t.puntaje);

            //Table & Column mappings
            this.ToTable("Calificaciones", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.descripcion).HasColumnName("Descripcion");
            this.Property(t => t.puntaje).HasColumnName("Puntaje");
        }
    }
}
