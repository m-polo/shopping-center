using System;
using BusinessObjects.DTOs;
using BusinessObjects.Interfaces.Controllers;
using BusinessObjects.Interfaces.Ports;
using BusinessObjects.Interfaces.Presenters;

namespace Sales.Controllers
{
    public class CreatePaymentController : ICreatePaymentController
    {
        readonly ICreatePaymentInputPort InputPort;
        readonly ICreatePaymentPresenter Presenter;
        public CreatePaymentController(ICreatePaymentInputPort inputPort,
            ICreatePaymentPresenter presenter) =>
            (InputPort, Presenter) = (inputPort, presenter);

        public async ValueTask<int> CreatePayment(CreatePaymentDTO payment)
        {
            await InputPort.Handle(payment);
            return Presenter.PaymentId;
        }
    }
}

