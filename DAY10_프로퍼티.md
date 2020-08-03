# DAY10									  	20.08.03

## 프로퍼티

### 프로퍼티

객체 지향언어는 객체의 데이터가 의도치 않게 오염되는 것을 막고다 private 나 protected 와 같은 접근한정자를 이용해서 클래스 내의 필드를 외부에서 보이지 않게 감추고, 이 필드에 접근하는 get / set 메소드를 public으로 지정한다. 

C#의 프로퍼티는 get / set 메소드를 편리하게 대체할 수 있다.



**프로퍼티 선언**

```c#
class 클래스이름{
    데이터형식 필드이름;
    접근한정자 데이터형식 프로퍼티이름;
    {
        get
        {
            return 필드이름;
        }
        set
        {
            필드이름 = value;
        }
    }
}
```

get { ... }과 set{ ... }을 일컬어 접근자라고 한다.  get 접근자는 필드로부터 값을 읽어오고 set접근자는 필드로부터 값을 할당한다. 

set안의 value는 set 접근자의 암묵적 매개변수로 간주된다.

```c#
class MyClass
{
    private int myField;
    public int GetMyField() { return myField; }
    public void SetMyField( int NewValue ){ myField = NewValue; }
}
//위의 메소드를 아래의 프로퍼티로 바꿀수 있다.
class MyClass
{
    private int myField;
    pulbic int MyField
    {
        get
        {
            return myField;
        }
        set
        {
            myField = value;
        }
    }
}
```

프로퍼티에서 set 접근자를 구현하지 않으면 해당  프로퍼티는 쓰기 불가(읽기전용)가 된다.

쓰기전용 프로퍼티도 만들수 있겠지만 용도와 동작결과를 상세히 설명할 수 있어야 한다. 그렇지 않으면 관리하기 어려운 코드가 될 가능성이 높다.

```c#
using System;
using System.Xml;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "민서";
            birth.Birthday = new DateTime(1000, 01, 01);
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
/*
Name : 민서
Birthday : 1000-01-01
Age : 1021
*/
```

#### 자동 구현 프로퍼티

C#3.0 부터 가능한 자동구현 프로퍼티. 필드를 선언할 필요가 없고 그저 get접근자와 set접근자 뒤에 세미콜론을 붙여주면 된다.

c#7.0 부터 자동 구현 프로퍼티를 선언과 동시에 초기화 시켜줄수 있다.

```c#
//자동 구현 프로퍼티
public class NameCard
{
    public string Name
    {
        get; set;
    }
    public string PhoneNumber
    {
        get; set;
    }
}
//자동 구현 프로퍼티 선언 동시 초기화
public class NameCard
{
    public string Name{ get; set; } = "UnKnown";
    public string PhoneNumber{ get; set; } = "000-0000";
}
```



```c#
using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "UnKnown";
        public DateTime Birthday { get; set; } = new DateTime(1,1,1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday}");
            Console.WriteLine($"Age : {birth.Age}");

            birth.Name = "민서";
            birth.Birthday = new DateTime(1000,01,01);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday}");
            Console.WriteLine($"Age : {birth.Age}");

        }
    }
}
/*
Name : UnKnown
Birthday : 0001-01-01 오전 12:00:00
Age : 2020
Name : 민서
Birthday : 1000-01-01 오전 12:00:00
Age : 1021
*/
```



### 프로퍼티와 생성자

객체를 생성할 때 각 필드를 초기화하는 방법

```c#
클래스이름 인스턴스 = new 클래스이름()
{
    프로퍼티 = 값,
    플로퍼티 = 값,
    프로퍼티 = 값
}
```

객체 생성시에 모든 프로퍼티가 올 필요는 없다. 초기화할 프로퍼티만 넣으면 된다.

```c#
using System;

namespace ConstructorProperty
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "민서",
                Birthday = new DateTime(1000, 01, 01)
            };
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}
/*
Name : 민서
Birthday : 1000-01-01 오전 12:00:00
Age : 1021
*/
```



### 무명형식( Anonymous Type )

무명형식은 형식의 선언과 동시에 인스턴스를 할당한다. 때문에 인스턴스를 만들고 다시 사용하지 않을 때 요긴하다.

```c#
var myInstance = new { Name = "Alice", Age = "9"};
Console.WriteLine(myInstance.Name , myInstance.Age);
```

```c#
var a = new { Name = "Alice", Age = "9" };
Console.WriteLine($"Name : {a.Name} , Age : {a.Age}");

var b = new { Subject = "math", Scores = new int[] { 90, 20, 70, 40 } };
Console.Write($"Subject : {b.Subject},Scores : ");
foreach (var score in b.Scores)
    Console.Write($"{score} ");

Console.WriteLine();
/*
Name : Alice , Age : 9
Subject : math,Scores : 90 20 70 40
*/
```

 무명형식의 프로퍼티에 할당된 값은 변경이 불가능하다.



### 인터페이스와 프로퍼티

```c#
interface 인터페이스 이름
{
    public 형식 프로퍼티이름1
    {
        get; set;
    }
    public 형식 프로퍼티이름2{
        get; set;
    }
}
```

```c#
using System;
using System.Dynamic;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }
        string Value
        {
            get;
            set;
        }
    }
    class NamedValue : INamedValue
    {
        public string Name { 
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "Alice" };
            NamedValue height = new NamedValue()
            { Name = "키", Value = "160" };
            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "50" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");

        }
    }
}

```



### 추상 프로퍼티( Abstract Property )

인터페이스처럼 구현되지 않은 프로퍼티를 가질 수 있다.

```c#
abstract class 추상 클래스 이름
{
    abstract 데이터형식 프로퍼티 이름
    {
        get;
        set;
    }
}
```

```c#
using System;

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return string.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate 
        { 
            get; 
            set; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {ProductDate = new DateTime(2020,08,03)};
            Console.WriteLine($"Product : {product_1.SerialID}, Product Date : {product_1.ProductDate}");

            Product product_2 = new MyProduct()
            { ProductDate = new DateTime(2020, 07, 20) };
            Console.WriteLine($"Product : {product_2.SerialID}, Product Date : {product_2.ProductDate}");
        }
    }
}
/*
Product : 00000, Product Date : 2020-08-03 오전 12:00:00
Product : 00001, Product Date : 2020-07-20 오전 12:00:00
*/
```









```c#
using System;

namespace test1
{
    class NameCard
    {
        public int Age
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();
            MyCard.Name = "Alice";
            MyCard.Age = 15;

            Console.WriteLine($"이름 : {MyCard.Name}");
            Console.WriteLine($"나이 : {MyCard.Age}");
        }
    }
}

```

