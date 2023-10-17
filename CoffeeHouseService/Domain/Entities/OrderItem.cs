using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderItem 
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int Price { get; set; }
        public int OrderId { get; set; }
    }
}
