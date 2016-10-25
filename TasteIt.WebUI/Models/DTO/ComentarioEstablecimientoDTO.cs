using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class ComentarioEstablecimientoDTO
    {
        public int id { get; set; }
        public string comentario { get; set; }
        public DateTime fecha { get; set; }
        public int idEstablecimiento { get; set; }
        public int idUsuario { get; set; }

        public UsuarioDTO usuario { get; set; }
        public EstablecimientoDTO establecimiento { get; set; }
    }
}
