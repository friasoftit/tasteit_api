namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TasteItModel : DbContext
    {
        public TasteItModel()
            : base("name=TasteIt_Model")
        {
        }

        public virtual DbSet<Asentamiento> Asentamientos { get; set; }
        public virtual DbSet<Calificacion> Calificaciones { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Establecimiento> Establecimientos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Imagen> Imagenes { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<OrigenImagen> OrigenImagenes { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<TipoAsentamiento> TipoAsentamientos { get; set; }
        public virtual DbSet<TipoEstablecimiento> TipoEstablecimientos { get; set; }
        public virtual DbSet<TipoImagen> TipoImagenes { get; set; }
        public virtual DbSet<Ubicacion> Ubicaciones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<ComentarioEstablecimiento> ComentarioEstablecimientos { get; set; }
        public virtual DbSet<Promocion> Promociones { get; set; }
        public virtual DbSet<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asentamiento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Calificacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Calificacion>()
                .HasMany(e => e.ValoracionEstablecimientos)
                .WithRequired(e => e.Calificacione)
                .HasForeignKey(e => e.IdCalificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Establecimientos)
                .WithRequired(e => e.Categoria)
                .HasForeignKey(e => e.IdCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Establecimiento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Establecimiento>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Establecimiento>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Establecimiento>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<Establecimiento>()
                .Property(e => e.Latitud)
                .HasPrecision(9, 6);

            modelBuilder.Entity<Establecimiento>()
                .Property(e => e.Longitud)
                .HasPrecision(9, 6);

            modelBuilder.Entity<Establecimiento>()
                .HasMany(e => e.ComentarioEstablecimientos)
                .WithRequired(e => e.Establecimiento)
                .HasForeignKey(e => e.IdEstablecimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Establecimiento>()
                .HasMany(e => e.Promociones)
                .WithRequired(e => e.Establecimiento)
                .HasForeignKey(e => e.IdEstablecimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Establecimiento>()
                .HasMany(e => e.ValoracionEstablecimientos)
                .WithRequired(e => e.Establecimiento)
                .HasForeignKey(e => e.IdEstablecimiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Municipios)
                .WithRequired(e => e.Estado)
                .HasForeignKey(e => e.IdEstado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Imagen>()
                .Property(e => e.Ruta)
                .IsUnicode(false);

            modelBuilder.Entity<Imagen>()
                .HasMany(e => e.Establecimientos)
                .WithOptional(e => e.Imagene)
                .HasForeignKey(e => e.IdImagen);

            modelBuilder.Entity<Imagen>()
                .HasMany(e => e.Promociones)
                .WithRequired(e => e.Imagene)
                .HasForeignKey(e => e.IdImagen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Imagen>()
                .HasMany(e => e.Usuarios)
                .WithOptional(e => e.Imagene)
                .HasForeignKey(e => e.IdImagen);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Municipio>()
                .HasMany(e => e.Asentamientos)
                .WithRequired(e => e.Municipio)
                .HasForeignKey(e => e.IdMunicipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Municipio>()
                .HasMany(e => e.Ubicaciones)
                .WithRequired(e => e.Municipio)
                .HasForeignKey(e => e.IdMunicipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrigenImagen>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<OrigenImagen>()
                .HasMany(e => e.Imagenes)
                .WithRequired(e => e.OrigenImagene)
                .HasForeignKey(e => e.IdOrigenImagen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.rol)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.IdRol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoAsentamiento>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoAsentamiento>()
                .HasMany(e => e.Asentamientos)
                .WithRequired(e => e.TipoAsentamiento)
                .HasForeignKey(e => e.IdTipoAsentamiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoEstablecimiento>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoEstablecimiento>()
                .HasMany(e => e.Establecimientos)
                .WithOptional(e => e.TipoEstablecimiento)
                .HasForeignKey(e => e.IdTipoEstablecimiento);

            modelBuilder.Entity<TipoImagen>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoImagen>()
                .HasMany(e => e.Imagenes)
                .WithRequired(e => e.TipoImagene)
                .HasForeignKey(e => e.IdTipoImagenes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .HasMany(e => e.Establecimientos)
                .WithRequired(e => e.Ubicacione)
                .HasForeignKey(e => e.IdUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ubicacion>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Ubicacione)
                .HasForeignKey(e => e.IdUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.ComentarioEstablecimientos)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Promociones)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.ValoracionEstablecimientos)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.IdUsuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ComentarioEstablecimiento>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Promocion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
