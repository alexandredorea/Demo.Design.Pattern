namespace Demo.Design.Pattern.Simplefactory.Products;

using Demo.Design.Pattern.Simplefactory.Interfaces;

internal class TableFan : IFan
{
    public string Name { get; private set; }

    public TableFan(string name)
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