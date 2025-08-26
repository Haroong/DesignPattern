namespace DesignPattern;

public interface IQuackBehavior
{
    void Quack();
}

public class QuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("오리 꽥꽥");
    }
}

public class MuteQuack: IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("(음소거 모드)");
    }
}
