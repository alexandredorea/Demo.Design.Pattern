namespace Demo.Design.Pattern.FactoryMethod.Domain;

using Demo.Design.Pattern.FactoryMethod.Application.Interfaces;

internal sealed class CeilingFan : IFan
{
    public string Name { get; private set; }

    public CeilingFan(string name)
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