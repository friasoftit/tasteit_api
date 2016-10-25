using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class AsentamientoDTO
    {
        public int id { get; set; }
        public int codigoPostal { get; set; }
        public string nombre { get; set; }
        public int idTipoAsentamiento { get; set; }
        public int idMunicipio { get; set; }

        public virtual TipoAsentamientoDTO tipoAsentamiento { get; set; }
        public virtual MunicipioDTO municipio { get; set; }
    }
}
