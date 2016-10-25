using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteIt.Domain.Model
{
    public class Establecimiento
    {
        public Establecimiento()
        {
            this.ComentarioEstablecimientos = new List<ComentarioEstablecimiento>();
            this.Promociones = new List<Promocion>();
            this.ValoracionEstablecimientos = new List<ValoracionEstablecimiento>();
        }
        public int id { get; set; }
        public string nombre { get; set; }
        public string contacto { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public decimal latitud { get; set; }
        public decimal longitud { get; set; }
        public int idCategoria { get; set; }
        public int idUbicacion { get; set; }
        public int idImagen { get; set; }
        public int idTipoEstablecimiento { get; set; }

        public Categoria categoria { get; set; }
        public Imagen imagen { get; set; }
        public Ubicacion ubicacion { get; set; }
        public TipoEstablecimiento tipoEstablecimiento { get; set; }

        public virtual ICollection<ComentarioEstablecimiento> ComentarioEstablecimientos { get; set; }
        public virtual ICollection<Promocion> Promociones { get; set; }
        public virtual ICollection<ValoracionEstablecimiento> ValoracionEstablecimientos { get; set; }
    }
}
