namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entidades.EscribioRespuesta")]
    public partial class EscribioRespuesta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EscribioRespuesta()
        {
            RespuestaComentarios = new HashSet<RespuestaComentario>();
        }

        public int Id { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdEstablecimineto { get; set; }

        public virtual Establecimiento Establecimiento { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RespuestaComentario> RespuestaComentarios { get; set; }
    }
}
