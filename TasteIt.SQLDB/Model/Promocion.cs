namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entidades.Promociones")]
    public partial class Promocion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public DateTime FechaTermino { get; set; }

        public DateTime FechaAlta { get; set; }

        public int IdEstablecimiento { get; set; }

        public int IdImagen { get; set; }

        public virtual Establecimiento Establecimiento { get; set; }

        public virtual Imagen Imagene { get; set; }
    }
}
