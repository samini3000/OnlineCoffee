using Domain.Entities;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.CoffeeTypes
{
    public class GetCoffeeTypesHandler : IRequestHandler<GetCoffeeTypesQuery, IEnumerable<CoffeeType>>
    {
        private readonly ICoffeeTypeRepository _coffeeTypeRepository;
        public GetCoffeeTypesHandler(ICoffeeTypeRepository coffeeTypeRepository)
        {
            _coffeeTypeRepository = coffeeTypeRepository;
        }
        public async  Task<IEnumerable<CoffeeType>> Handle(GetCoffeeTypesQuery request, CancellationToken cancellationToken)
        {
            return await _coffeeTypeRepository.GetAll();
        }
    }
}
