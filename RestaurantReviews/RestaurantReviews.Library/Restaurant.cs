using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Library
{
    class Restaurant
    {
        public Restaurant(string _name, string _address)
        {
            restaurantName = _name;
            restaurantAddress = _address;
        }
        private string restaurantName;
        private string restaurantAddress;
        private float customerRating;

        private void setCustomerRating()
        {
            customerRating = 1; //PLACEHOLDER VALUE
            return;
        }
    }
}
