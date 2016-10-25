namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entidades.ComentarioEstablecimientos")]
    public partial class ComentarioEstablecimiento
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8000)]
        public string Comentario { get; set; }

        public DateTime Fecha { get; set; }

        public int IdEstablecimiento { get; set; }

        public int IdUsuario { get; set; }

        public virtual Establecimiento Establecimiento { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
