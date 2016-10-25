using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteIt.Domain.Model;

namespace TasteIt.Domain.Model
{
    public class Imagen
    {
        public Imagen()
        {
            this.Establecimientos = new List<Establecimiento>();
            this.Usuarios = new List<Usuario>();
            this.Promociones = new List<Promocion>();
        }
        public int id { get; set; }
        public string ruta { get; set; }
        public int idOrigenImagen { get; set; }
        public int idTipoImagen { get; set; }

        public OrigenImagen origenImagen { get; set; }
        public TipoImagen tipoImagen { get; set; }

        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Promocion> Promociones { get; set; }


    }
}
