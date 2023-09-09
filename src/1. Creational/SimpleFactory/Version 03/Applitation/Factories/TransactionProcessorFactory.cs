namespace Demo.Design.Pattern.SimpleFactory.Applitation.Factories;

using Demo.Design.Pattern.SimpleFactory.Applitation.Processors;
using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Interfaces;
using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

internal static class TransactionProcessorFactory
{
    internal static ITransactionProcessor CreateTransactionProcessor(TransactionType transactionType)
    {
        return transactionType switch
        {
            TransactionType.CreditCard => new CrediCardTransactionProcessor(),
            TransactionType.Debit => new DebitTransactionProcessor(),
            TransactionType.PaymentSlip => new PaymentSlipTransactionProcessor(),
            _ => throw new ArgumentOutOfRangeException(),
        };
    }
}