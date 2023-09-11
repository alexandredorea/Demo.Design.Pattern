namespace Demo.Design.Pattern.FactoryMethod.Application.Factories;

using Demo.Design.Pattern.FactoryMethod.Domain;
using Demo.Design.Pattern.FactoryMethod.Interfaces;

/// <summary>
/// A classe concreta PlatinumFactory reescreve o método MakeProduct da fábrica para criar e retornar o Produto Platinum
/// </summary>
internal sealed class PlatinumFactory : CreditCardFactory
{
    /// <summary>
    /// A assinatura do método usa o produto abstrato do tipo ICreditCard, embora o produto concreto Platinum seja retornado no método.
    /// Desta forma, o a classe Creator CreditCardFactory pode permanecer independente de classes concretas de produtos.
    /// </summary>
    /// <returns></returns>
    protected override ICreditCard MakeProduct()
    {
        var product = new Platinum();
        return product;
    }
}