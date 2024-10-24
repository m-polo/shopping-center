using System;
using BusinessObjects.Interfaces.Ports;

namespace BusinessObjects.Interfaces.Presenters
{
	public interface ICreatePaymentPresenter : ICreatePaymentOutputPort
	{
		int PaymentId { get; }
	}
}

