using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.Domain.Model
{
    public class TipoEstablecimiento
    {
        public TipoEstablecimiento()
        {
            this.Establecimientos = new List<Establecimiento>();
        }
        public int id { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
    }
}
