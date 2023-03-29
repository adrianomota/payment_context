using PaymentContext.Domain.Entities.Base;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;
public class Student : Entity
{
    private readonly IList<Subscription> _subscriptions;

    public Student(Name? name, Document? document, Email? email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public Name? Name { get; set; }
    public Document? Document { get; }
    public Email? Email { get; }
    public string? Address { get; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
            sub.Inactivate();
        _subscriptions.Add(subscription);
    }
}
