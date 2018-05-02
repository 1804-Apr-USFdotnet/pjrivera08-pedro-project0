using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsData;

namespace RestaurantReviewsLibrary
{
    public class SortLogic
    {
        RestaurantCrud crud = new RestaurantCrud();
        
        public ICollection<Restaurant> SortByRating(int listAmount)
        {
            List<Restaurant> tempList = (List<Restaurant>)LibHelper.DataListToLibraryList(crud.ListRestaurants());
            tempList.OrderByDescending(rating => rating.CustomerRating).Take(listAmount).ToList();
            return tempList;
        }
        public ICollection<Restaurant> SortByRating()
        {
            List<Restaurant> tempList = (List<Restaurant>)LibHelper.DataListToLibraryList(crud.ListRestaurants());
            tempList.OrderByDescending(rating => rating.CustomerRating).ToList();
            return tempList;
        }
        public ICollection<Restaurant> SortByNameDescending()
        {
            List<Restaurant> tempList = (List<Restaurant>)LibHelper.DataListToLibraryList(crud.ListRestaurants());
            tempList.OrderByDescending(name => name.RestaurantName).ToList();
            return tempList;
        }
        public ICollection<Restaurant> SearchRestaurantByName(string str)
        {
            List<Restaurant> tempList = (List<Restaurant>)LibHelper.DataListToLibraryList(crud.ListRestaurants());
            tempList.OrderByDescending(name => name.RestaurantName.Contains(str)).ToList();
            return tempList;
        }
    }
}
