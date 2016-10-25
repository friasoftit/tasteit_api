namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Catalogos.Calificaciones")]
    public partial class Calificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calificacion()
        {
            ValoracionEstablecimientos = new HashSet<ValoracionEstablecimiento>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int? Puntaje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }
    }
}
