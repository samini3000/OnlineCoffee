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
    public class Invoice 
    {
        public int Id { get; set; }
        public int RefNumber { get; set; }
        public int OrderId { get; set; }
        public string Description { get; set; }
    }
    public class InvoiceConfiuration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable(nameof(Invoice));

            builder.HasKey(x => x.Id);

            builder.Property(p => p.RefNumber);

            builder.Property(p => p.OrderId);

            builder.Property(x => x.Description)
                .HasMaxLength(100);
        }
    }
}
