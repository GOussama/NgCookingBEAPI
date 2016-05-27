﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NgcookingBackend.Models;
using Microsoft.Data.Entity;
using Newtonsoft.Json.Serialization;

namespace NgcookingBackend.V._0
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();

            Configuration = builder.Build(); 
        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
             //Add framework services.
            //Adding dependency injection         
            services.AddSingleton<ICommunautesRepository, CommunautesRepository>();
            services.AddSingleton<IRecetteRepository, RecetteRepository>();

            services.AddEntityFramework().AddSqlServer().AddDbContext<ModelContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:ConnectionString"]);
            });

            //services.AddMvc();
            //Add CamelCase to Json Property
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();
            app.UseStaticFiles();

            app.UseMvc();
            SampleData.Initialize(app.ApplicationServices);

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
                context.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "Content-Type, x-xsrf-token" });

                if (context.Request.Method == "OPTIONS")
                {
                    context.Response.StatusCode = 200;
                }
                else
                {
                    await next();
                }
            });



        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
