using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using coffeeDateAPI.Models;

namespace coffeeDateAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CoffeeContext> (opt => opt.UseInMemoryDatabase("CoffeeList"));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app) {
            app.UseMvc();
        }
    }
}