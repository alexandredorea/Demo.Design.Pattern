using Demo.Design.Pattern.FactoryMethod.Application.Factories;
using Demo.Design.Pattern.FactoryMethod.Interfaces;

// O código do cliente funciona com uma instância de um criador concreto.
// O CreateProduct retornará a instância real do produto por meio da interface do produto.
// O método PlatinumFactory.CreateProduct retornará uma instância do Produto Platinum por meio da interface ICreditCard.

ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine($"Tipo de Cartão...: {creditCard.GetCardType()}.");
    Console.WriteLine($"Limite de Crédito: {creditCard.GetCreditLimit()}.");
    Console.WriteLine($"Cobrança Anual...: {creditCard.GetAnnualCharge()}.");
}
else
{
    Console.Write("Tipo de cartão inválido.");
}
Console.WriteLine("--------------");

// O método TitaniumFactory.CreateProduct retornará uma instância do Produto Titanium por meio da interface ICreditCard.
creditCard = new TitaniumFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine($"Tipo de Cartão...: {creditCard.GetCardType()}.");
    Console.WriteLine($"Limite de Crédito: {creditCard.GetCreditLimit()}.");
    Console.WriteLine($"Cobrança Anual...: {creditCard.GetAnnualCharge()}.");
}
else
{
    Console.Write("Tipo de cartão inválido.");
}

Console.ReadKey();