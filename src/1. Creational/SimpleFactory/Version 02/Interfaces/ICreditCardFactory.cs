namespace Demo.Design.Pattern.SimpleFactory.Interfaces;

using Demo.Design.Pattern.SimpleFactory.Domain.Enumerators;

internal interface ICreditCardFactory
{
    ICreditCard GetCreditCard(CardType type);
}