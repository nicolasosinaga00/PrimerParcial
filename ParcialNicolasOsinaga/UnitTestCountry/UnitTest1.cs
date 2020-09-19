using System;
using ApiCountry.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCountry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arrange
            CountriesController countriesController = new CountriesController();
            //Act
            var listapais = countriesController.GetCountries();
            //Assert
            Assert.IsNotNull(listapais);
        }
    }
}
