using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TasteIt.Contract.Model;
using TasteIt.SQLDB.Model;
using TasteIt.SQLRepository.Model;

namespace TasteIt.WebAPI.Controllers
{
    [RoutePrefix("api/Establecimiento")]
    public class EstablecimientoController : ApiController
    {
        IEstablecimientoRepository establecimientoRepository;

        [HttpGet]
        [Route("ObtenerEstablecimientos")]
        public HttpResponseMessage ObtenerEstablecimientos()
        {
            establecimientoRepository = new EstablecimientoRepository();

            IQueryable<Establecimiento> establecimientos = establecimientoRepository.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, establecimientos);
        }

        [HttpPost]
        [Route("InsertarEstablecimiento")]
        public IHttpActionResult GuardarEstablecimiento([FromBody]Establecimiento _establecimiento)
        {
            establecimientoRepository = new EstablecimientoRepository();

            bool guardar = establecimientoRepository.Insert(_establecimiento);

            if (guardar)
                return Ok();
            else
                return NotFound();
        }
    }
}
