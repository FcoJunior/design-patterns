using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Concrete.Mac;

public sealed class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Button");
    }
}