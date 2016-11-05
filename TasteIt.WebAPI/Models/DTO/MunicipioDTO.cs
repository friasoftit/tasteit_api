using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteIt.WebAPI.Models.DTO
{
    public class MunicipioDTO
    {
        public MunicipioDTO()
        {
            this.Ubicaciones = new List<UbicacionDTO>();
            this.Asentamientos = new List<AsentamientoDTO>();
        }
        public int idMunicipio { get; set; }
        public string nombre { get; set; }
        public int idEstado { get; set; }

        
        public virtual EstadoDTO estado { get; set; }
        public virtual ICollection<UbicacionDTO> Ubicaciones { get; set; }        
        public virtual ICollection<AsentamientoDTO> Asentamientos { get; set; }
    }
}