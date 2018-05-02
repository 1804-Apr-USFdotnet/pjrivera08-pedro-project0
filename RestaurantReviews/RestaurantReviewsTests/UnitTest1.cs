using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviewsLibrary;

namespace RestaurantReviewsTests
{
    [TestClass]
    public class RestaurantInitializationTest
    {
        Restaurant restaurant1 = new Restaurant
        {
            RestaurantAddress = "14162 Kedzie Circle",
            RestaurantCity = "Warren",
            RestaurantName = "Schinner-Hoppe",
            RestaurantState = "OH",
            RestaurantPhoneNumber = "330-322-1739",
            RestaurantURL = "http://examiner.com"
        };

        Restaurant restaurant2 = new Restaurant
        {
            RestaurantAddress = "123 Name Circle",
            RestaurantCity = "Boston",
            RestaurantName = "McDonald's",
            RestaurantState = "MA",
            RestaurantPhoneNumber = "123-456-7891",
            RestaurantURL = "http://website.com"
        };

        Restaurant restaurant3 = new Restaurant
        {
            RestaurantAddress = "12 Something Road",
            RestaurantCity = "Tampa",
            RestaurantName = "Joe's Burgers",
            RestaurantState = "FL",
            RestaurantPhoneNumber = "987-456-1234",
            RestaurantURL = "http://joesburgers.com"
        };

        Restaurant restaurant4 = new Restaurant
        {
            RestaurantAddress = "4th street",
            RestaurantCity = "New York",
            RestaurantName = "4th Street Diner",
            RestaurantState = "NY",
            RestaurantPhoneNumber = "123-123-1234",
            RestaurantURL = "http://4thstreet.com"
        };

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

            //Act
            Restaurant actual = Deserialize.FromJson(@"{
              'RestaurantName': 'Schinner-Hoppe',
              'RestaurantAddress': '14162 Kedzie Circle',
              'RestaurantPhoneNumber': '330-322-1739',
              'RestaurantURL': 'http://examiner.com',
              'RestaurantCity': 'Warren',
              'RestaurantState': 'OH'
            }");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    //[TestClass]
    //public class UserInteractorTest
    //{
    //    UserInteractor testUser = new UserInteractor();
    //    [TestMethod]
    //    public void SelectOption_Test()
    //    {
    //        int expected = 1;

    //        int actual = testUser.SelectOption();

    //        Assert.Equals(expected, actual);
    //    }
    //}
}
