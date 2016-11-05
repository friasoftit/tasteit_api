using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TasteIt.Contract.Model;
using TasteIt.SQLDB.Model;
using TasteIt.SQLRepository.Model;
using TasteIt.WebAPI.Models.DTO;

namespace TasteIt.WebAPI.Controllers
{
    [RoutePrefix("api/Estado")]
    public class EstadoController : ApiController
    {
        IEstadoRepository estadoRepository;

        [HttpGet]
        [Route("GetAll")]
        public HttpResponseMessage GetAll()
        {
            estadoRepository = new EstadoRepository();

            var estados = estadoRepository.GetAll().ToList();
            List<EstadoDTO> estadosDto = new List<EstadoDTO>();
            
            foreach (Estado edo in estados)
            {
                EstadoDTO edoDto = new EstadoDTO();
                edoDto.idEstado = edo.Id;
                edoDto.nombre = edo.Nombre;
                //List<MunicipioDTO> listMuni = new List<MunicipioDTO>();
                foreach (Municipio muni in edo.Municipios)
                {
                    MunicipioDTO muniDto = new MunicipioDTO();
                    muniDto.idMunicipio = muni.Id;
                    muniDto.nombre = muni.Nombre;
                    /*
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
                    listMuni.Add(muniDto);*/
                }
                //edoDto.Municipios = listMuni;
                estadosDto.Add(edoDto);
            }

            return Request.CreateResponse(HttpStatusCode.OK, Newtonsoft.Json.JsonConvert.SerializeObject(estadosDto));
        }
    }
}
