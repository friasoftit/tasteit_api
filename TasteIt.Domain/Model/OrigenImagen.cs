using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class OrigenImagen
    {
        public OrigenImagen()
        {
            this.Imagenes = new List<Imagen>();
        }
        public int id { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<Imagen> Imagenes { get; set; }
    }
}
