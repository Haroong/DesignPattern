namespace DesignPattern;

public abstract class Duck
{
    private IQuackBehavior _quackBehavior;
    private IFlyBehavior _flyBehavior;

    public Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
    {
        _quackBehavior = quackBehavior;
        _flyBehavior = flyBehavior;
    }

    public void PerformQuack()
    {
        _quackBehavior.Quack();
    }

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public static void Swim()
    {
        Console.WriteLine("오리발로 수영 할 수 있어");
    }

    public void setFlyBehavior(IFlyBehavior fb)
    {
        _flyBehavior = fb;
    }

    public void setQuackBehavior(IQuackBehavior qb)
    {
        _quackBehavior = qb;
    }
}