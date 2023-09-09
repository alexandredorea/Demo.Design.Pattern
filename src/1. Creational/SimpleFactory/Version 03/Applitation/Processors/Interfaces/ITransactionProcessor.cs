using Demo.Design.Pattern.SimpleFactory.Domain;
using Demo.Design.Pattern.SimpleFactory.Domain.Base;

namespace Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Interfaces;

internal interface ITransactionProcessor
{
    TransactionResponse Authorize(TransactionBase transaction);
}