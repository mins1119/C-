<<<<<<< HEAD
# DAY10									  	20.08.03

## 프로퍼티

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

get { ... }과 set{ ... }을 일컬어 접근자라고 한다.  get 접근자는 필드로부터 값을 읽어오고 set잡근자는 필드로부터 값을 할당한다. 

set안의 value는 set 접근자의 암묵적 매개변수로 간주된다.

```c#
class MyClass
{
    private int myField;
    public int GetMyField() { return myField; }
    public void SetMyField( int NewValue ){ myField = NewValue; }
}

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

자동 구현 프로퍼티

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

=======
# DAY10									  	20.08.03

## 프로퍼티

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

get { ... }과 set{ ... }을 일컬어 접근자라고 한다.  get 접근자는 필드로부터 값을 읽어오고 set잡근자는 필드로부터 값을 할당한다. 

set안의 value는 set 접근자의 암묵적 매개변수로 간주된다.

```c#
class MyClass
{
    private int myField;
    public int GetMyField() { return myField; }
    public void SetMyField( int NewValue ){ myField = NewValue; }
}

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

자동 구현 프로퍼티

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

>>>>>>> fc74ad3f4416fa80e809cb0af9d6556f8ac21e3b
무명형식의 프로퍼티에 할당된 값은 변경이 불가능하다.