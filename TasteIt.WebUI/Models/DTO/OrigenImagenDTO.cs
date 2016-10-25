using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebUI.Models.DTO
{
    public class OrigenImagenDTO
    {
        public OrigenImagenDTO()
        {
            this.Imagenes = new List<ImagenDTO>();
        }
        public int id { get; set; }
        public string nombre { get; set; }

        public virtual ICollection<ImagenDTO> Imagenes { get; set; }
    }
}
