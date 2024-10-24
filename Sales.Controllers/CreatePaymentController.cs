using System;
using BusinessObjects.DTOs;
using BusinessObjects.Interfaces.Controllers;
using BusinessObjects.Interfaces.Ports;
using BusinessObjects.Interfaces.Presenters;

namespace Sales.Controllers
{
    public class CreateOrderController : ICreateOrderController
    {
        readonly ICreateOrderInputPort InputPort;
        readonly ICreateOrderPresenter Presenter;
        public CreateOrderController(ICreateOrderInputPort inputPort,
            ICreateOrderPresenter presenter) =>
            (InputPort, Presenter) = (inputPort, presenter);

        public async ValueTask<int> CreateOrder(CreateOrderDTO order)
        {
            await InputPort.Handle(order);
            return Presenter.OrderId;
        }
    }
}

