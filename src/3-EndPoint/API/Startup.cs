using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.AppServices.Book.Book;
using Domain.Core.Book.Book.AppServices;
using Domain.Core.Book.Book.Data.Repositories;
using Domain.Core.Book.Book.DomainServices;
using Domain.Core.Providers.Cache.Service;
using Domain.Services.Book.Book;
using Infra.Cache.DistributedCache.Implementation;
using Infra.Data.Repos.Book.Book;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddMvcCore();
            services.AddHttpClient();

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration["RedisConnectionString:Development"];
                options.InstanceName = "BooksCaching";
            });
            services.AddDistributedMemoryCache();
            services.AddMemoryCache(options =>
            {
                options.SizeLimit = 1024;
            });
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            services.AddScoped<MemoryCacheEntryOptions>();
            services.AddScoped<DistributedCacheEntryOptions>();
            services.AddTransient<ICache,RedisCache>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IBookAppService, BookAppService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
