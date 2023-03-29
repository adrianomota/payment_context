using PaymentContext.Domain.Entities.Base;
namespace PaymentContext.Domain.Entities;
public class Subscription : Entity
{
    private readonly IList<Payment> _paymants;
    public Subscription(DateTime? expiredAt)
    {
        ExpiredAt = expiredAt;
        _paymants = new List<Payment>();
    }
    public DateTime? ExpiredAt { get; }
    public IReadOnlyCollection<Payment> Payments { get { return _paymants.ToArray(); } }
    public void Activate() => Active = true;
    public void Inactivate() => Active = false;
    public void AddPayment(Payment payment) => _paymants.Add(payment);
}
