using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Concrete.Mac;

public sealed class MacDialog : IDialog
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Dialog");
    }
}