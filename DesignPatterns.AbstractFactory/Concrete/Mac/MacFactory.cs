using DesignPatterns.AbstractFactory.Abstract;

namespace DesignPatterns.AbstractFactory.Concrete.Mac;

public sealed class MacFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public IDialog CreateDialog()
    {
        return new MacDialog();
    }
}