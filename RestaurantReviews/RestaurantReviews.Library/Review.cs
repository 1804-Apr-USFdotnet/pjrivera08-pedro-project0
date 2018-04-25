using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsLibrary
{
    class Review
    {
        Review()
        {
            reviewerName = "";   
            reviewText = "Dummy Text";
            reviewScore = 0;
        }
        private string reviewerName;
        private string reviewText;
        private float reviewScore;

        public void UpdateName(string _name)
        {
            reviewerName = _name;
        }
        public void UpdateScore(float _value)
        {
            reviewScore = _value;
        }
        public float GetReviewScore()
        {
            return reviewScore;
        }
    }
}
