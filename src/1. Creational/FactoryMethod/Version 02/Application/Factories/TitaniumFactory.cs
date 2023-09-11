namespace Demo.Design.Pattern.FactoryMethod.Application.Factories;

using Demo.Design.Pattern.FactoryMethod.Domain;
using Demo.Design.Pattern.FactoryMethod.Interfaces;

internal sealed class TitaniumFactory : CreditCardFactory
{
    protected override ICreditCard MakeProduct()
    {
        var product = new Titanium();
        return product;
    }
}