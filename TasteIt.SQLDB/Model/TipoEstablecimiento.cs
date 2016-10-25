namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.TipoEstablecimientos")]
    public partial class TipoEstablecimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoEstablecimiento()
        {
            Establecimientos = new HashSet<Establecimiento>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
    }
}
