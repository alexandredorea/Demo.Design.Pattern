namespace Demo.Design.Pattern.SimpleFactory.Applitation.Processors;

using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Base;
using Demo.Design.Pattern.SimpleFactory.Applitation.Processors.Interfaces;
using Demo.Design.Pattern.SimpleFactory.Domain;
using Demo.Design.Pattern.SimpleFactory.Domain.Base;

internal class PaymentSlipTransactionProcessor : ProcessorBase<PaymentSlipTransaction>, ITransactionProcessor
{
    public TransactionResponse Authorize(TransactionBase transaction)
    {
        var paymentSlipTransaction = ValidateTransactionType(transaction);

        return ProcessAuthorization(paymentSlipTransaction);
    }

    private static TransactionResponse ProcessAuthorization(PaymentSlipTransaction paymentSlipTransaction)
    {
        paymentSlipTransaction.SetStatusInProgress();

        BusinessSimulation(ref paymentSlipTransaction);

        return new TransactionResponse(
            paymentSlipTransaction.TransactionKey,
            paymentSlipTransaction.CreatedAt,
            paymentSlipTransaction.Amount,
            paymentSlipTransaction.TransactionStatusType);
    }

    /// <summary>
    /// Código de simulação de autorização, apenas para fins didádicos
    /// </summary>
    /// <param name="paymentSlipTransaction">transação de boleto</param>
    private static void BusinessSimulation(ref PaymentSlipTransaction paymentSlipTransaction)
    {
        if (paymentSlipTransaction.Amount >= 100 && paymentSlipTransaction.Amount <= 20000 && paymentSlipTransaction.DueDate.Date >= DateTime.UtcNow.Date)
        {
            paymentSlipTransaction.SetStatusAuthorized();
            return;
        }

        paymentSlipTransaction.SetStatusUnauthorized();
    }
}