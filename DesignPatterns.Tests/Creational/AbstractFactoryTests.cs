using DesignPatterns.AbstractFactory.Abstract;
using DesignPatterns.AbstractFactory.Concrete.Mac;
using DesignPatterns.AbstractFactory.Concrete.Windows;
using FluentAssertions;

namespace DesignPatterns.Tests.Creational;

public sealed class AbstractFactoryTests
{
    [Fact]
    public void WindowsFactory_ShouldCreate_WindowsButtonAndWindowsDialog()
    {
        IUIFactory factory = new WindowsFactory();
        
        var button = factory.CreateButton();
        var dialog = factory.CreateDialog();
        
        button.Should().BeOfType<WindowsButton>();
        dialog.Should().BeOfType<WindowsDialog>();
    }
    
    [Fact]
    public void MacFactory_ShouldCreate_MacButtonAndMacDialog()
    {
        IUIFactory factory = new MacFactory();

        var button = factory.CreateButton();
        var dialog = factory.CreateDialog();

        button.Should().BeOfType<MacButton>();
        dialog.Should().BeOfType<MacDialog>();
    }
}