using BusinessObjects.Entities;
using BusinessObjects.ValueObjects;

namespace BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        private readonly List<OrderDetail> OrderDetailsField =
            new List<OrderDetail>();
        public IReadOnlyCollection<OrderDetail> OrderDetails =>
            OrderDetailsField;

        private void AddDetail(OrderDetail orderDetail)
        {
            var existingOrderDetail =
                OrderDetailsField.FirstOrDefault(
                    o => o.ProductId == orderDetail.ProductId);

            if (existingOrderDetail != default)
            {
                OrderDetailsField.Add(
                    existingOrderDetail with
                    {
                        Quantity = (short)
                        (existingOrderDetail.Quantity +
                        orderDetail.Quantity)
                    });

                OrderDetailsField.Remove(existingOrderDetail);
            }
            else
            {
                OrderDetailsField.Add(orderDetail);
            }
        }

        public void AddDetail(int productId,
            decimal unitPrice, short quantity) =>
            AddDetail(new OrderDetail(
                productId, unitPrice, quantity));
    }
}

