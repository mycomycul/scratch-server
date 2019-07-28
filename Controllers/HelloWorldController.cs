using System;
using Microsoft.AspNetCore.Mvc;

namespace scratch.Controllers
{
    /// Core Mvc Provides both Mvc and API endpoints in the same controller
    ///To use viewbags, views and other mvc controller functionality the controller must inherit from the abse controller class
    public class HelloWorldController:Controller
    {
        /// <summary>
        /// simple api response accessed through targeting from the MVC middleware
        /// <para>does not require the controller base class</para>
        /// </summary>
        /// <returns>Object demonstrating response</returns>
        [HttpGet("api/helloworld")]
        public object HelloWorld(){
            return new{
                message = "Hello World",
                time = DateTime.Now
            };
        }

        
        /// <summary>
        /// Mvc Endpoint. Controller class provides support for Viewbags, Models etc.
        /// </summary>
        /// <returns></returns>
        [HttpGet("helloworld")]
        public ActionResult HellowWorldMvc(){
            ViewBag.Message = "Hello world!";
            ViewBag.Time = DateTime.Now;

            //return View("~/helloworld.cshtml"). MVC uses convetions for targeting views etc.
            return View("helloworld");
        }
    }
}