namespace Demo.Design.Pattern.SimpleFactory.Applitation.Processors;

using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Base;
using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Interfaces;
using Demo.Design.Pattern.SimpleFactory.Domain;
using Demo.Design.Pattern.SimpleFactory.Domain.Base;

internal class DebitTransactionProcessor : ProcessorBase<DebitTransaction>, ITransactionProcessor
{
    public TransactionResponse Authorize(TransactionBase transaction)
    {
        var debitTransaction = ValidateTransactionType(transaction);

        return ProcessAuthorization(debitTransaction);
    }

    private static TransactionResponse ProcessAuthorization(DebitTransaction debitTransaction)
    {
        debitTransaction.SetStatusInProgress();

        BusinessSimulation(ref debitTransaction);

        return new TransactionResponse(
            debitTransaction.TransactionKey,
            debitTransaction.CreatedAt,
            debitTransaction.Amount,
            debitTransaction.TransactionStatusType);
    }

    /// <summary>
    /// Código de simulação de autorização, apenas para fins didádicos
    /// </summary>
    /// <param name="debitTransaction">transação de débito</param>
    private static void BusinessSimulation(ref DebitTransaction debitTransaction)
    {
        if (debitTransaction.Amount >= 1 && debitTransaction.Amount <= 5000)
        {
            debitTransaction.SetStatusAuthorized();
            return;
        }

        debitTransaction.SetStatusUnauthorized();
    }
}