using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewsLibrary;

namespace RestaurantReviewsTests
{
    [TestClass]
    public class RestaurantInitializationTest
    {
        [TestMethod]
        public void Deserialize_Test()
        {
            //Arrange
            Restaurant expected = new Restaurant
            {
                RestaurantAddress = "14162 Kedzie Circle",
                RestaurantCity = "Warren",
                RestaurantName = "Schinner-Hoppe",
                RestaurantState = "OH",
                RestaurantPhoneNumber = "330-322-1739",
                RestaurantURL = "http://examiner.com"
            };

            string json1 = Serialize.ToJson(expected);

            //Act
            Restaurant actual = Deserialize.FromJson(@"{
              'RestaurantName': 'Schinner-Hoppe',
              'RestaurantAddress': '14162 Kedzie Circle',
              'RestaurantPhoneNumber': '330-322-1739',
              'RestaurantURL': 'http://examiner.com',
              'RestaurantCity': 'Warren',
              'RestaurantState': 'OH'
            }");

            string json2 = Serialize.ToJson(actual);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
