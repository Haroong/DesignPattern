namespace DesignPattern.Factory;

public abstract class Pizza
{
    protected readonly List<string> _toppings = new();

    protected string _dough;
    protected string _sauce;
    protected string _name { get; set; }

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("175도의 오븐에서 25분 동안 피자 굽기");
    }

    public virtual void Cut()
    {
        Console.WriteLine("피자를 사선으로 자르기");
    }

    public void Box()
    {
        Console.WriteLine("상자에 피자 담기");
    }
}