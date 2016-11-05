namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entidades.RespuestaComentarios")]
    public partial class RespuestaComentario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(8000)]
        public string Comentario { get; set; }

        public int IdEscribioRespuesta { get; set; }

        public int IdComentario { get; set; }

        public DateTime? Fecha { get; set; }

        public virtual ComentarioEstablecimiento ComentarioEstablecimiento { get; set; }

        public virtual EscribioRespuesta EscribioRespuesta { get; set; }
    }
}
