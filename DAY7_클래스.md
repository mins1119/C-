# DAY7												20.07.28

## 클래스

### 객체 지향 프로그래밍 ( Object Oriented Programming )

 코드 내의 모든 것을 객체로 표현하고자 하는 프로그래밍 패러다임

객체는 데이터와 메소드로 이루어진다.

```c#
int a = 30;
int b = 20;
```

int 는 클래스고 a 와b는 객체이다. int 는 32비트 정수를 담는 객체를 위한 청사진이고, a와 b는 실제로 데이터를 담을 수 있는 실제 객체이다. a와 b를 일컬어서 int의 실체 ( Instance )라고 한다.



**객체지향 프로그래밍의 3대 특성**

- 은닉성

클래스의 사용자에게 필요한 최소한의 기능만을 노출하고 내부를 감출것을 요구한다.

- 상속성

- 다형성

객체가 여러 형태를 가질수 있다.

### 클래스

객체 지향적인 관점에서 보면 클래스는 객체를 위한 청사진인 동시에 데이터와 메소드를 묶는 집합이다. 한편으로, 코드에서 클래스는 기본 데이터 형식을 조합해서 만드는 복합 데이터 형식이다. 

```c#
class 클래스 이름
{
    //데이터와 메소드
}
```

```c#
class Cat
{
    public string name;		//데이터
    public string color;	//데이터
    
    public void Mew(){		//메소드
        Console.WriteLine($"{name} : 야옹");
    }
}
```

name과 color와 같이 클래스 안에 선언된 변수들을 일컬어 필드 ( Field ) 라고 한다.

```c#
Cat kitty;
```

다음과 같은 선언문에서 kitty는 null값을 가지게 된다. kitty자체에 메모리가 할당되는 것이 아니고 kitty는 참조로서 객체가 있는 곳을 가리킬 뿐이기 때문이다.



#### 생성자 ( Constructor ) 와 종료자 ( Finalizen )

```C#
class Cat
{
    public Cat()
    {
        name = "";
        color = "";
    }
    public Cat(string _name, string _color){
        name = _name;
        color = _color;
    }
    ~Cat()		//가비지컬렉터가 언제 동작할지 예상할 수 없다.
    {
        Console.WriteLine("잘가");
    }
    public string name;
    public string color;
    public void Mew()
    {
        Console.WriteLine($"{name} : 야옹");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cat kitty = new Cat();
        kitty.color = "하얀색";
        kitty.name = "키티";
        kitty.Mew();
        Console.WriteLine($"{kitty.name} : {kitty.color}");

        Cat nero = new Cat();
        nero.color = "검정색";
        nero.name = "네로";
        nero.Mew();
        Console.WriteLine($"{nero.name} : {nero.color}");
    }

}
/*
키티 : 야옹
키티 : 하얀색
네로 : 야옹
네로 : 검정색
*/
```

생성자는 클래스의 동일한 이름을 가지며, 객체를 생성하는 역할을 한다. 메소드와 마찬가지로 오버로딩이 가능하다.  매개변수에 따라 다양한 버전의 생성자를 준비해놓을 수 있다.

클래스를 선언할 때 명시적으로 생성자를 구현하지 않아도 컴파일러에서 생성자를 만들어 주는데 이를 기본 생성자( Dafault Constrctor ) 라고 한다. 프로그래머가 생성자를 하나라도 직접 정의하면  컴파일러는 매개변수 없는 기본생성자를 제공하지 않는다.



종료자는 클래스 이름 앞에 ~을 붙인 꼴을 한다. 생성자와는 달리 매개변수도 없고, 한정자도 사용하지 않는다.

또한 오버로딩도 불가능 하여 직접 호출 할 수도 없다. CLR의 가비지 컬렉터가 객체가 소멸되는 시점을 판단해서 종료자를 호출해준다.



종료자를 사용하지 말아야하는 이유

- CLR의 가비지 컬렉터가 언제 동작할지 예측할 수 없다.
- 명시적으로 종료자가 구현되어 있으면 가비지 컬렉터가 object로부터 상속받은  Finalize()메소드를 클래스의 족보를 타고 올라가며 호출하기 때문에 대개의 경우 성능의 저하를 가져올 확률이 크다.
- CLR의 가비지 컬렉터가 훨씬 똑똑하게 소멸을 처리 할 수있다.



### 정적 필드와 메소드

한 프로그램안에서 인스턴스는 여러개가 존재할 수 있으나 클래스는 단 하나만 존재한다.

```C#
//인스턴스에 소속된 필드의 경우
class MyClass
{
    public int a;
    public int b;
}
//
public static void Main()
{
    MyClass obj1 = new MyClass();
    obj1.a = 1;
    obj1.b = 2;
}
//클래스에 소속된 필드의 경우(static)
class MyClass
{
    public static int a;
    public static int b;
}
//
public static void Main()
{
    MyClass.a = 1;
    MyClass.b = 2;	//인스턴스를 만들지 않고 클래스의 이름을 통해 필드에 직접 접근한다.
}
```

static으로 한정하지 않은 필드는 자동으로 인스턴스에 소속되며, static으로 한정한 필드는 클래스에 소속된다.

프로그램 전체에 걸쳐 공유해야하는 변수가 있다면 정적 필드를 사용하면 된다.

```c#
class Global
{
    public static int Count = 0;
}
class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}
class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Global.Count : {Global.Count}");
        //Global.Count : 0
        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();

        Console.WriteLine($"Global.Count : {Global.Count}");
        //Global.Count : 4
    }

}
```

정적 메소드 역시 정적 필드처럼 인스턴스가 아닌 클래스자체에 소속된다. 정적메소드는 클래스의 인스턴스를 생성하지 않아도 호출이 가능하다.



인스턴스 메소드는 클래스에 소속되는 정적메소드와는 달리 인스턴스에 소속된다고 해서 인스턴스 메소드라고 한다. 인스턴스 메소드는 클래스의 인스턴스를 생성해야만 호출할 수 있는 메소드다.

```c#
class MyClass
{
    public static void StaticMethod()
    {
        // ...
    }
}
// ...
MyClass.StaticMethod();		//인스턴스 만들지 않고도 바로 호출 가능

class MyClass
{
    public void InstanceMethod()
    {
        //...
    }
}
//...
MyClass obj = new MyClass();
obj.InstanceMethod();		//인스턴스를 만들어야 호출 가능
```

보통 객체 내부의 데이터를 이용해야 하는 경우에는 인스턴스 메소드를 선언하고, 내부 데이터를 이용할 일이 없는 경우에는 별도의 인스턴스 생성 없이 호출할 수 있도록 메소드를 정적을 선언한다.



### 객체 복사하기 : 얕은 복사와 깊은 복사

얕은 복사 ( Shallow Copy ) : 객체를 복사할 때 참조만 복사하는 것

깊은 복사 ( Deep Copy ) : 힙에 보관되어 있는 내용을 복사해서 받아 별도의 힙공간에 객체를 보관하는 것

```c#
class MyClass
{
    public int myField1;
    public int myField2;

    public MyClass Deepcopy()
    {
        MyClass newCopy = new MyClass();
        newCopy.myField1 = this.myField1;
        newCopy.myField2 = this.myField2;

        return newCopy;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shallow Copy");
        {
            MyClass source = new MyClass();
            source.myField1 = 10;
            source.myField2 = 20;

            MyClass target = source;
            target.myField2 = 30;

            Console.WriteLine($"{source.myField1} {source.myField2}");
            Console.WriteLine($"{target.myField1} {target.myField2}");
        }
        Console.WriteLine("Deep Copy");
        {
            MyClass source = new MyClass();
            source.myField1 = 10;
            source.myField2 = 20;

            MyClass target = source.Deepcopy();
            target.myField2 = 30;

            Console.WriteLine($"{source.myField1} {source.myField2}");
            Console.WriteLine($"{target.myField1} {target.myField2}");
        }
    }
```

### this 키워드

#### this

객체가 자신을 지칭할 때 사용한다.

객체 외부에서는 객체의 필드나 메소드에 접근할 때 객체의 이름( 변수 또는 식별자 ) 을 사용한다면, 객체 내부에서는 자신의 필드나 메소드에 접근할 때 this 키워드를 사용한다.

``` c#
class Employee
{
    private string Name;
    private string Position;

    public void SetName(string Name)
    {
        this.Name = Name;
    }
    public string GetName()
    {
        return Name;
    }
    public void SetPosition(string Position)
    {
        this.Position = Position;
    }
    public string GetPosition()
    {
        return this.Position;
    }
}   
class Program
{
    static void Main(string[] args)
    {
        Employee Alice = new Employee();
        Alice.SetName("Alice Liddel");
        Alice.SetPosition("Chef");
        Console.WriteLine($"{Alice.GetName()}, {Alice.GetPosition()}");

        Employee Optimus = new Employee();
        Optimus.SetName("Optimus Prime");
        Optimus.SetPosition("Waiter");
        Console.WriteLine($"{Optimus.GetName()}, {Optimus.GetPosition()}");
    }
}
```

#### this()



```c#
class MyClass
{
    int a, b, c;
    public MyClass()
    {
        this.a = 5423;
        Console.WriteLine("MyClass()");
    }
    public MyClass(int b) : this()
    {
        this.b = b;
        Console.WriteLine($"MyClass({b})");
    }
    public MyClass(int b, int c) : this(b)
    {
        this.c = c;
        Console.WriteLine($"MyClass({b},{c})");
    }
    public void PrintFields()
    {
        Console.WriteLine($"a : {a}, b : {b}, c : {c}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass a = new MyClass();
        a.PrintFields();
        Console.WriteLine();

        MyClass b = new MyClass(1);
        b.PrintFields();
        Console.WriteLine();

        MyClass c = new MyClass(10, 20);
        c.PrintFields();
    }
}
/*
MyClass()
a : 5423, b : 0, c : 0

MyClass()
MyClass(1)
a : 5423, b : 1, c : 0

MyClass()
MyClass(10)
MyClass(10,20)
a : 5423, b : 10, c : 20
*/
```

### 접근 한정자 ( Access Modifier )

필드는 상수를 제외허고 '무조건' 감추는 것이 좋다.

접근한정자는 감추고 싶은 것은 감추고, 보여주고 싶은 것만 보여줄 수 있도록 코드를 수식하며,  필드, 메소드를 비롯해 프로퍼티등 모든 요소에 사용할 수 있다.

접근한정자로 수식하지 않은 클래스의 멤버는 무조건 private로 접근수준이 자동으로 지정된다.

| 접근 한정자        | 설명                                                         |
| ------------------ | ------------------------------------------------------------ |
| public             | 클래스의 내부/외부 모든 곳에서 접근할 수 있다.               |
| protected          | 클래스의 외부에서는 접근할 수 없지만, 파생클래스에서는 접근이 불가능하다. |
| private            | 클래스의 내부에서만 접근할 수 있다. 파생 클래스에서도 접근이 불가능하다. |
| internal           | 같은 어셈블리에 있는 코드에서만 public으로 접근할 수 있다. 다른 어셈블리에 있는 코드에서는 private와 같은 수준의 접근성을 가진다. |
| protected internal | 같은 어셈블리에 있는 코드에서만 protected로 접근할 수 있다. 다른 어셈블리에 있는 코드에서는 private 와 같은 수준의 접근성을 가진다. |
| private protected  | 깉은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근이 가능하다. |

```c#
class WaterHeater
{
    protected int temperature;

    public void SetTemperature(int temperature)
    {
        if (temperature < -5 || temperature >42)
        {
            throw new Exception("Out of temperature range");
        }
        this.temperature = temperature;
        //temperature 필드는 protected로 수식되었으므로 외부에서 직접 접근할 수 없다.
        //public 메소드를 통해 접근해야 한다.
    }
    internal void TurnOnWater()
    {
        Console.WriteLine($"Trun on water : {temperature}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            WaterHeater heater = new WaterHeater();
            heater.SetTemperature(20);
            heater.TurnOnWater();

            heater.SetTemperature(-2);
            heater.TurnOnWater();

            heater.SetTemperature(50);
            heater.TurnOnWater();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
```

### 상속

클래스는 다른 클래스로부터 필드, 메소드 , 프로퍼티와 같은 멤버들을 상속받을 수 있다.

객체지향프로그래밍에서는 물려받는 클래스 ( 파생클래스 - Derived Class , 자식클래스) 가 유산을 물려줄 클래스 ( 기반클래스 - Base Class, 부모클래스) 를 지정한다.

파생클래스의 이름뒤에  콜론 ( : )을 붙여주고 그 뒤에 상속받을 기반 클래스의 이름을 붙여주면 된다.

```c#
class Vase{
    public void BaseMethod()
    {
        Console.WriteLine("Base Method");
    }
}
class Derived : Base //상속을 통해 BaseMethod()를 가진다.
{
}
```

파생클래스는 기반 클래스위에 새로운 멤버를 얹어 만든다. 객체를 생성할 때, 내부적으로 기반 클래스의 생성자를 호출한 뒤에 자신의 생성자를 호출하고, 객체가 소멸할 때는 반대의 순서 (파생클래스 -> 기반클래스) 로 종료자를 호출한다.

#### base 키워드

this 가 자기자신을 가리킨다면, base는 "기반 클래스"를 가리킨다.  this를 통해 자기자신의 멤버에 접근할 수 있었던 것처럼 base를 통해 기반클래스의 멤버에 접근할 수 있다.

```c#
class Base
{
    protected string Name;
    public Base(string Name)
    {
        this.Name = Name;
        Console.WriteLine($"{this.Name}.Base()");
    }
    ~Base()
    {
        Console.WriteLine($"{this.Name}.~Base()");
    }
    public void BaseMethod()
    {
        Console.WriteLine($"{this.Name}.BaseMethod()");
    }
}
class Derived : Base
{
    public Derived(string Name) : base(Name)
    {
        Console.WriteLine($"{this.Name}.Derived()");
    }
    ~Derived()
    {
        Console.WriteLine($"{this.Name}.~Derived()");
    }
    public void DerivedMethod()
    {
        Console.WriteLine($"{this.Name}.DreivedMethod()");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Base a = new Base("a");
        a.BaseMethod();

        Derived b = new Derived("b");
        b.BaseMethod();
        b.DerivedMethod();
    }
}
/*
a.Base()
a.BaseMethod()
b.Base()
b.Derived()
b.BaseMethod()
b.DreivedMethod()
*/
```

#### sealed

기반클래스는 의도하지 않은 상속이나 파생클래스의 구현을 막기위해 상속이 불가하도록 선언할수 있다. sealed 한정자로 클래스를 수식하면 '상속봉인'이 되어 (봉인된 클래스를 봉인클래스라고 한다.) 이로부터 상속받으려는 시도가 컴파일러로부터 발견되면 에러메세지가 출력된다.

### 상속 형식변환  , is, as

| 연산자 | 설명                                                         |
| ------ | ------------------------------------------------------------ |
| is     | 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool값으로 반환한다. |
| as     | 형식변환 연산자와 같은 역할을 한다. 다만 형변환연산자가 실패하는 경우 예외를 던지는 반면에 as연산자는 객체참조를 null로 만든다는 것이 다르다. |

   ```c#
class Mammal
{
    public void Nurse()
    {
        Console.WriteLine("Nurse()");
    }
}
class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Bark()");
    }
}
class Cat : Mammal
{
    public void Mew()
    {
        Console.WriteLine("Mew()");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mammal mammal = new Dog();
        Dog dog;

        if(mammal is Dog)
        {
            dog = (Dog)mammal;
            dog.Bark();
        }
        Mammal mammal2 = new Cat();
        Cat cat = mammal2 as Cat;
        if (cat != null)
            cat.Mew();

        Cat cat2 = mammal as Cat;
        if (cat2 != null)
            cat2.Mew();
        else
            Console.WriteLine("cat2 is not a cat");
    }
}/*
Bark()
Mew()
cat2 is not a cat
*/
   ```

### 오버라이딩과 다형성

다형성은 객체가 여러 형태를 가질 수 있음을 의미한다. 다형성은 하위형식 다형성( Subtype Polymorhism )의 준말로 자신으로부터 상속받아 만들어진 파생클래스를 통해 다형성을 실현한다는 뜻이다.

메소드를 오버라이드하기 위해서는 오버라이딩 할 메소드가 virtual키워드로 한정되어 있어야한다. 

private로 선언한 메소드는 오버라이딩할 수 없다.

```c#
class AmorSuite
{
    public virtual void Initialize()
    {
        Console.WriteLine("Amored");
    }
}
class IronMan : AmorSuite
{
    public override void Initialize()
    {
        base.Initialize();
        Console.WriteLine("Repulsor Rays Armed");
    }
}
class WarMachine : AmorSuite
{
    public override void Initialize()
    {
        base.Initialize();
        Console.WriteLine("Double barrel Cannon");
        Console.WriteLine("Micro-Rocket");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating AmorSuite...");
        AmorSuite amorsuite = new AmorSuite();
        amorsuite.Initialize();

        Console.WriteLine("\n Creating IronMan..");
        AmorSuite ironman = new IronMan();
        ironman.Initialize();

        Console.WriteLine("\nCreating WarMachine..");
        AmorSuite warmachine = new WarMachine();
        warmachine.Initialize();
    }
}
/*
Creating AmorSuite...
Amored

 Creating IronMan..
Amored
Repulsor Rays Armed

Creating WarMachine..
Amored
Double barrel Cannon
Micro-Rocket
*/
```

### 메소드 숨기기 ( Method Hiding )

CLR에게 기반 클래스에서 구현된 버전의 메소드를 감추고 파생클래스에서 구현된 버전만을 보여주는 것을 말한다.메소드 숨기기는 파생클래스 버전의 메소드를 new한정자로 수식함으로서 할 수 있다.

