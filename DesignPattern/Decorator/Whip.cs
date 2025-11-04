namespace DesignPattern.Decorator;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + " Whip";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }
}