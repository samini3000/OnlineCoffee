using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.DataAccess.Entities
{
    public class OrderItem 
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int Price { get; set; }
        public int OrderId { get; set; }
    }
    public class OrderItemProperty : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable(nameof(OrderItem));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AccountId)
                .IsRequired();

            builder.Property(x => x.Price);

            builder.Property(x => x.OrderId)
                .IsRequired();
        }
    }
}
