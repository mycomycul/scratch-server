using System;
using Microsoft.AspNetCore.Mvc;

namespace scratch.Controllers
{
    public class HelloWorldController
    {
        /// <summary>
        /// simple api response accessed through targeting from the MVC middleware
        /// </summary>
        /// <returns>Object demonstrating response</returns>
        [HttpGet("api/helloworld")]
        public object HelloWorld(){
            return new{
                message = "Hello World",
                time = DateTime.Now
            };
        }
    }
}