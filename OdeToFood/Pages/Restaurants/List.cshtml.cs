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

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        


        public void OnGet() //HTTP get request
        {
            Message = config["Message"];
        }
    }
}
