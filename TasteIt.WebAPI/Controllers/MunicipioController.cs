using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TasteIt.Contract.Model;
using TasteIt.SQLDB.Model;
using TasteIt.SQLRepository.Model;
using System.Data.Entity;
using TasteIt.WebAPI.Models;
using TasteIt.WebAPI.Models.DTO;
using System.Threading.Tasks;

namespace TasteIt.WebAPI.Controllers
{
    [RoutePrefix("api/Municipio")]
    public class MunicipioController : ApiController
    {
        IMunicipioRepository municipioRepository;

        /// <summary>
        /// Obtiene los municipios de un estado en especifico.
        /// </summary>
        /// <param name="id">Id Estado</param>
        /// <returns>Lista de los municipios del estado enviado</returns>
        [HttpGet]
        [Route("GetByIdEstado/{id}/{nombre?}")]
        public HttpResponseMessage GetByIdEstado(int id, string nombre = null) 
        {
            municipioRepository = new MunicipioRepository();

            var list = municipioRepository.GetAll().ToList();
            var municipiosPorEstado = list.Where(a => a.IdEstado == id).ToList();

            List<MunicipioDTO> listMuni = new List<MunicipioDTO>();
            foreach (Municipio muni in municipiosPorEstado)
            {
                MunicipioDTO muniDto = new MunicipioDTO();
                muniDto.idMunicipio = muni.Id;
                muniDto.nombre = muni.Nombre;
                

                List<AsentamientoDTO> listAsen = new List<AsentamientoDTO>();
                foreach (Asentamiento asen in muni.Asentamientos)
                {
                    AsentamientoDTO asenDto = new AsentamientoDTO();
                    asenDto.id = asen.Id;
                    asenDto.nombre = asen.Nombre;
                    asenDto.idTipoAsentamiento = asen.IdTipoAsentamiento;

                    listAsen.Add(asenDto);
                }
                muniDto.Asentamientos = listAsen;
                listMuni.Add(muniDto);
            }

            return Request.CreateResponse(HttpStatusCode.OK, Newtonsoft.Json.JsonConvert.SerializeObject(listMuni));
        }

        
    }
}
