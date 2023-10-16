using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructure.DataAccess.Entities
{
    public class Order 
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
    }
    public class OrderConfiguartion : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AccountId)
                .IsRequired();
        }
    }
}
