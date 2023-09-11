namespace Demo.Design.Pattern.FactoryMethod.Domain;

using Demo.Design.Pattern.FactoryMethod.Interfaces;

/// <summary>
/// O produto MoneyBack fornece implementações dos métodos da interface ICreditCard.
/// </summary>
internal sealed class MoneyBank : ICreditCard
{
    public int GetAnnualCharge()
    {
        return 500;
    }

    public string GetCardType()
    {
        return nameof(MoneyBank);
    }

    public int GetCreditLimit()
    {
        return 1000;
    }
}