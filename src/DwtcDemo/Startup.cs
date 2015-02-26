using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using DwtcDemo.Repositories;

namespace DwtcDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBlogRepository, BlogRepository>()
                .AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles().UseMvc();
        }
    }
}
