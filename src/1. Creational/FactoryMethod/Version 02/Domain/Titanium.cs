namespace Demo.Design.Pattern.FactoryMethod.Domain;

using Demo.Design.Pattern.FactoryMethod.Interfaces;

/// <summary>
/// O produto Titanium fornece implementações dos métodos da interface ICreditCard.
/// </summary>
internal sealed class Titanium : ICreditCard
{
    public int GetAnnualCharge()
    {
        return 1500;
    }

    public string GetCardType()
    {
        return "Titanium Edge";
    }

    public int GetCreditLimit()
    {
        return 25000;
    }
}