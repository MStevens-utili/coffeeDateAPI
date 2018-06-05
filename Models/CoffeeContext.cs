using Microsoft.EntityFrameworkCore;

namespace coffeeDateAPI.Models
{
    public class CoffeeContext : DbContext
    {
        public CoffeeContext(DbContextOptions<CoffeeContext> options) : base(options)
        {
        }

        public DbSet<CoffeeShop> coffeeShops {get; set;}
    }
}