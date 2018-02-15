﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using help.web.api;
using help.web.api.Controllers;
using help.web.api.Controllers.V1;

namespace help.web.api.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
