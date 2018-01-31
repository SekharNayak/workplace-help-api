using help.api.models;
using help.api.services.IssueTracking;
using help.web.api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace help.web.api.Tests.Controllers
{
    [TestClass]
    public class IssueControllerTest
    {

        private Moq.Mock<IIssueService> issueService;
        private IssueController controller;
        [TestInitialize]
        public void Initialize() {
        
            issueService = new Moq.Mock<IIssueService>();
            controller = new IssueController(issueService.Object);
        }

        [TestMethod]
        public void GetIssues() {
           
            issueService.Setup(service => service.GetAllIssuesAsync()).
                Returns(Task.FromResult<IEnumerable<Issue>>(new List<Issue>()));
            var allissues = controller.GetIssues();
            Assert.IsNotNull(allissues);                   
        }

        [TestCleanup]
        public void CleanUp() {
            issueService = null;
            controller.Dispose();
        }
    }
}
