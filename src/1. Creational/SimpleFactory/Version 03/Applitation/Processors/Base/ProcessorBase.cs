using Demo.Design.Pattern.SimpleFactory.Domain.Base;

namespace Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Base;

internal abstract class ProcessorBase<T> where T : TransactionBase
{
    protected static T ValidateTransactionType(TransactionBase transaction)
    {
        if (transaction is not T)
            throw new ArgumentException("Invalid Transaction Type");

        return (T)transaction;
    }
}