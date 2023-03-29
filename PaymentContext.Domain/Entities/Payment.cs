using PaymentContext.Domain.Entities.Base;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Extensions;
namespace PaymentContext.Domain.Entities;
public abstract class Payment : Entity
{
    protected Payment(DateTime? paidDate,
                      DateTime? expiredDate,
                      decimal? total,
                      decimal? totalPaid,
                      string? owner,
                      Document? document,
                      string? address)
    {
        Number = Guid.NewGuid().GetPaymentNumber();
        PaidDate = paidDate;
        ExpiredDate = expiredDate;
        Total = total;
        TotalPaid = totalPaid;
        Owner = owner;
        Document = document;
        Address = address;
    }

    public string? Number { get; set; }
    public DateTime? PaidDate { get; set; }
    public DateTime? ExpiredDate { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalPaid { get; set; }
    public string? Owner { get; set; }
    public Document? Document { get; set; }
    public string? Address { get; set; }
}
