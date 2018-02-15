using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;

namespace help.web.api.Infra
{

    /// <summary>
    /// This is to provide versioning with accept header parameter.
    /// Anyways route versioning is already provided.
    /// </summary>
    public class HelpApiHttpControllerSelector : DefaultHttpControllerSelector
    {
        private const string _version = "version";
        private const string _currentVersion = "V1";
        public HelpApiHttpControllerSelector(HttpConfiguration config)
            :base(config)
        {
            
        }

        public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
        {
             
            var parameter = request.Headers.Accept?.FirstOrDefault()?.Parameters?.Where(value => string.Equals(value.Name,_version,StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            var controllerNameRequired = GetControllerName(request.GetRouteData());
            var controllers = GetControllerMapping();
            if (parameter != null)
            {
                string version = parameter.Value;
                var descriptor = controllers.Where(desc => desc.Key == string.Concat(controllerNameRequired, version)).FirstOrDefault().Value;
                if(descriptor != null)
                return descriptor;
            }
           
            return base.SelectController(request);
        }

        private string GetControllerName(IHttpRouteData routeData)
        {
            var subroute = routeData.GetSubRoutes().FirstOrDefault();
            if (subroute == null) return null;
            //((HttpActionDescriptor[])subroute.Route.DataTokens["actions"]).First()
            var dataTokenValue = subroute.Route.DataTokens["actions"];

            if (dataTokenValue == null)
                return null;

            var controllerName = ((HttpActionDescriptor[])dataTokenValue).First().ControllerDescriptor.ControllerName.Replace("Controller", string.Empty);

            return controllerName;
        }
    }
}