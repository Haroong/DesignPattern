namespace DesignPattern.Factory;

/// <summary>
///     피자 주문 프로세스를 관리하는 클라이언트 클래스
/// </summary>
public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;
        pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    /// <summary>
    ///     Pizza 인스턴스를 생성하는 팩토리 메소드
    ///     Factory Method: 객체 생성을 서브클래스에서 캡슐화
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    protected abstract Pizza CreatePizza(string type);
}