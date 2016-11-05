namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.Usuarios")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            ComentarioEstablecimientos = new HashSet<ComentarioEstablecimiento>();
            EscribioRespuestas = new HashSet<EscribioRespuesta>();
            ValoracionEstablecimientos = new HashSet<ValoracionEstablecimiento>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [Column("Usuario")]
        [Required]
        [StringLength(50)]
        public string Usuario1 { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Contrasenia { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(100)]
        public string CorreoElectronico { get; set; }

        public int IdRol { get; set; }

        public int? IdImagen { get; set; }

        public virtual Imagen Imagene { get; set; }

        public virtual Rol Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComentarioEstablecimiento> ComentarioEstablecimientos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EscribioRespuesta> EscribioRespuestas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }
    }
}
