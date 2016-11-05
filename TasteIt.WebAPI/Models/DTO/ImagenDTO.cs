using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class ImagenDTO
    {
        public ImagenDTO()
        {
            this.Establecimientos = new List<EstablecimientoDTO>();
            this.Usuarios = new List<UsuarioDTO>();
            this.Promociones = new List<PromocionDTO>();
        }
        public int id { get; set; }
        public string ruta { get; set; }
        public int idOrigenImagen { get; set; }
        public int idTipoImagen { get; set; }

        public OrigenImagenDTO origenImagen { get; set; }
        public TipoImagenDTO tipoImagen { get; set; }

        public virtual ICollection<EstablecimientoDTO> Establecimientos { get; set; }
        public virtual ICollection<UsuarioDTO> Usuarios { get; set; }
        public virtual ICollection<PromocionDTO> Promociones { get; set; }
    }
}
