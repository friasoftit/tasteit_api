using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //Primary Key
            this.HasKey(t => t.id);

            //Properties
            this.Property(t => t.nombre)
                .HasMaxLength(50);

            this.Property(t => t.apellidoMaterno)
                .HasMaxLength(50);

            this.Property(t => t.apellidoPaterno)
                .HasMaxLength(50);

            this.Property(t => t.usuario)
                .HasMaxLength(50);

            this.Property(t => t.contrasenia);

            this.Property(t => t.edad);

            this.Property(t => t.email);

            //Table & Column mappings
            this.ToTable("Usuarios", "Catalogos");
            this.Property(t => t.id).HasColumnName("Id");
            this.Property(t => t.nombre).HasColumnName("Nombre");
            this.Property(t => t.apellidoMaterno).HasColumnName("ApellidoMaterno");
            this.Property(t => t.apellidoPaterno).HasColumnName("ApellidoPaterno");
            this.Property(t => t.usuario).HasColumnName("Usuario");
            this.Property(t => t.contrasenia).HasColumnName("Contrasenia");
            this.Property(t => t.edad).HasColumnName("Edad");
            this.Property(t => t.email).HasColumnName("CorreoElectronico");
            
            //Relationships
            this.HasRequired(t => t.rol)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.idRol);

            this.HasRequired(t => t.ubicacion)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.idUbicacion);

            this.HasRequired(t => t.imagen)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.idImagen);
        }
    }
}
