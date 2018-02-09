using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SiteCoreApp.Controllers;
using System.Web.Mvc;

namespace SiteCoreAppTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexActionReturnView()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
