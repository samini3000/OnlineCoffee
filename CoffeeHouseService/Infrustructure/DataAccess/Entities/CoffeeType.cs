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
    public class CoffeeType 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Pirce { get; set; }
    }
    public class CoffeeTypeConfiguration : IEntityTypeConfiguration<CoffeeType>
    {
        public void Configure(EntityTypeBuilder<CoffeeType> builder)
        {
            builder.ToTable(nameof(CoffeeType));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(50);

            builder.Property(x => x.Pirce);
        }
    }
}
