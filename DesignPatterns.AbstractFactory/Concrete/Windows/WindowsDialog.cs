using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Concrete.Windows;

public sealed class WindowsDialog : IDialog
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Dialog");
    }
}