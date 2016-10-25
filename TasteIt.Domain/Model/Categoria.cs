using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Categoria
    {
        public Categoria()
        {
            this.Establecimientos = new List<Establecimiento>();
        }
        public int id { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
    }
}
