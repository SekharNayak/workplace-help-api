using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(help.web.api.Startup))]

namespace help.web.api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // app.Run( context => context.Response.WriteAsync("kukura gandi"));

           
        }
    }
}
