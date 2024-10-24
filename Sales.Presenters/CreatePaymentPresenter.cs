using BusinessObjects.Interfaces.Presenters;

namespace Sales.Presenters;

public class CreatePaymentPresenter : ICreatePaymentPresenter
{
    public int PaymentId { get; private set; }

    public ValueTask Handle(int paymentId)
    {
        PaymentId = paymentId;
        return ValueTask.CompletedTask;
    }
}
