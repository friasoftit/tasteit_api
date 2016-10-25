using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Rol
    {
        public Rol()
        {
            this.Usuarios = new List<Usuario>();
        }
        public int id { get; set; }
        public string rol { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
