using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class TipoImagen
    {
        public TipoImagen()
        {
            this.Imagenes = new List<Imagen>();
        }

        public int id { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<Imagen> Imagenes { get; set; }
    }
}
