using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace help.web.api.Infra.Error
{
    /// <summary>
    /// Custom implementation of exception logging.
    /// </summary>
    public class HelpApiExceptionLogger : IExceptionLogger
    {
        public Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {

            //use ur custome logic to log exceptions 
            //can work globally 
            //replace the service in config.
            throw new NotImplementedException();
        }
    }
}