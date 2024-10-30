using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Concrete.Windows;

public sealed class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Button");
    }
}