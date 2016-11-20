using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterApp;
using BabySitterApp.Controllers;

namespace BabySitterApp.Tests.Controllers
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
        }

        [TestMethod]
        public void StartsNoEarlierThan5PM()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            bool result = controller.CheckTimeNotEarlierThan5PM();


            //Assert
            Assert.AreEqual(true, result);

        }

    
    }
}
