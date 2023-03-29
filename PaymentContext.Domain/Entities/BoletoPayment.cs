using PaymentContext.Domain.ValueObjects;
namespace PaymentContext.Domain.Entities;
public class BoletoPayment : Payment
{
    public BoletoPayment(
            DateTime? paidDate,
            DateTime? expiredDate,
            decimal? total,
            decimal? totalPaid,
            string? owner,
            Document? document,
            string? address,
            string? barCode,
            string? correlationBoletoNumber)
        : base(paidDate,
                expiredDate,
                total,
                totalPaid,
                owner,
                document,
                address)
    {
        BarCode = barCode;
        CorrelationBoletoNumber = correlationBoletoNumber;
    }
    public string? BarCode { get; set; }
    public string? CorrelationBoletoNumber { get; set; }
}
