using System;
using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll(); // method to get all restaurants
    }

    public class InMemoryRestaurantData : IRestaurantData //implement IRestaurantData
    { //implement interface shortcut

        //List approach to load restaurants will only work on development mode
        List<Restaurant> restaurants; 
        public InMemoryRestaurantData() //constructor
        {
            restaurants = new List<Restaurant>()
            {
                //Warning: a list is not thread safe. It won't be able to process multiple requests.
                //populate the list with manual data 
                new Restaurant {Id = 1, Name = "Scott's pizza", Location="Maryland", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Cinnamon Club", Location="London", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 3, Name = "Food palace", Location="Virginia", Cuisine = CuisineType.Mexican}
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name  
                   select r;
        }
    }
}
