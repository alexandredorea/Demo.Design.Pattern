namespace Demo.Design.Pattern.SimpleFactory.Domain;

using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

internal sealed class TransactionResponse
{
    public Guid TransactionKey { get; }
    public DateTime CreateDate { get; }
    public double Amount { get; }
    public TransactionStatusType TransactionStatusType { get; }

    public TransactionResponse(Guid transactionKey, DateTime date, double amount, TransactionStatusType transactionStatusType)
    {
        TransactionKey = transactionKey;
        CreateDate = date;
        Amount = amount;
        TransactionStatusType = transactionStatusType;
    }
}