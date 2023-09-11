namespace Demo.Design.Pattern.FactoryMethod.Domain;

using Demo.Design.Pattern.FactoryMethod.Interfaces;

/// <summary>
/// O produto Platinum fornece implementações dos métodos da interface ICreditCard.
/// </summary>
internal sealed class Platinum : ICreditCard
{
    public int GetAnnualCharge()
    {
        return 2000;
    }

    public string GetCardType()
    {
        return "Platinum Plus";
    }

    public int GetCreditLimit()
    {
        return 35000;
    }
}