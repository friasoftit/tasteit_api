namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.Imagenes")]
    public partial class Imagen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Imagen()
        {
            Establecimientos = new HashSet<Establecimiento>();
            Promociones = new HashSet<Promocion>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(4000)]
        public string Ruta { get; set; }

        public int IdOrigenImagen { get; set; }

        public int IdTipoImagenes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Establecimiento> Establecimientos { get; set; }

        public virtual OrigenImagen OrigenImagene { get; set; }

        public virtual TipoImagen TipoImagene { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promocion> Promociones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
