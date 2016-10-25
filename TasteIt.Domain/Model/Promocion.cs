using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Promocion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public DateTime fechaTermino { get; set; }
        public DateTime fechaAlta { get; set; }
        public int idEstablecimiento { get; set; }
        public int idUsuario { get; set; }
        public int idImagen { get; set; }

        public Establecimiento establecimiento { get; set; }
        public Usuario usuario { get; set; }
        public Imagen imagen { get; set; }
    }
}
