using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteIt.WebUI.Models.DTO
{
    public class EstadoDTO
    {
        public EstadoDTO()
        {
            this.Municipios = new List<MunicipioDTO>();
        }
        public int idEstado { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<MunicipioDTO> Municipios { get; set; }
    }
}