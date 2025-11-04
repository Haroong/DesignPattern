namespace DesignPattern.Decorator;

public abstract class Beverage
{
    protected string Description = "Default Beverage";

    public string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}