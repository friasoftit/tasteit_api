using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Municipio
    {
        public Municipio()
        {
            this.Ubicaciones = new List<Ubicacion>();
            this.Asentamientos = new List<Asentamiento>();
        }
        public int idMunicipio { get; set; }
        public string nombre { get; set; }
        public int idEstado { get; set; }


        [ForeignKey("idEstado")]
        public virtual Estado estado { get; set; }
        
        public virtual ICollection<Ubicacion> Ubicaciones { get; set; }
        
        public virtual ICollection<Asentamiento> Asentamientos { get; set; }
    }
}
