using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsData;

namespace RestaurantReviewsClient
{
    class Client
    {
        static void Main(string[] args)
        {
            RestaurantCrud crud = new RestaurantCrud();
            var rests = crud.ListRestaurants();

            crud.InsertRestaurant("Schinner-Hoppe", "14162 Kedzie Circle", "Warren", "OH", "330-322-1739", "http://examiner.com");
        }
    }
}
