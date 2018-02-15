
using help.api.repositories;
using help.api.services.IssueTracking;
using help.api.services.Status;
using help.api.services.Team;
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

            //Issue 
            container.RegisterType<IIssueRepository, IssueRepository>();
            container.RegisterType<IIssueService, IssueService>();

            //status 
            container.RegisterType<IStatusRepository, StatusRepository>();
            container.RegisterType<IStatusService, StatusService>();

            //team 
            container.RegisterType<ITeamRepository, TeamRepository>();
            container.RegisterType<ITeamService, TeamService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}