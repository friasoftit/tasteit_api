using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class TipoAsentamiento
    {
        public TipoAsentamiento()
        {
            this.Asentamientos = new List<Asentamiento>();
        }
        public int id { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<Asentamiento> Asentamientos { get; set; }
    }
}
