using Demo.Design.Pattern.FactoryMethod.Application.Interfaces;

namespace Demo.Design.Pattern.FactoryMethod.Domain.Models;

internal sealed class WallFan : IFan
{
    public string Name { get; private set; }

    public WallFan(string name)
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