namespace DesignPattern.Decorator;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage _beverage;

    protected CondimentDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }

    public abstract override string GetDescription();
}