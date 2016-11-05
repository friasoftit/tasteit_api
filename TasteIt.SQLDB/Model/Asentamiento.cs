namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.Asentamientos")]
    public partial class Asentamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asentamiento()
        {
            Establecimientos = new HashSet<Establecimiento>();
        }

        public int Id { get; set; }

        public int CodigoPostal { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public int IdTipoAsentamiento { get; set; }

        public int IdMunicipio { get; set; }

        public virtual Municipio Municipio { get; set; }

        public virtual TipoAsentamiento TipoAsentamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
    }
}
