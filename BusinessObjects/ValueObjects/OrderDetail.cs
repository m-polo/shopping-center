namespace BusinessObjects.ValueObjects
{
    public record struct OrderDetail(
        int ProductId, decimal UnitPrice, short Quantity);
}

