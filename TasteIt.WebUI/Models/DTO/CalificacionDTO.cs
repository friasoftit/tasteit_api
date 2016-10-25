using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class CalificacionDTO
    {
        public CalificacionDTO()
        {
            this.ValoracionEstablecimientos = new List<ValoracionEstablecimientoDTO>();
        }
        public int id { get; set; }
        public string descripcion { get; set; }
        public int puntaje { get; set; }

        public virtual ICollection<ValoracionEstablecimientoDTO> ValoracionEstablecimientos { get; set; }
    }
}
