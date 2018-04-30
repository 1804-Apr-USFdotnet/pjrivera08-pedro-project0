using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsData;

namespace RestaurantReviewsLibrary
{
    public class UserInteractor
    {
        RestaurantCrud crud = new RestaurantCrud();
        public int SelectOption()
        {
            int decision=0;
            while((decision < 1) || (decision > 6))
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Display 3 top rated restaurants");
                Console.WriteLine("2. Display all Restaurants, sorted by name");
                Console.WriteLine("3. Display Restaurant details");
                Console.WriteLine("4. Display all Reviews of Restaurant");
                Console.WriteLine("5. Search for Restaurant by name");
                Console.WriteLine("6. Quit");
                decision = int.Parse(Console.ReadLine());
                if ((decision < 1) || (decision > 6))
                    Console.WriteLine("Please choose a value between 1-6.");
            }
            
            return decision;
        }
        public bool OptionHandler()
        {
            int specificId;
            int selection;
            ICollection<Restaurant> list;
            string name;
            Restaurant currentRestaurant;

            selection = SelectOption();
            if(selection == 1)
            {
                list = LibHelper.DataToLibraryList(crud.SortByRating(3));
                foreach(Restaurant rest in list)
                {
                    Console.WriteLine(rest.RestaurantName + ": " + rest.CustomerRating);

                }
                return false;
            }
            return false;
        }
    }
}
