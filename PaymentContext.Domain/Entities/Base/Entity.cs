namespace PaymentContext.Domain.Entities.Base;
public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        Active = true;
    }
    protected Guid? Id { get; set; }
    protected DateTime? CreatedAt { get; set; }
    protected DateTime? UpdatedAt { get; set; }
    protected bool? Active { get; set; }
}
