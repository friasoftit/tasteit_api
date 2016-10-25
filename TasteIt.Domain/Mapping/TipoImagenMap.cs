﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class TipoImagenMap : EntityTypeConfiguration<TipoImagen>
    {
        public TipoImagenMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.tipo)
                .HasMaxLength(50);

            //Table & Column mappings
            this.ToTable("TipoImagenes", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.tipo).HasColumnName("Tipo");
        }
    }
}
