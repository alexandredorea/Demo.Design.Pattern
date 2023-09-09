namespace Demo.Design.Pattern.SimpleFactory.Domain;

using Demo.Design.Pattern.SimpleFactory.Interfaces;

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