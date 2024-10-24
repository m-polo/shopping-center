using System;
using BusinessObjects.DTOs;

namespace BusinessObjects.Interfaces.Ports
{
    public interface ICreateOrderInputPort
    {
        ValueTask Handle(CreateOrderDTO orderDto);
    }
}

