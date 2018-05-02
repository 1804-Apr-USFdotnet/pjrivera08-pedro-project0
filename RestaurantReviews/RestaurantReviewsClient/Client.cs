using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsLibrary;

namespace RestaurantReviewsClient
{
    class Client
    {
        static void Main(string[] args)
        {
            UserInteractor user = new UserInteractor();
            while (!user.OptionHandler())
            {
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
