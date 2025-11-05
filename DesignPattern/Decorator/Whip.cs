namespace DesignPattern.Decorator;

public class Whip(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return _beverage.GetDescription() + " Whip";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }
}