namespace DesignPattern.Decorator;

public abstract class Beverage
{
    protected string Description = "Default Beverage";

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}