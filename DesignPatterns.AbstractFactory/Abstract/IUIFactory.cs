namespace DesignPatterns.AbstractFactory.Abstract;

public interface IUIFactory
{
    public IButton CreateButton();
    public IDialog CreateDialog();
}