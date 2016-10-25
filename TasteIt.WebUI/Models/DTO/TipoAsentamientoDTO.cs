using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class TipoAsentamientoDTO
    {
        public TipoAsentamientoDTO()
        {
            this.Asentamientos = new List<AsentamientoDTO>();
        }
        public int id { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<AsentamientoDTO> Asentamientos { get; set; }
    }
}
