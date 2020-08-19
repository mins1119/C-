# 리플렉션과 애트리뷰트			20.08.18

## 리플렉션 ( Reflection )

객체의 형식정보( Type )를 들여다 보는 기능이다. 리플렉션을 사용하여 프로그램 실행 중에 객체의 형식 이름부터 프로퍼티 목록, 메소드 목록, 필드, 이벤트 목록까지 열어볼 수 있다.

형식의 이름이 있다면 동적으로 인스턴스를 만들고 그 인스턴스의 메소드를 호출할 수 있다.



### Object.GetType() 메소드와 Type클래스

object는 모든 데이터 형식의 조상으로, 모든 데이터 형식은 object가 가지고 있는 다음의 메소드를 물려받아 갖고있다.

- Equals()
- GetHashCode()
- GetType()
- ReferenceEquals()
- ToString()

GetType() 메소드는 객체의 형식 정보를 반환하는 기능을 한다.  Type형식의 결과를 반환하며, Type형식에는 .NET에서 사용되는 데이터 형식의 모든 정보를 담고있다. 형식 이름, 소속되어 있는 어셈블리 이름, 프로퍼티 목록, 메소드 목록, 필드 목록, 이벤트 목록, 상속하고 있는 인터페이스의 목록이 정보에 속한다.



```c#
int a = 0;

Type type = a.GetType();
FieldInfo[] fields = type.GetFields();

foreach (FieldInfo field in fields)
    Console.WriteLine($"Type : {field.FieldType.Name}, Name : {field.Name}");
```



### Type형식 메소드

| 메소드                | 반환 형식         | 설명                                             |
| --------------------- | ----------------- | ------------------------------------------------ |
| GetConstructors()     | ConstructorInfo[] | 해당 형식의 모든 생성자 목록을 반환한다.         |
| GetEvents()           | EventInfo[]       | 해당 형식의 이벤드 목록을 반환한다.              |
| GetFields()           | FieldInfo[]       | 해당 형식의 필드 목록을 반환한다.                |
| GetGenericArguments() | Type[]            | 해당 형식의 형식 매개변수 목록을 반환한다.       |
| GetInterfaces()       | Type[]            | 해당 형식이 상속하는 인터페이스 목록을 반환한다. |
| GetMembers()          | MemberInfo[]      | 해당 형식의 멤버 목록을 반환한다.                |
| GetMethods()          | MethodInfo[]      | 해당 형식의 메소드 목록을 반환한다.              |
| GetNestedTypes()      | Type[]            | 해당 형식의 내장 형식 목록을 반환한다.           |
| GetProperties()       | PropertyInfo[]    | 해당 형식의 프로퍼티 목록을 반환한다.            |



GetFields() 메소드와 GetMethods() 메소드는 System.Reflection.BindingFlags 열거형을 이용해서 검색옵션을 지정할 수 있다.

```c#
int a = 0;
Type type = a.GetType();

//public 인스턴스 필드 조회
var fields1 = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

//nonpublic 인스턴스 필드 조회
var fields2 = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

//public 정적 필드 조회
var fields3 = type.GetFields(BindingFlags.Public | BindingFlags.Static);

//nonpublic 정적 필드 조회
var fields4 = type.GetFields(BindingFlags.NonPublic | BindingFlags.Static);
```

GetFields()와 GetMethods() 등의 메소드는 BindingFlags 매개변수를 받지 않는 버전도 오버로딩이 되어있으며, 이 경우 public 멤버만 반환한다.

```c#
//int형식의 주요 정보(상속하는 인터페이스, 필드, 메소드, 프로퍼티)를 출력하는 예제
using System;
using System.Reflection;

namespace GetType
{
    class Program
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("----- Interfaces -----");
            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
                Console.WriteLine($"Name : {i.Name}");

            Console.WriteLine();
        }
        static void PrintFields(Type type)
        {
            Console.WriteLine("----- Fields -----");

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine($"Access : {accessLevel}, Type : {field.FieldType.Name}, Name : {field.Name}");
            }
            Console.WriteLine();
        }
        static void PrintMethods(Type type)
        {
            Console.WriteLine("----- Methods -----");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.Write($"Type : {method.ReturnType.Name}, Name : {method.Name}, Parameter :");
                ParameterInfo[] args = method.GetParameters();
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write($"{args[i].ParameterType.Name}");
                    if (i < args.Length - 1)
                        Console.Write(",");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void PrintProperties(Type type)
        {
            Console.WriteLine("----- Properties -----");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
                Console.WriteLine($"Type : {property.PropertyType.Name}, Name : {property.Name}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
        }
    }
}
```



**Object.GetType()메소드를 사용하지 않고 형식 정보를 얻는 법**

> Object.GetType()메소드는 반드시 객체의 인스턴스가 있어야 호출이 가능하다. Object.GetType 외에도 typeof 연산자와 Type.GetType()메소드로 형식 정보를 얻을 수 있다.
>
> typeof연산자와 Type.GetType()메소드는 똑같이 Type형식을 반환하지만, typeof연산자는 형식의 식별자 자체를 매개변수로 받고 Type.GetType()메소드는 형식의 전체 이름(네임스페이스) 을 포함한 형식이름을 매개변수로 받는다는 점이 다르다.
>
> ```c#
> int a = typeof(int);					//typeof연산자의 매개변수는 int
> Console.WriteLine(a.FullName);
> 
> Type b = Type.GetType("System.Int32");	//Type.GetType()메소드의 매개 변수는 형식의 네임스페이스를 포함하는 전체 이름
> Console.WriteLine(b.FullName);
> ```



### 객체 생성

리플렉션을 이용해서 특정 형식의 인스턴스를 만들고, 데이터를 할당하며, 메소드를 호출할 수 있다. 코드안에서 런타임에 특정 형식의 인스턴스를 만들 수 있게 되면 좀 더 동적으로 동작하도록 구성할 수 있다.



#### **인스턴스**

인스턴스를 만들고자 하는 형식의 Type객체를 매개변수로 넘기면, System.Activator클래스의 Activator.CreateInstance()메소드는 입력받은 형식의 인스턴스를 생성하여 반환한다.

```c#
object a = Activator.CreateInstance(typeof(int));
```

일반화를 지원하는 CreateInstance 도 있다. List<int>의 인스턴스를 만든다면

```c#
List<int> list = Activator.CreateInstance<List<int>>();
```



#### **프로퍼티**

PropertyInfo 객체는 SetValue() 와 GetValue() 메소드를 갖고있는데, GetValue() 를 호출하면 프로퍼티로부터 값을 읽을 수 있고, SetValue를 호출하면 프로퍼티에 값을 할당할 수 있다.

```c#
class Profile
{
    public string Name { get; set; }
    public string Phone { get; set; }
}
static void Main()
{
    Type type = typeof(Profile);
    Object profile - Activator.CreateInstance(type);
    
    PropertyInfo name = type.GetProperty("Name");
    PropertyInfo phone = type.GetProperty("Phone");
    
    name.SetValue( profile, "Alice", null);
    phone.SetValue( profile. "123-456",null);
    
    Console.WriteLine($"{name.GetValue(profile, null)}, {phone.GetValue(profile,null)}");
    
 
}
```



#### 메소드

메소드의 정보를 담는 MethodInfo 클래스에는 Invoke() 메소드가 있는데, 이 메소드를 이용하면 동적으로 메소드를 호출하는 것이 가능해진다.

```c#
class Profile
{
    public string Name { get; set; }
    public string Phone{ get; set; }
    
    public void Print()
    {
        Console.WriteLine($"{Name}, {Phone}");
    }
}
static void Main()
{
    Type type = typeof(Profile);
    Profile profile = (Profile)Activator.CreateInstance(type);
    profile.Name = "Alice";
    profile.Phone = "123-456";
    
    MethodInfo method = type.GetMethod("Print");
    method.Invoke( profile, null );
}
```



```c#
using System;
using System.Globalization;
using System.Reflection;

namespace DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = ""; phone = "";
        }
        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public void Print()
        {
            Console.WriteLine($"{name},{phone}");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("DynamicInstance.Profile");
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            object profile = Activator.CreateInstance(type, "Alice", "123-456");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "Ariel", null);
            phoneProperty.SetValue(profile, "098-765", null);

            Console.WriteLine($"{nameProperty.GetValue(profile,null)}, {phoneProperty.GetValue(profile,null)}");
        }
    }
}
```



### 형식 내보내기

프로그램 실행 중에 새로운 형식을 만들어 낼 수 있다.

동적으로 새로운 형식을 만들어내는 작업은 System.Reflection.Emit 네임스페이스에 있는 클래스들을 통해 이루어진다. 리플렉션에서의 Emit은 프로그램이 실행 중에 만들어낸 새 형식을 CLR메모리에 '내보낸다'는 의미에 가깝다.

Emit 네임스페이스에서 제공하는 클래스의 목록

| 클래스                      | 설명                                                         |
| --------------------------- | ------------------------------------------------------------ |
| AssemblyBuilder             | 동적 어셈블리를 정의하고 나타낸다.                           |
| ConstructorBuilder          | 동적으로 만든 클래스의 생성자를 정의하고 나타낸다.           |
| CustomAttributeBuilder      | 사용자 정의 애트리뷰트를 만든다.                             |
| EnumBuilder                 | 열거 형식을 정의하고 나타낸다.                               |
| EventBuilder                | 클래스의 이벤트를 정의하고 나타낸다.                         |
| FieldBuilder                | 팔드를 정의하고 나타낸다.                                    |
| GenericTypeParameterBuilder | 동적으로 정의된 형식(클래스)과 메소드를 위한 일반화 형식 매개변수를 정의하고 생성한다. |
| ILGenerator                 | MSIL(Microsoft Intermediate Language) 명령어를 실행한다.     |
| LocalBuilder                | 메소드나 생성자 내의 지역변수를 나타낸다.                    |
| MethodBuilder               | 동적으로 만든 클래스의 메소드( 또는 생성자 )를 정의하고 나타낸다. |
| ModuleBuilder               | 동적 어셈블리 내의 모듈을 정의하고 나타낸다.                 |
| OpCodes                     | ILGenerator 클래스의 멤버를 이용한 내보내기 작업에 사용할 MSIL 명령어의 필드표현을 제공한다. |
| ParameterBuilder            | 매개 변수 정보를 생성하거나 결합시킨다.                      |
| PropertyBuilder             | 형식(클래스)의 프로퍼티를 정의한다.                          |
| TypeBuilder                 | 실행중에 클래스를 정의하고 생성한다.                         |

이들은 코드의 요소를 만든다는 의미에서 ~Builder 꼴의 이름을 갖는다. 

1. AssemblyBuilder 를 이용해서 어셈블리를 만든다.
2. ModuleBuilder를 이용해서 1.에서 생성한 어셈블리 안에 모듈을 만들어 넣는다.
3. TypeBuilder를 2.에서 생성한 모듈안에 클래스(형식)을 만들어 넣는다.
4. 3. 에서 생성한 클래스 안에 메소드(MethodBuilder 이용)아 프로퍼티(PropretyBuilder)를 만들어 넣는다.
5. 4. 에서 생성한 것이 메소드라면, ILGenerator를 이용해서 메소드안에 CPU가 실행할 IL명령들을 넣는다.

[ 어셈블리 ] -> [ 모듈 ] -> [ 클래스 ] -> [ 메소드 ] or [ 프로퍼티 ]



```c#
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest_Net
{
    class Program
    {
        static void Main()
        {
            AssemblyBuilder newAssembly = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod("Calculate", MethodAttributes.Public, typeof(int), new Type[0]);

            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1);

            for (int i = 2; i <= 100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);
            }
            generator.Emit(OpCodes.Ret);
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(Calculate.Invoke(sum1To100, null));

        }
    }
}
```







## 애트리뷰트 ( Attribite )

코드에 대한 부가정보를 기록하고 읽을 수 있는 기능

애트리뷰트를 이용해서 클래스나 구조체, 메소드, 프로퍼티 등에 데이터를 기록해두면 C#컴파일러나 프로그램이 이 정보를 읽어 사용할 수 있다.

```c#
[ 애트리뷰트_이름( 애트리뷰트_매개 변수 ) ]
public void MtMethod()
{
    //...
}
```

> **메타데이터 ( Metadata )**
>
> 데이터의 데이터를 말한다. c#의 코드도 데이터지만 이 코드에 대한 정보 역시 데이터이다. 리플렉션이나 애트리부트를 통해 얻는 정보를 메타데이터라고 한다.



```c#
//새 라이브러리를 배포하면서 이전 메소드의 보안경고를 표시해야 하는 경우
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAttribute
{
    class MyClass
    {
        [Obsolete("OldMethod()는 폐기 되었습니다. NewMethod()를 이용하세요ㅡ")]
        public void OldMethod()
        {
            Console.WriteLine("I am Old");
        }
        public void NewMethod()
        {
            Console.WriteLine("I am New");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
        }
    }
}
```

![BasicAttribute](https://user-images.githubusercontent.com/40557177/90581793-0ed96c80-e207-11ea-831f-6fd035fe8ffb.png)

### 호출자 정보 애트리뷰트

호출자 정보 ( Caller Information )는 메소드의 매개변수에 사용되며 메소드의 호출자 이름, 호출자 메소드가 정의되어있는 소스 파일 경로, 소스파일내의 행번호를 알 수 있다.

| 애트리뷰트                | 설명                                                         |
| ------------------------- | ------------------------------------------------------------ |
| CallerMemberNameAttibute  | 현재 메소드를 호출한 메소드 또는 프로퍼티의 이름을 나타낸다. |
| CallerFilePathAttribute   | 현재 메소드가 호출된 소스파일 경로를 나타낸다. 이 때 경로는 소스코드를 컴파일할 때의 전체 경로를 나타낸다. |
| CallerLineNumberAttribute | 현재 메소드가 호출된 소스파일 내의 행(Line) 번호를 나타낸다. |

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallerInfo
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file ="",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file},(Line : {line}),{member} : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("즐거운 프로그래밍");
        }
    }
}
/*
CallerInfp\Program.cs,(Line : 24),Main : 즐거운 프로그래밍
*/
```

### 사용자 지정 애트리뷰트

모든 애트리뷰트는 System.Attribute클래스로부터 상속받아 만들어진다.

#### System.AttributeUsage

```c#
[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]

[System.AttributeUsage(System.AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]

```

- System.AttributeUsage의 첫 번째 매개변수
  - 선언하고 있는 애트리뷰트의 설명대상이 무엇인지를 나타낸다. 이것을 Attribute Target이라고 하며, 코드 요소는 다음과 같다. 논리연산자를 사용하여 결합할 수 있다.

- System.AttributeUsage의 두 번째 매개변수
  - 애트리뷰트의 중복 사용여부를 나타낸다. true이면 여러번 사용할 수 있다.

| Attribute Target | 설명                                                         |
| ---------------- | ------------------------------------------------------------ |
| All              | 이 표의 나머지 모든 요소                                     |
| Assembly         | 어셈블리                                                     |
| Module           | 모듈                                                         |
| Interface        | 인터페이스                                                   |
| Class            | 클래스                                                       |
| Struct           | 구조체                                                       |
| ClassMembers     | 클래스 안에 생성된 클래스나 구조체를 포함한 클래스의 모든 멤버 |
| Constructor      | 생성자                                                       |
| Delegate         | 대리자                                                       |
| Enum             | 열거형                                                       |
| Event            | 이벤트                                                       |
| Field            | 필드                                                         |
| Property         | 프로퍼티                                                     |
| Method           | 메소드                                                       |
| Parameter        | 메소드의 매개변수                                            |
| ReturnValue      | 메소드의 반환 값                                             |





```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First Release";
        }
        public string GetProgrammer()
        {
            return programmer;
        }
    }
    [History("Sean",version =0.1,changes = "2020-05-07 Created class stub")]
    [History("Bob",version =0.2,changes = "2020-08-07 Added Fnnc() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("Myclass change History...");

            foreach(Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                    Console.WriteLine($"Ver : {h.version}, Programmer : {h.GetProgrammer()}, changes : {h.changes}");
            }
        }
    }
}
/*
Myclass change History...
Ver : 0.1, Programmer : Sean, changes : 2020-05-07 Created class stub
Ver : 0.2, Programmer : Bob, changes : 2020-08-07 Added Fnnc() Method
*/
```

