namespace DesignPattern.Decorator;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + " Mocha";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.20;
    }
}