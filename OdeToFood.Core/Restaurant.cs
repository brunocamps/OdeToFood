using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public class Restaurant //public class - can be accessed in the entire application
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(255)] //0 - 255
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
