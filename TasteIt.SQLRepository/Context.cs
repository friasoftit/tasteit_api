using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TasteIt.Domain.Mapping;
using TasteIt.Domain.Model;

namespace TasteIt.SQLRepository
{
    public partial class Context : DbContext
    {
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }
        public Context() : base("Name=TasteItContext") 
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Calificacion> Calificaciones { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ComentarioEstablecimiento> ComentarioEstablecimientos { get; set; }
        public DbSet<Establecimiento> Establecimientos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Imagen> Imagenes { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<OrigenImagen> OrigenImagenes { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Promocion> Promociones { get; set; }
        public DbSet<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }
        public DbSet<TipoImagen> TipoImagenes { get; set; }
        public DbSet<TipoAsentamiento> TipoAsentamientos { get; set; }
        public DbSet<Asentamiento> Asentamientos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CalificacionMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new ComentarioEstablecimientoMap());
            modelBuilder.Configurations.Add(new EstablecimientoMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new ImagenMap());
            modelBuilder.Configurations.Add(new MunicipioMap());
            modelBuilder.Configurations.Add(new OrigenImagenMap());
            modelBuilder.Configurations.Add(new RolMap());
            modelBuilder.Configurations.Add(new UbicacionMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new PromocionMap());
            modelBuilder.Configurations.Add(new ValoracionEstablecimientoMap());
            modelBuilder.Configurations.Add(new TipoImagenMap());
            modelBuilder.Configurations.Add(new TipoAsentamientoMap());
            modelBuilder.Configurations.Add(new AsentamientoMap());
        }
    }
}
