namespace Demo.Design.Pattern.SimpleFactory.Domain;

using Demo.Design.Pattern.SimpleFactory.Domain.Base;
using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

internal sealed class PaymentSlipTransaction : TransactionBase
{
    public string DocumentNumber { get; }
    public string BarCode { get; }
    public DateTime DueDate { get; }

    public PaymentSlipTransaction(
        string documentNumber,
        string barCode,
        DateTime dueDate,
        TransactionType transactionType,
        double amount)
        : base(transactionType, amount)
    {
        DocumentNumber = documentNumber;
        BarCode = barCode;
        DueDate = dueDate;
    }
}