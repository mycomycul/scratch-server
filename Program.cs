using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }
    }
    public class Startup
    {
        /// <summary>
        /// This method processes each request by sending it through each middlware called with
        /// app.Run, app.Use, app.Map and extension methods like app.UseMvc() provided by packages
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
            //This will be executed and await next() will call the following middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Pre Processing. ");
                //next() calls the next middleware and returns when it exits like a stack
                await next();
                await context.Response.WriteAsync("Post Processing. ");

            });
            //This is executed after calling next() in the previous middleware
            //Any other middleware will not be executed after app.Run() because it does not have a next() method
            //App.Use will also replicate App.Run if next is not called but App.Run is used by convention.
            app.Run(async (context) =>
            {

                await context.Response.WriteAsync(
                    $"Hello World. The Time is: {DateTime.Now.ToString("hh:mm:ss tt")}. ");

            });
            //This will not be run because it follows app.Run()
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("This will not execute.");

            });
        }
    }
}
