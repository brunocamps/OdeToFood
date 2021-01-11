using System;
using System.Collections.Generic;
namespace OdeToFood.Core
{
    public class Restaurant //public class - can be accessed in the entire application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
