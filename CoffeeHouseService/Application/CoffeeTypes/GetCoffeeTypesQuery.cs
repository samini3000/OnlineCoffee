using MediatR;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CoffeeTypes
{
    public class GetCoffeeTypesQuery :IRequest<IEnumerable<CoffeeType>>
    {
    }
}
