namespace PaymentContext.Shared.Extensions;
public static class StringExtension
{
    public static string? GetPaymentNumber(this Guid value)
        => value.ToString().Replace("-", "").Substring(0, 10).ToUpper();
}
