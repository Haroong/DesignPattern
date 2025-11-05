namespace DesignPattern.Decorator;

public class Mocha(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string GetDescription()
    {
        return _beverage.GetDescription() + " Mocha";
    }

    public override double Cost()
    {
        var cost = _beverage.Cost();
        if (_beverage.GetSize() == Size.Tall) return cost += 0.10;
        if (_beverage.GetSize() == Size.Grande) return cost + 0.20;
        return cost + 0.30;
    }
}