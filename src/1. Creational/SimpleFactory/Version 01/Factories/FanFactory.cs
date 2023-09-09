namespace Demo.Design.Pattern.Simplefactory.Factories;

using Demo.Design.Pattern.Simplefactory.Enumerators;
using Demo.Design.Pattern.Simplefactory.Interfaces;
using Demo.Design.Pattern.Simplefactory.Products;

internal sealed class FanFactory : IFanFactory
{
    public IFan CreateFan(FanType type)
    {
        switch (type)
        {
            case FanType.TableFan:
                return new TableFan("Ventilador de mesa");

            case FanType.CeilingFan:
                return new CeilingFan("Ventilador de teto");

            case FanType.ExhaustFan:
                return new ExhaustFan("Exaustor");

            default:
                throw new NotSupportedException("Tipo não suportado");
        }
    }
}