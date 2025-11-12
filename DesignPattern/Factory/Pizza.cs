namespace DesignPattern.Factory;

public abstract class Pizza
{
    private string _dough;
    private string _name;
    private readonly List<string> _toppings = new();
    private string sauce;

    public void prepare()
    {
        Console.WriteLine($"{_name} 피자 준비 중...");
        Console.WriteLine("도우를 돌리는 중...");
        Console.WriteLine("소스를 뿌리는 중...");
        Console.WriteLine("토핑을 올리는 중: ");
        foreach (var topping in _toppings) Console.WriteLine($"  {topping}");
    }

    public void bake()
    {
        Console.WriteLine("175도의 오븐에서 25분 동안 피자 굽기");
    }

    public void cut()
    {
        Console.WriteLine("피자를 사선으로 자르기");
    }

    public void box()
    {
        Console.WriteLine("상자에 피자 담기");
    }
}