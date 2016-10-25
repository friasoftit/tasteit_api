using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TasteIt.Contract.Model;
using TasteIt.Domain.Model;
using TasteIt.SQLRepository.Model;
using System.Data.Entity;
using TasteIt.WebUI.Models;
using TasteIt.WebUI.Models.DTO;

namespace TasteIt.WebUI.Controllers
{
    [RoutePrefix("api")]
    public class MunicipioController : ApiController
    {
        IMunicipioRepository municipioRepository;
        IAsentamientoRepository asentamientoRepository;
        IUbicacionRepository ubicacionRepository;

        [HttpGet]
        [Route("ObtenerMunicipios")]
        public HttpResponseMessage ObtenerMunicipios()
        {
            municipioRepository = new MunicipioRepository();
            asentamientoRepository = new AsentamientoRepository();
            ubicacionRepository = new UbicacionRepository();

            var list = municipioRepository.GetAll();

            //var config = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<Municipio, MunicipioDTO>());
            //var mapper = config.CreateMapper();
            //List<MunicipioDTO> listDTO = mapper.Map <List<MunicipioDTO>>(municipioRepository.GetAll());

            List<MunicipioDTO> _municipios = new List<MunicipioDTO>();
            foreach (var item in list)
            {
                MunicipioDTO _municipio = new MunicipioDTO();
                _municipio.idMunicipio = item.idMunicipio;
                _municipio.nombre = item.nombre;
                _municipio.idEstado = item.idEstado;
                _municipio.estado = new Models.DTO.EstadoDTO
                {
                    idEstado = item.estado.idEstado,
                    nombre = item.estado.nombre
                };
                var _asentamientos = asentamientoRepository
                    .Filter((x => x.idMunicipio == item.idMunicipio))
                    .Select(s => new AsentamientoDTO 
                    {
                        id = s.id,
                        codigoPostal = s.codigoPostal,
                        nombre = s.nombre,
                        idTipoAsentamiento = s.idTipoAsentamiento,
                        idMunicipio = s.idMunicipio
                    });
                var _ubicaciones = ubicacionRepository
                    .Filter((x => x.idMunicipio == item.idMunicipio))
                    .Select(s => new UbicacionDTO 
                    { 
                        id = s.id,
                        direccion = s.direccion,
                        idMunicipio = s.idMunicipio
                    });

                _municipio.Asentamientos = _asentamientos.ToList();
                _municipio.Ubicaciones = _ubicaciones.ToList();
                _municipios.Add(_municipio);
            }

            return Request.CreateResponse(HttpStatusCode.OK, _municipios);
        }

        [HttpGet]
        [Route("ObtenerMunicipiosPorIdEstado")]
        public HttpResponseMessage ObtenerMunicipiosPorIdEstado(int idEstado) 
        {
            municipioRepository = new MunicipioRepository();

            var list = municipioRepository.GetAll().Where(a => a.idEstado == idEstado);

            return Request.CreateResponse(HttpStatusCode.OK, list);
        }
    }
}
