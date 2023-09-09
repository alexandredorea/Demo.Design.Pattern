namespace Demo.Design.Pattern.FactoryMethod.Domain.Models;

using Demo.Design.Pattern.FactoryMethod.Application.Interfaces;

internal sealed class ExhaustFan : IFan
{
    public string Name { get; private set; }

    public ExhaustFan(string name)
    {
        Name = name;
    }

    public void SwitchOff()
    {
        Console.WriteLine($"{Name} desligado.");
    }

    public void SwitchOn()
    {
        Console.WriteLine($"{Name} ligando.");
    }
}