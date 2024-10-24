using System;
using BusinessObjects.DTOs;

namespace BusinessObjects.Interfaces.Ports
{
	public interface ICreatePaymentInputPort
	{
        ValueTask Handle(CreatePaymentDTO paymentDto);
    }
}

