using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice : Entity
    {
        public int Id { get; set; }
        public int RefNumber { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }
    }
}
