using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Concrete.Windows;

public sealed class WindowsFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IDialog CreateDialog()
    {
        return new WindowsDialog();
    }
}