using Application.CoffeeTypes;
using Domain.Entities;
using Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Writers;

namespace CoffeeHouseAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CoffeeTypeController : Controller
    {
        private IMediator _mediator;
        private ICoffeeTypeRepository _coffeeTypeRepository;
        public CoffeeTypeController(ICoffeeTypeRepository coffeeTypeRepository, IMediator mediator)
        {
            _coffeeTypeRepository = coffeeTypeRepository;
            _mediator = mediator;
        }
        [HttpGet("getcoffeetypes")]
        public async Task<IEnumerable<CoffeeType>> GetCoffeeTypes()
        {
            return await _mediator.Send(new GetCoffeeTypesQuery());
        }
        [HttpPost("addcoffeetype")]
        public IActionResult GetCoffeeTypes([FromBody]CoffeeType coffeeType )
        {
            _coffeeTypeRepository.Add(coffeeType);
            return Ok();
        }

    }
}