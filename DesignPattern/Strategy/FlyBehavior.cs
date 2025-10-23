namespace DesignPattern;

public interface IFlyBehavior
{
    void Fly();
}

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("오리가 훨훨 날다!");
    }
}

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("하늘을 날 수 없는 오리 ㅠㅠ");
    }
}

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("로켓 추진으로 날아가는 오리");
    }
}