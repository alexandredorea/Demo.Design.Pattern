namespace Demo.Design.Pattern.Simplefactory.Products;

using Demo.Design.Pattern.Simplefactory.Interfaces;

internal class ExhaustFan : IFan
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