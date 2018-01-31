
using help.api.services.IssueTracking;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Registration;
using Unity.WebApi;

namespace help.web.api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            //register services 
            container.RegisterType<IIssueService, IssueService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}