namespace DesignPattern.Decorator;

public abstract class Beverage
{
    protected string _description = "Default Beverage";
    private Size _size = Size.Tall;

    public virtual string GetDescription()
    {
        return _description;
    }

    public void SetSize(Size size)
    {
        _size = size;
    }

    public Size GetSize()
    {
        return _size;
    }

    public abstract double Cost();
}