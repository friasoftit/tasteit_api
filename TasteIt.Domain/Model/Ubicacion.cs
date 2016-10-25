using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Ubicacion
    {
        public Ubicacion()
        {
            this.Establecimientos = new List<Establecimiento>();
            this.Usuarios = new List<Usuario>();
        }
        public int id { get; set; }
        public string direccion { get; set; }
        public int idMunicipio { get; set; }

        [ForeignKey("idMunicipio")]
        public virtual Municipio municipio { get; set; }
        public virtual ICollection<Establecimiento> Establecimientos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
