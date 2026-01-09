namespace DesignPattern.Factory;

public class ChicagoStylePizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        if (type.Equals("cheese")) pizza = ChicagoStyleCheesePizza.CreateInstance();

        return pizza;
    }
}