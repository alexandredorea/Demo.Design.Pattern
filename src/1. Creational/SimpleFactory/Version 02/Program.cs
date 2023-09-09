using Demo.Design.Pattern.SimpleFactory.Application.Factories;
using Demo.Design.Pattern.SimpleFactory.Domain.Enumerators;
using Demo.Design.Pattern.SimpleFactory.Interfaces;

// Instanciado a fabrica
ICreditCardFactory simpleFactory = new CreditCardFactory();

// Criação de um cartão de crédito usando Simple Factory
ICreditCard creditCard = simpleFactory.GetCreditCard(CardType.Platinum);

// Usando o objeto criado
Console.WriteLine($"Tipo de Cartão...: {creditCard.GetCardType()}.");
Console.WriteLine($"Limite de Crédito: {creditCard.GetCreditLimit()}.");
Console.WriteLine($"Cobrança Anual...: {creditCard.GetAnnualCharge()}.");

Console.ReadKey();