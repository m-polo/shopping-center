using System;
using BusinessObjects.Enums;

namespace BusinessObjects.Entities
{
	public class Payment
	{
		public int Id;
		public int OrderId;
		public int Amount;
		public StatusType Status;
		public CurrencyType Currency;
	}
}

