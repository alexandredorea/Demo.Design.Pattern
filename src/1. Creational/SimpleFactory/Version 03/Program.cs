using Demo.Design.Pattern.SimpleFactory.Applitation.Factories;
using Demo.Design.Pattern.SimpleFactory.Domain;
using Demo.Design.Pattern.SimpleFactory.Domain.ValueObjects;

var factory = TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);
var transaction = new CreditCardTransaction("Joe Satriani", "222", "1111222233334444", 1000);
var result = factory.Authorize(transaction);

Console.WriteLine(
    $"{result.Amount} | " +
    $"{result.CreateDate:g} | " +
    $"{result.TransactionKey} | " +
    $"{result.TransactionStatusType}");