namespace Demo.Design.Pattern.SimpleFactory.Domain;

using Demo.Design.Pattern.SimpleFactory.Interfaces;

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