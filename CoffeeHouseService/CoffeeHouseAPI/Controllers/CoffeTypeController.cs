using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeHouseAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CoffeeTypeController : Controller
    {
        private ICoffeeTypeRepository _coffeeTypeRepository;
        public CoffeeTypeController(ICoffeeTypeRepository coffeeTypeRepository)
        {
            _coffeeTypeRepository = coffeeTypeRepository;
        }
        [HttpGet("getcoffeetypes")]
        public IActionResult GetCoffeeTypes()
        {
            return Ok(_coffeeTypeRepository.GetAll());
        }
        [HttpPost("addcoffeetype")]
        public IActionResult GetCoffeeTypes([FromBody]CoffeeType coffeeType )
        {
            _coffeeTypeRepository.Add(coffeeType);
            return Ok();
        }

    }
}