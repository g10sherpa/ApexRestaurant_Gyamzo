using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;


namespace ApexRestaurant.Api.Controller {
    [Route ("/")]
    public class HomeController : ControllerBase {
        [HttpGet]
        [Route ("/")]
        public IActionResult Index () {
            // get base_uri, e.g. https://localhost:5001
            var base_uri = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

            // available api endpoints list
            var endpoints = new List<string>{"customer", "menu", "menuitem", "meal", "mealdish", "staff", "staffrole"};

            // taag (text to ascii art generator)
            

            
            var api_text = "";
            foreach (var endpoint in endpoints)
            {
                api_text += Environment.NewLine + $"{base_uri}/api/{endpoint}";
            }

            
            return Ok (api_text);
        }
    }
}