using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using System.Diagnostics;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CoffeeTypeController : Controller
    {
        private readonly ICoffeeTypeRepository;
        public CoffeeTypeController(I)
        {
        }
        [HttpGet("getcoffeetypes")]
        public IActionResult GetCoffeeTypes() { }

    }
}