using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDTO()
        {
            this.ComentarioEstablecimientos = new List<ComentarioEstablecimientoDTO>();
            this.Promociones = new List<PromocionDTO>();
            this.ValoracionEstablecimientos = new List<ValoracionEstablecimientoDTO>();
        }
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string usuario { get; set; }
        public byte[] contrasenia { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public int idRol { get; set; }
        public int idUbicacion { get; set; }
        public int idImagen { get; set; }

        public RolDTO rol { get; set; }
        public UbicacionDTO ubicacion { get; set; }
        public ImagenDTO imagen { get; set; }

        public virtual ICollection<ComentarioEstablecimientoDTO> ComentarioEstablecimientos { get; set; }
        public virtual ICollection<PromocionDTO> Promociones { get; set; }
        public virtual ICollection<ValoracionEstablecimientoDTO> ValoracionEstablecimientos { get; set; }
    }
}
