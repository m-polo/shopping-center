using System;
using BusinessObjects.DTOs;

namespace BusinessObjects.Interfaces.Controllers
{
	public interface ICreateOrderController
	{
        ValueTask<int> CreateOrder(CreateOrderDTO order);
    }
}

