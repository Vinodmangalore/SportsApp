using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsWeb;
using SportsWeb.Controllers;
using Microsoft.AdventureWorks.Business.Manager;
using Moq;
using Microsoft.AdventureWorks.Data.Data;

namespace SportsWeb.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private IAddressManager addressManager;

        [TestInitialize]
        public void Initialize()
        {
            Mock<IAddressManager> mock = new Mock<IAddressManager>();
            mock.Setup(m => m.GetAll()).Returns(new[] {
                new Address { AddressID = 1, AddressLine1 = "Bangalore", AddressLine2 = "HRBR Layout" },
                new Address { AddressID = 2, AddressLine1 = "Mangalore", AddressLine2 = "Statebank" }
            }.AsQueryable());

            this.addressManager = mock.Object;
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(addressManager);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            var model = addressManager.GetAll().ToList().Count();
            var viewModel = result.Model;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            //HomeController controller = new HomeController();

            //// Act
            //ViewResult result = controller.About() as ViewResult;

            //// Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            //// Arrange
            //HomeController controller = new HomeController();

            //// Act
            //ViewResult result = controller.Contact() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
        }
    }
}
