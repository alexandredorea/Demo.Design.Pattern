namespace Demo.Design.Pattern.SimpleFactory.Interfaces;

internal interface ICreditCard
{
    string GetCardType();

    int GetCreditLimit();

    int GetAnnualCharge();
}