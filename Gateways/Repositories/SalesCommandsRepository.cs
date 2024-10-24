using System;
using BusinessObjects.Aggregates;
using BusinessObjects.Entities;
using BusinessObjects.Interfaces.Repositories;
using EFCore.Repositories.DataContexts;
using EFCore.Repositories.Entities;

namespace EFCore.Repositories.Repositories
{
    public class SalesCommandsRepository :
        ISalesCommandsRepository
    {
        readonly SalesContext Context;
        public SalesCommandsRepository(
            SalesContext context) =>
            Context = context;

        public async ValueTask CreateOrder(OrderAggregate order)
        {
            await Context.AddAsync(order);
            foreach (var Item in order.OrderDetails)
            {
                await Context.AddAsync(new OrderDetail
                {
                    Order = order,
                    ProductId = Item.ProductId,
                    Quantity = Item.Quantity,
                    UnitPrice = Item.UnitPrice
                });
            }
        }

        public async ValueTask CreatePayment(Payment payment)
        {
            await Context.AddAsync(payment);
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}

