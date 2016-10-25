namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.TipoAsentamientos")]
    public partial class TipoAsentamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoAsentamiento()
        {
            Asentamientos = new HashSet<Asentamiento>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asentamiento> Asentamientos { get; set; }
    }
}
