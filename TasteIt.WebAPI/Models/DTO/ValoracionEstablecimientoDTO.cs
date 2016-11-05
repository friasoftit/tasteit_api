using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class ValoracionEstablecimientoDTO
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idEstablecimiento { get; set; }
        public int idCalificacion { get; set; }
        public DateTime fecha { get; set; }

        public UsuarioDTO usuario { get; set; }
        public EstablecimientoDTO establecimiento { get; set; }
        public CalificacionDTO calificacion { get; set; }
    }
}
