﻿namespace Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

public enum TransactionType
{
    /// <summary>
    /// Cartão de crédito
    /// </summary>
    CreditCard = 0,

    /// <summary>
    /// Débito
    /// </summary>
    Debit = 1,

    /// <summary>
    /// Boleto
    /// </summary>
    PaymentSlip = 2
}