namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.Establecimientos")]
    public partial class Establecimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Establecimiento()
        {
            ComentarioEstablecimientos = new HashSet<ComentarioEstablecimiento>();
            EscribioRespuestas = new HashSet<EscribioRespuesta>();
            Promociones = new HashSet<Promocion>();
            ValoracionEstablecimientos = new HashSet<ValoracionEstablecimiento>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Contacto { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        public int IdCategoria { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }

        public int? IdImagen { get; set; }

        public int IdTipoEstablecimiento { get; set; }

        public int IdAsentamiento { get; set; }

        public virtual Asentamiento Asentamiento { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComentarioEstablecimiento> ComentarioEstablecimientos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EscribioRespuesta> EscribioRespuestas { get; set; }

        public virtual Imagen Imagene { get; set; }

        public virtual TipoEstablecimiento TipoEstablecimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promocion> Promociones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }
    }
}
