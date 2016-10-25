using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class TipoEstablecimientoDTO
    {
        public TipoEstablecimientoDTO()
        {
            this.Establecimientos = new List<EstablecimientoDTO>();
        }
        public int id { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<EstablecimientoDTO> Establecimientos { get; set; }
    }
}
