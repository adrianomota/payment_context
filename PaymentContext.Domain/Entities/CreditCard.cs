using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities;
public class CreditCard : Payment
{
    public CreditCard(
            DateTime? paidDate,
            DateTime? expiredDate,
            decimal? total,
            decimal? totalPaid,
            string? owner,
            Document? document,
            string? address,
            string? cardHolderName,
            string? cardHolderNumber,
            string? correlationLastTransactionNumber)
    : base(paidDate,
          expiredDate,
          total,
          totalPaid,
          owner,
          document,
          address)
    {
        CardHolderName = cardHolderName;
        CardHolderNumber = cardHolderNumber;
        CorrelationLastTransactionNumber = correlationLastTransactionNumber;
    }

    public string? CardHolderName { get; set; }
    public string? CardHolderNumber { get; set; }
    public string? CorrelationLastTransactionNumber { get; set; }
}
