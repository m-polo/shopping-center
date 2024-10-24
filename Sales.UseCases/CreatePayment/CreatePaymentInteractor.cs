using System;
using BusinessObjects.DTOs;
using BusinessObjects.Entities;
using BusinessObjects.Interfaces.Ports;
using BusinessObjects.Interfaces.Repositories;

namespace Sales.UseCases.CreatePayment
{
	public class CreatePaymentInteractor: ICreatePaymentInputPort
	{
		private ICreatePaymentOutputPort OutputPort;
        private ISalesCommandsRepository Repository;

        public CreatePaymentInteractor(ICreatePaymentOutputPort outputPort, ISalesCommandsRepository repository)
		{
            OutputPort = outputPort;
            Repository = repository;
        }

        public async ValueTask Handle(CreatePaymentDTO paymentDto)
        {
            Payment payment = new()
            {
                Currency = paymentDto.Currency,
                Amount = paymentDto.Amount,
                OrderId = paymentDto.OrderId,
                Status = paymentDto.Status,
            };

            await Repository.CreatePayment(payment);
            await Repository.SaveChanges();
            await OutputPort.Handle(payment.Id);
        }
    }
}

