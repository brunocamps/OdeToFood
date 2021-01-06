using System;
namespace OdeToFood.Core
{

    public class Restaurants
    {
        //Definition of the Data we will work with
        //including CuisineType which is a public enum
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
