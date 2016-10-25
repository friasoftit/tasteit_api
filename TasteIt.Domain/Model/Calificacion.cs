using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Calificacion
    {
        public Calificacion()
        {
            this.ValoracionEstablecimientos = new List<ValoracionEstablecimiento>();
        }
        public int id { get; set; }
        public string descripcion { get; set; }
        public int puntaje { get; set; }

        public virtual ICollection<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }
    }
}
