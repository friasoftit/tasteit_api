using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Estado
    {
        public Estado()
        {
            this.Municipios = new List<Municipio>();
        }
        public int idEstado { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
