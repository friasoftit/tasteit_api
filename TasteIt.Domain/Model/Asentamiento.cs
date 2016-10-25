using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TasteIt.Domain.Model
{
    public class Asentamiento
    {
        public int id { get; set; }
        public int codigoPostal { get; set; }
        public string nombre { get; set; }
        public int idTipoAsentamiento { get; set; }
        public int idMunicipio { get; set; }

        public virtual TipoAsentamiento tipoAsentamiento { get; set; }

        [ForeignKey("idMunicipio")]
        public virtual Municipio municipio { get; set; }

    }
}
