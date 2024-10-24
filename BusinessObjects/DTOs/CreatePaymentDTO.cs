using System;
using BusinessObjects.Enums;

namespace BusinessObjects.DTOs
{
	public class CreatePaymentDTO
	{
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public StatusType Status { get; set; }
        public CurrencyType Currency { get; set; }
    }
}

