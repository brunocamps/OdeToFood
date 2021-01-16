 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants 
{
    public class ListModel : PageModel //This is the page model
    {
        private readonly IConfiguration config; //save the IConfiguration into a private field
        private readonly IRestaurantData restaurantData;

        //page model: responsible for data access
        //public property: the information that the view is going to consume
        //What do we want to display in our view? Our Message and Our list of restaurants
        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData) //razor page now has access
            //to a component that knows how to fetch the restaurants
        {
            this.config = config; //test this one
            this.restaurantData = restaurantData; //test this one
        }
        


        public void OnGet(string searchTerm) //HTTP get request
        {
            
            Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm); // use that particular searchterm
        }
    }
}
