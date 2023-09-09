namespace Demo.Design.Pattern.SimpleFactory.Domain;

using Demo.Design.Pattern.SimpleFactory.Domain.Base;
using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

internal sealed class DebitTransaction : TransactionBase
{
    public string BankName { get; }

    public DebitTransaction(
        string bankName,
        TransactionType transactionType,
        double amount) : base(transactionType, amount)
    {
        BankName = bankName;
    }
}