namespace DesignPattern.Factory;

/// <summary>
///     타입에 따른 피자 생성 팩토리
/// </summary>
public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null; // TODO 추후 구현

        if (type.Equals("Cheese"))
            pizza = new CheesePizza();
        else if (type.Equals("Peperoni")) pizza = new PeperoniPizza();
        else if (type.Equals("Veggie")) pizza = new VeggiePizza();

        return pizza;
    }
}