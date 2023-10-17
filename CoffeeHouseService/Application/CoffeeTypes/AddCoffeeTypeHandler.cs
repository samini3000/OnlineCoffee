using Domain.Entities;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CoffeeTypes
{
    public class AddCoffeeTypeHandler : IRequestHandler<AddCoffeeTypeCommand>
    {
        private ICoffeeTypeRepository _coffeeTypeRepository;
        public AddCoffeeTypeHandler(ICoffeeTypeRepository coffeeTypeRepository )
        {
            _coffeeTypeRepository = coffeeTypeRepository;
        }
        public async Task Handle(AddCoffeeTypeCommand request, CancellationToken cancellationToken)
        {
            var type = new CoffeeType()
            {
                Name = request.Name,
                Description = request.Description,
                Pirce = request.Price
            };
            await _coffeeTypeRepository.Add(type);
        }
    }
}
