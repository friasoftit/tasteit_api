using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class ValoracionEstablecimiento
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idEstablecimiento { get; set; }
        public int idCalificacion { get; set; }
        public DateTime fecha { get; set; }

        public Usuario usuario { get; set; }
        public Establecimiento establecimiento { get; set; }
        public Calificacion calificacion { get; set; }
    }
}
