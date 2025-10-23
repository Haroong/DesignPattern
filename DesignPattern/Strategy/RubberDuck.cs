using DesignPattern.Strategy;

namespace DesignPattern;

public class RubberDuck : Duck
{
    public RubberDuck() : base(new MuteQuack(), new FlyNoWay())
    {

    }

}