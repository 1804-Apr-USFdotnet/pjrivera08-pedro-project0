using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary
{
    public class Restaurant
    {
        private string restaurantName;
        private string restaurantAddress;
        private float customerRating;

        private List<Review> storeReviews = new List<Review>();

        public void UpdateRating()
        {
            customerRating = CalculateRating();
        }
        public float CalculateRating()
        {
            int numOfReviews = 0;
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
