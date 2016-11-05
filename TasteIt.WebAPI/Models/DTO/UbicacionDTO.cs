using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class UbicacionDTO
    {
        public UbicacionDTO()
        {
            this.Establecimientos = new List<EstablecimientoDTO>();
            this.Usuarios = new List<UsuarioDTO>();
        }
        public int id { get; set; }
        public string direccion { get; set; }
        public int idMunicipio { get; set; }

        
        public MunicipioDTO municipio { get; set; }
        public virtual ICollection<EstablecimientoDTO> Establecimientos { get; set; }
        public virtual ICollection<UsuarioDTO> Usuarios { get; set; }
    }
}
