namespace DesignPattern.Factory;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        _name = "시카고 스타일 딥 디쉬 치즈 피자";
        _dough = "아주 두꺼운 크러스트 도우";
        _sauce = "플럼 토마토 소스";

        _toppings.Add("잘게 조각낸 모짜렐라 치즈");
    }

    public override void Cut()
    {
        Console.WriteLine("피자를 사각형 모양으로 자르기");
    }
}