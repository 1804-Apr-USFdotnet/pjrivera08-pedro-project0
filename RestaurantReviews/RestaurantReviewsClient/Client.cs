using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsData;
using RestaurantReviewsLibrary;

namespace RestaurantReviewsClient
{
    class Client
    {
        static void Main(string[] args)
        {
            UserInteractor user = new RestaurantReviewsLibrary.UserInteractor();
            while (user.OptionHandler())
            {

            }

            Console.WriteLine("Broke out of the loop!");
            Console.ReadKey();
        }
    }
}
