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

        private List<Review> storeReviews = new List<Review>();

        public void updateRating()
        {
            customerRating = CalculateRating();
        }

        public float CalculateRating()
        {
            int numOfReviews = 0 ;
            float scoreSum = 0.0f;
            foreach (Review item in storeReviews)
            {
                scoreSum += item.GetReviewScore();
                numOfReviews++;
            }
            return scoreSum / numOfReviews;
        }

        public void AddReview(Review indx)
        {
            storeReviews.Add(indx);
        }
        
    }
}
