using Microsoft.Owin.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace help.web.api.Infra.Filter
{
    /// <summary>
    /// To measure performace for critcal action methods .
    /// It does not interupt the pipeline 
    /// </summary>
    public class PerformanceFilter : Attribute, IActionFilter
    {

        
        public bool AllowMultiple
        {
            get
            {
                return false;
            }
        }

        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, 
            CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            //actionContext.
            
            throw new NotImplementedException();
        }
    }
}