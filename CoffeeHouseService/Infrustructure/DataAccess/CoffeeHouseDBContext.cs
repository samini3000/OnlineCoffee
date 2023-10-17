using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrustructure.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrustructure.DataAccess
{
    public class CoffeeHouseDBContext : DbContext
    {
        public DbSet<CoffeeType> CoffeeTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Agent> Agents { get; set; }

        public CoffeeHouseDBContext(DbContextOptions options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CoffeeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiuration());
            modelBuilder.ApplyConfiguration(new OrderConfiguartion());
            modelBuilder.ApplyConfiguration(new OrderConfiguartion());
            modelBuilder.ApplyConfiguration(new AgentConfiguration());
        }

    }
    public class DBContextCoffeeFactory : IDesignTimeDbContextFactory<CoffeeHouseDBContext>
    {
        public CoffeeHouseDBContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<CoffeeHouseDBContext>();
            optionBuilder.UseSqlServer(@"Data Source=SAEEDEH-LEGION;Integrated Security=True;;Initial Catalog=CoffeeHouse;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");

            return new CoffeeHouseDBContext(optionBuilder.Options);
        }
    }
}