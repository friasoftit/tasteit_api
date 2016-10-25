using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TasteIt.Contract.Model;
using TasteIt.Domain.Model;
using TasteIt.SQLRepository.Model;

namespace TasteIt.WebUI.Controllers
{
    [RoutePrefix("api")]
    public class EstadoController : ApiController
    {
        IEstadoRepository estadoRepository;

        [HttpGet]
        [Route("ObtenerEstados")]
        public HttpResponseMessage ObtenerMunicipios()
        {
            estadoRepository = new EstadoRepository();

            IQueryable<Estado> municipios = estadoRepository.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, municipios);
        }
    }
}
