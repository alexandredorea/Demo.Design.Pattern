namespace Demo.Design.Pattern.FactoryMethod.Application.Factories;

using Demo.Design.Pattern.FactoryMethod.Application.Interfaces;
using Demo.Design.Pattern.FactoryMethod.Domain.Models;

internal sealed class WallFanFactory : IFanFactory
{
    public IFan CreateFan()
    {
        return new WallFan("Ventilador de parede");
    }
}