namespace Demo.Design.Pattern.Simplefactory.Products;

using Demo.Design.Pattern.Simplefactory.Interfaces;

internal class CeilingFan : IFan
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