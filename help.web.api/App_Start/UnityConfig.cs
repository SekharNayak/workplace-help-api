
using help.api.repositories;
using help.api.services.IssueTracking;
using help.api.services.Status;
using help.db;
using System.Data.Entity;
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
            container.RegisterType<DbContext, HelpDeskContext>();
            container.RegisterType<IIssueRepository, IssueRepository>();
            container.RegisterType<IIssueService, IssueService>();
            container.RegisterType<IStatusRepository, StatusRepository>();
            container.RegisterType<IStatusService, StatusService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}