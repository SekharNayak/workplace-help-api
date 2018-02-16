using help.web.api.Infra.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace help.web.api.Controllers
{
    public abstract class HelpApiBaseController<Terror> : ApiController 
        where Terror : HelpApiBaseException
    {

        public IHttpActionResult HelpApiException(Terror data, 
            HelpApiExceptionType excType , HttpStatusCode statusCode = HttpStatusCode.InternalServerError) {
            return new HelpApiExceptionResult<Terror>(data,excType,statusCode);
        }


    }
}