namespace Demo.Design.Pattern.Simplefactory.Interfaces;

using Demo.Design.Pattern.Simplefactory.Enumerators;

internal interface IFanFactory
{
    IFan CreateFan(FanType type);
}