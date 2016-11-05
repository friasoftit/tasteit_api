using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class PromocionDTO
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public DateTime fechaTermino { get; set; }
        public DateTime fechaAlta { get; set; }
        public int idEstablecimiento { get; set; }
        public int idUsuario { get; set; }
        public int idImagen { get; set; }

        public EstablecimientoDTO establecimiento { get; set; }
        public UsuarioDTO usuario { get; set; }
        public ImagenDTO imagen { get; set; }
    }
}
