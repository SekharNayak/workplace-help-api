using help.api.models;
using help.api.services.IssueTracking;
using help.web.api.Controllers;
using help.web.api.Controllers.V1;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace help.web.api.Tests.Controllers
{
    [TestFixture]
    public class IssueControllerTest
    {

        private Moq.Mock<IIssueService> issueService;
        private IssueController controller;


        [SetUp]
        public void Initialize() {
        
            issueService = new Moq.Mock<IIssueService>();
            controller = new IssueController(issueService.Object);
        }

        [Test]
        public void GetIssues() {
           
            issueService.Setup(service => service.GetAllIssuesAsync()).
                Returns(Task.FromResult<IEnumerable<Issue>>(new List<Issue>()));
            var allissues = controller.GetIssues();
            Assert.IsNotNull(allissues);                   
        }

        [TearDown]
        public void CleanUp() {
            issueService = null;
            controller.Dispose();
        }
    }
}
