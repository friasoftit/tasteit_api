using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class ComentarioEstablecimiento
    {
        public int id { get; set; }
        public string comentario { get; set; }
        public DateTime fecha { get; set; }
        public int idEstablecimiento { get; set; }
        public int idUsuario { get; set; }

        public Usuario usuario { get; set; }
        public Establecimiento establecimiento { get; set; }
    }
}
