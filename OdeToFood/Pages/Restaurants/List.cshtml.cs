 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants 
{
    public class ListModel : PageModel //This is the page model
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        //page model: responsible for data access
        public string Message { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData) //razor page now has access
            //to a component that knows how to fetch the restaurants
        {
            this.config = config; //test this one
            this.restaurantData = restaurantData; //test this one
        }
        


        public void OnGet() //HTTP get request
        {
            Message = config["Message"];
        }
    }
}
