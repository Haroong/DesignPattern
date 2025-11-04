namespace DesignPattern.Decorator;

public static class DecoratorExample
{
    public static void Run()
    {
        Console.WriteLine("Welcome to Starbucks coffee!");   
        
        Beverage beverage1 = new Espresso();
        Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());

        Beverage beverage2 = new HouseBlend();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
    }
}
