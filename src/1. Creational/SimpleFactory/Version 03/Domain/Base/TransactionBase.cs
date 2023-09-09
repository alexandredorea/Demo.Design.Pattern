namespace Demo.Design.Pattern.SimpleFactory.Domain.Base;

using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;
using System.Data;

internal abstract class TransactionBase
{
    public Guid TransactionKey { get; }
    public double Amount { get; }
    public DateTime CreatedAt { get; }
    public TransactionType TransactionType { get; private set; }
    public TransactionStatusType TransactionStatusType { get; private set; }

    protected TransactionBase(TransactionType transactionType, double amount)
    {
        TransactionKey = Guid.NewGuid();
        Amount = amount;
        TransactionType = transactionType;
        TransactionStatusType = TransactionStatusType.Pending;
        CreatedAt = DateTime.UtcNow;
    }

    public bool SetStatusInProgress()
    {
        StatusTransitionValidate(TransactionStatusType.InProgress);

        this.TransactionStatusType = TransactionStatusType.InProgress;

        return true;
    }

    public bool SetStatusAuthorized()
    {
        StatusTransitionValidate(TransactionStatusType.Authorized);

        this.TransactionStatusType = TransactionStatusType.Authorized;

        return true;
    }

    public bool SetStatusUnauthorized()
    {
        StatusTransitionValidate(TransactionStatusType.Unauthorized);

        this.TransactionStatusType = TransactionStatusType.Unauthorized;

        return true;
    }

    private bool StatusTransitionValidate(TransactionStatusType desiredTransactionStatusType)
    {
        if (TransactionStatusType == desiredTransactionStatusType)
            throw new ConstraintException("No transaction status transition");

        if ((int)TransactionStatusType < (int)desiredTransactionStatusType)
            throw new ConstraintException("Invalid transaction status transition");

        if ((int)TransactionStatusType <= 1)
            throw new ConstraintException("Invalid transaction status transition from end state process");

        return true;
    }
}