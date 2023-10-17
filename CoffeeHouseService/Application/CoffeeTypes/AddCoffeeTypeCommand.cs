using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CoffeeTypes
{
    public class AddCoffeeTypeCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public AddCoffeeTypeCommand(string name, string descrption, int price)
        {
            Name = name;
            Description = descrption;
            Price = price; 
        }
    }

}
