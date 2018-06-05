using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using coffeeDateAPI.Models;

namespace coffeeDateAPI.Controllers
{
    [Route("api/[controller]")]
    public class CoffeeDataController : ControllerBase
    {
        private readonly CoffeeContext _context;

        public CoffeeDataController(CoffeeContext context)
        {
            _context = context;

            if(_context.coffeeShops.Count() == 0) 
            {
                //_context.coffeeShops.Add(new CoffeeShop {Name = "Lupo"} );
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<CoffeeShop> GetAll()
        {
            return _context.coffeeShops.ToList();
        }

        [HttpPost]
        public IActionResult Create([FromBody] CoffeeShop item)
        {
            if(item == null)
            {
                return BadRequest();
            }

            _context.coffeeShops.Add(item);
            _context.SaveChanges();

            //return CreatedAtRoute("GetCoffeeShop", new CoffeeShop{Id = item.Id});

            return NoContent();
        }
    
    }
}