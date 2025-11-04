namespace DesignPattern.Strategy;

public static class StrategyExample
{
    public static void Run()
    {
        Duck rubberDuck = new RubberDuck();
        rubberDuck.PerformQuack();
        rubberDuck.PerformFly();

        rubberDuck.setFlyBehavior(new FlyRocketPowered());
        rubberDuck.PerformFly();
    }
}
