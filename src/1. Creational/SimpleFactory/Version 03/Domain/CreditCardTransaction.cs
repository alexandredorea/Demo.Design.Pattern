namespace Demo.Design.Pattern.SimpleFactory.Domain;

using Demo.Design.Pattern.SimpleFactory.Domain.Base;
using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

internal sealed class CreditCardTransaction : TransactionBase
{
    public string HolderName { get; }
    public string CardNumber { get; }
    public string SecurityCode { get; }

    public CreditCardTransaction(
        string holderName,
        string cardNumber,
        string securityCode,
        double amount)
        : base(TransactionType.CreditCard, amount)
    {
        HolderName = holderName;
        SecurityCode = securityCode;
        CardNumber = cardNumber;
    }
}