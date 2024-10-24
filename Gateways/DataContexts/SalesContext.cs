using System;
using BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using EFCore.Repositories.Entities;

namespace EFCore.Repositories.DataContexts
{
    public class SalesContext : DbContext
    {
        public SalesContext(
            DbContextOptions<SalesContext> options)
            : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}

