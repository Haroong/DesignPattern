# Chapter 1: Strategy 패턴
## 개념
알고리즘을 정의하고 캡슐화해서 각각의 알고리즘을 수정해서 사용 할 수 있다.
즉, 독립적으로 변경이 가능하다.

## 언제 사용하면 좋을까?
- 비슷한 클래스들이 행동만 다를 때
- 알고리즘의 여러 변형이 필요할 때
- 런타임에 알고리즘을 동적으로 변경해야 할 때
- 조건문(if-else, switch)이 많아서 복잡할 때

### 예제
```
Duck 
├── IFlyBehavior 
│   ├── FlyWithWings
│   ├── FlyNoWay 
│   └── FlyRocketPowered 
└── IQuackBehavior 
    ├── QuackBehavior
    └── MuteQuack 
```

### 
```csharp
// 1. 행동을 인터페이스로 정의
public interface IFlyBehavior {
    void Fly();
}

// 2. 구체적인 행동 구현
public class FlyWithWings : IFlyBehavior {
    public void Fly() => Console.WriteLine("날아간다!");
}

// 3. Duck 클래스는 행동을 위임 (composition)
public class Duck {
    private IFlyBehavior _flyBehavior;

    public void PerformFly() {
        _flyBehavior.Fly();  // 구현이 아닌 인터페이스에 의존
    }

    // 런타임에 행동 변경 가능
    public void setFlyBehavior(IFlyBehavior fb) {
        _flyBehavior = fb;
    }
}
```

## 장점
1. **유연성**: 런타임에 알고리즘 변경 가능 (`setFlyBehavior()`)
2. **재사용성**: 행동을 여러 클래스에서 재사용
3. **확장성**: 새로운 행동 추가 시 기존 코드 수정 불필요 (OCP 원칙)
4. **테스트 용이**: 각 전략을 독립적으로 테스트 가능


## 디자인 원칙
- 애플리케이션에서 달라지는 부분을 찾아내고, 달라지지 않는 부분과 분리한다.
- 구현보다는 인터페이스에 맞춰서 프로그래밍한다.
- 상속보다는 구성(composition)을 활용한다.
> composition: 두 클래스를 합쳐서 사용하는 것
