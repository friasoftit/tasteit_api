using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class TipoImagenDTO
    {
        public TipoImagenDTO()
        {
            this.Imagenes = new List<ImagenDTO>();
        }

        public int id { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<ImagenDTO> Imagenes { get; set; }
    }
}
