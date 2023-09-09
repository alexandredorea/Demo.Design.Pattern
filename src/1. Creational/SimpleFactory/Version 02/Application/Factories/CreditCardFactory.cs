namespace Demo.Design.Pattern.SimpleFactory.Application.Factories;

using Demo.Design.Pattern.SimpleFactory.Domain;
using Demo.Design.Pattern.SimpleFactory.Domain.Enumerators;
using Demo.Design.Pattern.SimpleFactory.Interfaces;

internal sealed class CreditCardFactory : ICreditCardFactory
{
    public ICreditCard GetCreditCard(CardType type)
    {
        switch (type)
        {
            case CardType.MoneyBack:
                return new MoneyBank();

            case CardType.Titanium:
                return new Titanium();

            case CardType.Platinum:
                return new Platinum();

            default:
                throw new NotSupportedException("Tipo de cartão não encontrado.");
        }
    }
}