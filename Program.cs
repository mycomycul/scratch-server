using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

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
        /// Initializes dependency injection services. Called by web host after instantiating Startup
        /// services initialized can be used anywhere else in the project
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //Provides the necessary dependency injection
            services.AddMvc();
        }
        /// <summary>
        /// Handles every web request passing them through each middleware
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
            //Process webrequests using ht MVC service
            app.UseMvc();
        }
    }


}
