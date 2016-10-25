using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class CategoriaDTO
    {
        public CategoriaDTO()
        {
            this.Establecimientos = new List<EstablecimientoDTO>();
        }
        public int id { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<EstablecimientoDTO> Establecimientos { get; set; }
    }
}
