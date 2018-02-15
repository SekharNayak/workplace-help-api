using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace help.web.api.Controllers
{
    [RoutePrefix("api/test")]
    public class TestV2Controller : ApiController
    {
        [Route("")]
        public IHttpActionResult Get()
        {

            return Ok("from version 2");
        }
    }
}
