using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsData
{
    public class RestaurantCrud
    {
        RestaurantDBEntities db = new RestaurantDBEntities();
        public enum ColumnChoice { restaurantName, restaurantAddress, restaurantCity, restaurantState, restaurantPhoneNumber, restaurantURL, customerRating };

        //Create
        public void InsertRestaurant(string _restaurantName, string _restaurantAddress, string _restaurantCity, string _restaurantState, string _restaurantPhoneNumber, string _restaurantURL)
        {
            Restaurant newRest = new Restaurant();
            newRest.restaurantName = _restaurantName;
            newRest.restaurantAddress = _restaurantAddress;
            newRest.restaurantCity = _restaurantCity;
            newRest.restaurantState = _restaurantState;
            newRest.restaurantPhoneNumber = _restaurantPhoneNumber;
            newRest.restaurantURL = _restaurantURL;
            newRest.customerRating = null;

            db.Restaurants.Add(newRest);
            db.SaveChanges();
        }
        //Read Supplement
        public IEnumerable<Restaurant> ListRestaurants()
        {
            return db.Restaurants.ToList();
            
        }
        //Read 
        public void ReadRestaurants()
        {
            var rests = ListRestaurants();
            foreach(var rest in rests)
            {
                Console.WriteLine(rest.ID + "|| " + rest.restaurantName + "|| " + rest.restaurantAddress + "|| " + rest.restaurantCity + ", " + rest.restaurantState + "|| " + rest.restaurantPhoneNumber + "|| " + rest.restaurantURL + "|| Rating: " + rest.customerRating);
            }
        }
        //Search Restaurant by id (Update Supplement)
        public Restaurant getRestaurantById(int idNumber)
        {
            Restaurant temp = db.Restaurants.Find(idNumber);
            return temp;
        }
        //Update
        public void UpdateCustomer(int id, ColumnChoice choiceName, string replacement)
        {
            int choice = (int)choiceName;
            Restaurant rest = getRestaurantById(id);
            if (choice.Equals(0))
            {
                rest.restaurantName = replacement;
            }
            if (choice.Equals(1))
            {
                rest.restaurantAddress = replacement;
            }
            if (choice.Equals(2))
            {
                rest.restaurantCity = replacement;
            }
            if (choice.Equals(3))
            {
                rest.restaurantState = replacement;
            }
            if (choice.Equals(4))
            {
                rest.restaurantPhoneNumber = replacement;
            }
            if (choice.Equals(5))
            {
                rest.restaurantURL = replacement;
            }
            if (choice.Equals(6))
            {
                rest.customerRating = float.Parse(replacement);
            }
            db.SaveChanges();
        }
        //Delete
        public void DeleteRestaurant(int id)
        {
            Restaurant rest = getRestaurantById(id);
            db.Restaurants.Remove(rest);
            db.SaveChanges();
        }
    }
}
