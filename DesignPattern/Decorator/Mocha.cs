namespace DesignPattern.Decorator;

public class Mocha(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return _beverage.GetDescription() + " Mocha";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.20;
    }
}