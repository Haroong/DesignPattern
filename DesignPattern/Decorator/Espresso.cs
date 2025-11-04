namespace DesignPattern.Decorator;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso Coffee";
    }

    public override double Cost()
    {
        return 1.99;
    }
}