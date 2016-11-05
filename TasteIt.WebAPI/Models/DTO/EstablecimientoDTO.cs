using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasteIt.WebAPI.Models.DTO
{
    public class EstablecimientoDTO
    {
        public EstablecimientoDTO()
        {
            this.ComentarioEstablecimientos = new List<ComentarioEstablecimientoDTO>();
            this.Promociones = new List<PromocionDTO>();
            this.ValoracionEstablecimientos = new List<ValoracionEstablecimientoDTO>();
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

        public CategoriaDTO categoria { get; set; }
        public ImagenDTO imagen { get; set; }
        public UbicacionDTO ubicacion { get; set; }
        public TipoEstablecimientoDTO tipoEstablecimiento { get; set; }

        public virtual ICollection<ComentarioEstablecimientoDTO> ComentarioEstablecimientos { get; set; }
        public virtual ICollection<PromocionDTO> Promociones { get; set; }
        public virtual ICollection<ValoracionEstablecimientoDTO> ValoracionEstablecimientos { get; set; }
    }
}
