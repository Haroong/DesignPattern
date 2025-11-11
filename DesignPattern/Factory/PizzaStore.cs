namespace DesignPattern.Factory;

/// <summary>
///     피자 주문 프로세스를 관리하는 클라이언트 클래스
/// </summary>
public class PizzaStore
{
    private readonly SimplePizzaFactory _factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    }

    public Pizza orderPizza(string type)
    {
        Pizza pizza;
        pizza = _factory.CreatePizza(type);

        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();

        return pizza;
    }
}