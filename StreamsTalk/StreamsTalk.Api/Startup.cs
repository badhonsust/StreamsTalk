using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using StreamsTalk.Domain.Enums;
using StreamsTalk.Infra.Data.Context;
using StreamsTalk.Infra.IoC;
using System;

namespace StreamsTalk.Api
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
            services.AddDbContext<StreamsTalkDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString(Enum.GetName(typeof(DbConnection), DbConnection.StreamsTalkDbConnection))));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "StreamsTalk: The Clean Architecture Framework",
                    Version = "v1",
                    Description = "This API Project is made with the clean architecture framework, as a part of the presentation of StreamsTalk",
                    Contact = new OpenApiContact
                    {
                        Name = "AshfaQ",                        
                        Email = "md.ashfaquzzaman@streamstech.com"
                    }
                });
            });

            RegisterServices(services);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StreamsTalk.TCAF v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}
