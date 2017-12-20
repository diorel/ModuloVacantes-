using SAGA.DAL;
using SAGA.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Vacantes.API.Controllers
{
    [RoutePrefix("api/Vacantes")]
    public class VacanteController : ApiController
    {
        private SAGADBContext _db;

        public VacanteController()
        {
            _db = new SAGADBContext();
        }

        [ResponseType(typeof(DAMFO_290))]
        [HttpGet]
        [Route("Get")]
        public IHttpActionResult Get()
        {   
            return Ok();
        }
    }
}
