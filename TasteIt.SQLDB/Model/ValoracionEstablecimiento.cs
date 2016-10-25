namespace TasteIt.SQLDB.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entidades.ValoracionEstablecimientos")]
    public partial class ValoracionEstablecimiento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstablecimiento { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCalificacion { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }

        public virtual Calificacion Calificacione { get; set; }

        public virtual Establecimiento Establecimiento { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
