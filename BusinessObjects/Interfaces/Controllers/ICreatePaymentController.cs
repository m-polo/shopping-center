using System;
using BusinessObjects.DTOs;

namespace BusinessObjects.Interfaces.Controllers
{
	public interface ICreatePaymentController
	{
		ValueTask<int> CreatePayment(CreatePaymentDTO payment);
	}
}

