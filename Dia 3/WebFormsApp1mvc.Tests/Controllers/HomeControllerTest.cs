using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebFormsApp1mvc;
using WebFormsApp1mvc.Controllers;

namespace WebFormsApp1mvc.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
