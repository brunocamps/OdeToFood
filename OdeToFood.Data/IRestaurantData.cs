using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        //start with single operation to return an IEnumerable of Restaurant
        IEnumerable<Restaurant> GetRestaurantsByName(string name); // method to get all restaurants
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant); //returns a restaurant
        int Commit(); //method that returns an int
    }

    public class InMemoryRestaurantData : IRestaurantData //implement IRestaurantData
    { //implement interface shortcut

        //List approach to load restaurants will only work on development mode
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData() //constructor
        {
            restaurants = new List<Restaurant>()
            {
                //Warning: a list is not thread safe. It won't be able to process multiple requests 
                //populate the list with manual data 
                new Restaurant {Id = 1, Name = "Scott's pizza", Location="Maryland", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Cinnamon Club", Location="London", Cuisine = CuisineType.Indian},
                new Restaurant {Id = 3, Name = "Food palace", Location="Virginia", Cuisine = CuisineType.Mexican}
            };

        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);

        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
            if(restaurant != null)
            {
                restaurant.Name = updatedRestaurant.Name;
                restaurant.Location = updatedRestaurant.Location;
                restaurant.Cuisine = updatedRestaurant.Cuisine;
            }
            return restaurant; //return restaurant with the new info inside

        }

        public int Commit() //implement commit at this time
        {
            return 0;
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name  //ascending order
                   select r;
        }
    }
}
