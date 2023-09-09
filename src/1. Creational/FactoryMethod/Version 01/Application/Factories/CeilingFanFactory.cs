namespace Demo.Design.Pattern.FactoryMethod.Application.Factories;

using Demo.Design.Pattern.FactoryMethod.Application.Interfaces;
using Demo.Design.Pattern.FactoryMethod.Domain.Models;

internal sealed class CeilingFanFactory : IFanFactory
{
    public IFan CreateFan()
    {
        return new CeilingFan("Ventilador de teto");
    }
}