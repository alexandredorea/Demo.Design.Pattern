namespace Demo.Design.Pattern.SimpleFactory.Applitation.Processors;

using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Base;
using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Interfaces;
using Demo.Design.Pattern.SimpleFactory.Domain;
using Demo.Design.Pattern.SimpleFactory.Domain.Base;

internal sealed class CrediCardTransactionProcessor : ProcessorBase<CreditCardTransaction>, ITransactionProcessor
{
    public TransactionResponse Authorize(TransactionBase transaction)
    {
        var creditCardTransaction = ValidateTransactionType(transaction);
        return ProcessAuthorization(ref creditCardTransaction);
    }

    private static TransactionResponse ProcessAuthorization(ref CreditCardTransaction creditCardTransaction)
    {
        creditCardTransaction.SetStatusInProgress();
        BusinessRules(ref creditCardTransaction);
        return new TransactionResponse(
            creditCardTransaction.TransactionKey,
            creditCardTransaction.CreatedAt,
            creditCardTransaction.Amount,
            creditCardTransaction.TransactionStatusType);
    }

    /// <summary>
    /// Código de simulação de autorização, apenas para fins didádicos.
    /// </summary>
    /// <param name="creditCardTransaction">Transação de crédito</param>
    private static void BusinessRules(ref CreditCardTransaction creditCardTransaction)
    {
        if (creditCardTransaction.Amount >= 10 && creditCardTransaction.Amount <= 12000)
        {
            creditCardTransaction.SetStatusAuthorized();
            return;
        }

        creditCardTransaction.SetStatusUnauthorized();
    }
}