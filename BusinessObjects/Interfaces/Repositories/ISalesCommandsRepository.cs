using System;
using BusinessObjects.Aggregates;
using BusinessObjects.Entities;
using Entities.Interfaces;

namespace BusinessObjects.Interfaces.Repositories
{
    public interface ISalesCommandsRepository : IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
        ValueTask CreatePayment(Payment payment);
    }
}

