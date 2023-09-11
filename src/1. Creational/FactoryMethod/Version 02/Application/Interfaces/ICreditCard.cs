namespace Demo.Design.Pattern.FactoryMethod.Interfaces;

/// <summary>
/// A interface ICreditCard declara as operações que todos os produtos concretos devem implementar.
/// </summary>
internal interface ICreditCard
{
    string GetCardType();

    int GetCreditLimit();

    int GetAnnualCharge();
}