# Chapter 3: Decorator 패턴
## 개념
객체에 추가 요소를 동적으로 더할 수 있다.
서브클래스를 만들 때보다 훨씬 유연하게 기능을 확장할 수 있다.

## 언제 사용하면 좋을까?
- 기존 객체의 코드 수정 없이 기능을 동적으로 추가하고 싶을 때
- 상속으로 기능을 확장하면 클래스가 너무 많아질 때 (클래스 폭발 방지)
- 런타임에 객체의 책임을 추가하거나 제거하고 싶을 때
- 횡단 관심사(로깅, 캐싱, 인증, 트랜잭션)를 처리할 때
- 여러 기능을 자유롭게 조합하고 싶을 때

## 클래스 구조
```
Beverage (추상 클래스)
├── Description 필드
├── GetDescription() [virtual]
└── Cost() [abstract]
    ↑
    ├─── Espresso (구체 클래스)
    │    └── Cost() = 1.99
    │
    ├─── HouseBlend (구체 클래스)
    │    └── Cost() = 0.89
    │
    └─── CondimentDecorator (추상 데코레이터)
         ├── Beverage _beverage (감쌀 음료)
         ├── GetDescription() [abstract override]
         └── Cost() [abstract override]
             ↑
             ├─── Mocha (구체 데코레이터)
             │    ├── GetDescription() = _beverage.GetDescription() + " Mocha"
             │    └── Cost() = _beverage.Cost() + 0.20
             │
             └─── Whip (구체 데코레이터)
                  ├── GetDescription() = _beverage.GetDescription() + " Whip"
                  └── Cost() = _beverage.Cost() + 0.10
```

## 사용 예제
```csharp
// 1. 기본 음료
Beverage beverage1 = new Espresso();
Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());
// 출력: Espresso Coffee $1.99

// 2. 데코레이터로 감싸기
Beverage beverage2 = new HouseBlend();
beverage2 = new Mocha(beverage2);        // 모카 추가
beverage2 = new Mocha(beverage2);        // 모카 한 번 더 추가
beverage2 = new Whip(beverage2);         // 휘핑크림 추가
Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
// 출력: House Blend Coffee Mocha Mocha Whip $1.39
```

## 장점
1. **유연한 기능 확장**: 상속보다 유연하게 기능을 조합할 수 있음
2. **단일 책임 원칙(SRP)**: 각 데코레이터는 하나의 기능만 담당
3. **개방-폐쇄 원칙(OCP)**: 기존 코드 수정 없이 새로운 데코레이터 추가 가능
4. **런타임 조합**: 실행 중에 동적으로 기능을 추가/제거 가능
5. **클래스 폭발 방지**: 모든 조합마다 새 클래스를 만들 필요 없음
   - 예: 음료 3개 × 첨가물 5개 = 15개 클래스 대신, 8개 클래스로 무한 조합 가능

## 단점
1. **복잡도 증가**: 데코레이터가 많아지면 코드 이해가 어려워질 수 있음
2. **디버깅 어려움**: 여러 겹 감싸진 객체는 디버깅이 복잡함
3. **순서 의존성**: 데코레이터를 감싸는 순서가 중요할 수 있음
4. **성능 오버헤드**: 메서드 호출이 여러 번 일어나므로 약간의 성능 저하


## 실전 활용 예제

### 웹 서비스에서의 데코레이터 패턴
```csharp
// 1. 인증/인가 미들웨어
IRequestHandler handler = new BaseRequestHandler();
handler = new AuthenticationDecorator(handler);
handler = new AuthorizationDecorator(handler);
handler = new LoggingDecorator(handler);

// 2. 캐싱
IDataRepository repository = new DatabaseRepository();
repository = new CacheDecorator(repository);
repository = new ValidationDecorator(repository);

// 3. HTTP 클라이언트
IHttpClient client = new HttpClient();
client = new RetryDecorator(client, maxRetries: 3);
client = new TimeoutDecorator(client, timeout: 5000);
client = new LoggingDecorator(client);
```

## 디자인 원칙
- **개방-폐쇄 원칙(Open-Closed Principle)**: 클래스는 확장에는 열려 있어야 하지만 변경에는 닫혀 있어야 한다.
  - 기존 코드를 수정하지 않고도 새로운 데코레이터를 추가하여 기능을 확장할 수 있다.
