using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace help.web.api.Infra.Error
{
    public abstract class HelpApiBaseException : System.Exception
    {
        private HelpApiExceptionType excType;

    }
}