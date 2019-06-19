using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Supermarket.API.Controllers.Config;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;
using Supermarket.API.Persistence.Contexts;
using Supermarket.API.Persistence.Repositories;
using Supermarket.API.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace Supermarket.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();

            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new Info
                {
                    Title = "Supermarket API",
                        Version = "v1.1",
                        Description = "Simple RESTful API built with ASP.NET Core 2.2 to show how to create RESTful services using a decoupled, maintainable architecture.",
                        Contact = new Contact
                        {
                            Name = "Evandro Gayer Gomes",
                                Url = "https://github.com/evgomes",
                        },
                        License = new License
                        {
                            Name = "MIT",
                        },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                cfg.IncludeXmlComments(xmlPath);
            });

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .ConfigureApiBehaviorOptions(options =>
                {
                    // Adds a custom error response factory when ModelState is invalid
                    options.InvalidModelStateResponseFactory = InvalidModelStateResponseFactory.ProduceErrorResponse;
                });

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("supermarket-api-in-memory");
            });

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Supermarket API");
            });

            app.UseMvc();
        }
    }
}