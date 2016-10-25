using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Usuario
    {
        public Usuario()
        {
            this.ComentarioEstablecimientos = new List<ComentarioEstablecimiento>();
            this.Promociones = new List<Promocion>();
            this.ValoracionEstablecimientos = new List<ValoracionEstablecimiento>();
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

        public Rol rol { get; set; }
        public Ubicacion ubicacion { get; set; }
        public Imagen imagen { get; set; }

        public virtual ICollection<ComentarioEstablecimiento> ComentarioEstablecimientos { get; set; }
        public virtual ICollection<Promocion> Promociones { get; set; }
        public virtual ICollection<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }

    }
}
