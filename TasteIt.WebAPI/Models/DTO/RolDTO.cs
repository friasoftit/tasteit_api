using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class RolDTO
    {
        public RolDTO()
        {
            this.Usuarios = new List<UsuarioDTO>();
        }
        public int id { get; set; }
        public string rol { get; set; }

        public virtual ICollection<UsuarioDTO> Usuarios { get; set; }
    }
}
