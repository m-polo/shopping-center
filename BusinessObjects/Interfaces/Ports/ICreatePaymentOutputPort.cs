using System;
namespace BusinessObjects.Interfaces.Ports
{
	public interface ICreatePaymentOutputPort
	{
        ValueTask Handle(int paymentId);
    }
}

