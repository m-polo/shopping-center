using BusinessObjects.Aggregates;
using BusinessObjects.DTOs;
using BusinessObjects.Interfaces.Ports;
using BusinessObjects.Interfaces.Repositories;

namespace Sales.UseCases.CreateOrder;

public class CreateOrderInteractor : ICreateOrderInputPort
{
    readonly ICreateOrderOutputPort OutputPort;
    readonly ISalesCommandsRepository Repository;

    public CreateOrderInteractor(ICreateOrderOutputPort outputPort,
        ISalesCommandsRepository repository)
    {
        OutputPort = outputPort;
        Repository = repository;
    }

    public async ValueTask Handle(CreateOrderDTO orderDto)
    {
        OrderAggregate OrderAggregate = new OrderAggregate
        {
            CustomerId = orderDto.CustomerId,
            ShipAddress = orderDto.ShipAddress,
            ShipCity = orderDto.ShipCity,
            ShipCountry = orderDto.ShipCountry,
            ShipPostalCode = orderDto.ShipPostalCode
        };

        foreach (var Item in orderDto.OrderDetails)
        {
            OrderAggregate.AddDetail(Item.ProductId,
                Item.UnitPrice, Item.Quantity);
        }

        await Repository.CreateOrder(OrderAggregate);
        await Repository.SaveChanges();
        await OutputPort.Handle(OrderAggregate.Id);
    }
}

