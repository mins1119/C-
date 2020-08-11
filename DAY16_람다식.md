# 람다식												  	20.08.11

## 람다식 ( Lambda Expression )

익명메소드를 만들기 위해 사용된다. 람다식으로 만드는 익명메소드는 무명 함수( Anonymous Function )라고 한다.

```c#
매개변수목록 => 식
    
//=> 사용   
delegate int Calculate(int a, int b);
    //
 ...
static void Main(string[] args)
{
    Calcultate calc = (int a, int b) => a + b
}
//형식 유추 사용 
delegate int Calculate(int a, int b);
    //
 ...
static void Main(string[] args)
{
    Calcultate calc = (a, b) => a + b
}
```

**형식 유추( Type Inference )**

매개변수의 형식을 제거할 수 있다.

```C#
//람다식과 대리자의 비교. 람다식이 훨씬 간편하다
delegate int Calculate(int a, int b);
    //
 ...
static void Main(string[] args)
{
    Calcultate calc = (a, b) => a + b
}


delegate int Calculate(int a, int b);
//...
static void Main(string[] args)
{
    Calculate cla = delegate(int a, int b)
    {
        return a + b;
    }
    
}
```

```c#
using System;

namespace SimpleLambda
{
    class Program
    {
        delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            Console.WriteLine($"{3} + {4} = {calc(3,4)}");
        }
    }
}
/*
3 + 4 = 7
*/
```

## 문장 형식의 람다식

=> 연산자의 오른편에 식 대신 문장을 사용할 수 있다.

```c#
(매개변수목록) => {
    			 문장1;
    			 문장2;
    			 문장3;
                 ...
}
```

```c#
using System;
using System.Globalization;

namespace StatementLambda
{
    class Program
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };
            Console.WriteLine(concat(args));
        }
    }
}
```

## Func,  Action

익명 메소드와 무명 함수는 코드를 보다 간결하게 만들어주는 요소이지만, 매번 별개의 대리자를 선언해야한다.

번거로움을 줄이기 위해 .NET 프레임워크에는 Func와 Action 대리자가 선언되어있다.

Func 대리자는 결과를 반환하는 메소드를 참조하기 위해, Action 대리자는 결과를 반환하지 않는 메소드를 참조한다.

### Func 대리자

결과를 반환하는 메소드를 참조한다. .NET 프레임워크에는 모두 17가지 버전의 대리자가 준비되어 있다.

```c#
public delegate TResult Func<out TResult>()
public delegate TResult Func<in T, out TResult>(T arg)
public delegate TResult Func<in T1,in T2, out TResult>(T1 ar1g, T2 arg2)
public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3)
...
public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T15, in T15, in T16 ,out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
```

```c#
using System;
using System.Security.Cryptography.X509Certificates;

namespace FuncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            Console.WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2(4) : {func2(4)}");

            Func<double,double,double> func3 = (x, y) => x / y;
            Console.WriteLine($"func3(22,7) : {func3(22, 7)}");

        }
    }
}
/*
func1() : 10
func2(4) : 8
func3(22,7) : 3.142857142857143
*/
```

### Action 대리자

반환형식이 없는 메소드를 참조한다. .NET 프레임워크에는 모두 17가지 버전의 대리자가 준비되어 있다.

```c#
public delegate void Action<>()
public delegate void Action<in T>(T arg)
public delegate void Action<in T1,in T2>(T1 ar1g, T2 arg2)
public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3)
...
public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T15, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16)
```

Action 대리자는 결과를 반환하지 않고, 일련의 작업을 수행하는 것이 목적이기 때문에 형식매개변수가 모두 입력매개변수를 위해 선언되어 있다.



```c#
using System;

namespace ActionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine($"result : {result}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1,T2>({x},{y} : {pi}");
            };
            act3(22.0, 7.0);

        }
    }
}
/*
Action()
result : 9
Action<T1,T2>(22,7 : 3.142857142857143
*/
```

## 식 트리 ( Expression Tree )

### 트리

트리는 노드로 구성되며,각 노드는 부모 - 자식 관계로 연결된다.

노드 중 최상위 노드를 뿌리가 되는 루트라고하며, 루트로부터 뻗어나온 노드 중 가장 끝에 있는 노드를 잎(Leaf)노드, 또는 단말(Terminal)노드라고 한다.

일반적인 트리구조에서는 부모 노드가 여러개의 자식노드를 가질 수 있지만, 식 트리는 한 부모노드가 단 두 개만의 자식 노드를 가질 수 있는 이진트리( Binary Tree )이다.



 ![tree](https://user-images.githubusercontent.com/40557177/89857792-f6020300-dbd7-11ea-9f7c-aea0df03f8b0.png)



### 식 트리

한 부모노드가 단 두 개만의 자식 노드를 가질 수 있는 이진트리( Binary Tree )이다.

식 트리에서 연산자는 부모노드가 되며, 피연산자는 자식노드가 된다.

4*1에서 *는 부모노드, 4와1은 *의 자식노드가 되었다. 식 트리로 표현된 식은 트리의 잎 노드부터 계산해서 루트까지 올라가면 전체 식의 결과를 얻을 수 있다.



식트리 자료구조는 컴파일러나 인터프리터를 제작하는데 응용된다. 컴파일러는 프로그래밍 언어의 문법을 따라 작성된 코드를 분석해서 식 트리로 만든 후 이를 바탕으로 실행파일을 만든다. 완전한 컴파일러는 아니지만, c#은 코드안에서 직접 식 트리를 조립하고 컴파일해서 사용할 수 있는 기능을 제공한다. (= 동적으로 무명함수를 만들어 사용할 수 있다.)

식트리는 코드를 '데이터'로서 보관할 수 있고, 파일에 저장하거나 네트워크를 통해 다른 프로세스에 전달할 수도 있다.

코드를 담고닜는 식 트리 데이터를 데이터베이스 서버에 보내 실행시킬 수도 있다.

### Expression 클래스와 파생클래스

 식 트리를 다루는데 사용이 된다. .NET 프레임워크의 System.Linq.Expressions 네임스페이스 안에 있다.

**Expression**

식 트리를 구성하는 노드를 표현한다. 이는 파생클래스들이 식 트르의 각 노드를 표현할 수 있게 한다. 파생클래스들의 객체를 생성한다.

Expression 클래스는 abstract로 선언되어 자신의 인스턴스를 만들순 없지만, 파생클래스의 인스턴스를 생성하는 정적 팩토리 메소드를 제공한다.

> 팩토리 메소드 ( Factory Method )
>
> 클래스의 인스턴스를 생성하는 메소드를 카리킨다. 생성자 메소드로 충분하지 않을 때, 객체의 생성에 복잡한 논리가 필요한 경우 객체 생성과정을 별도의 메소드에 구현해 놓으면 코드의 복잡도를 상당히 줄일 수 있다.

**Expression 파생클래스**

| **Expression 파생클래스**  | 설명                                                         |
| -------------------------- | ------------------------------------------------------------ |
| BinaryExpression           | 이항 연산자를 갖는 식을 표현한다.                            |
| BlockExpression            | 변수를 정의할 수 있는 식을 갖는 블록을 표현한다.             |
| ConditionalExpression      | 조건 연산자가 있는 식을 나타낸다.                            |
| ConstantExpression         | 상수가 있는 식을 나타낸다.                                   |
| DefaultExpression          | 형식이나 비어있는 식의 기본값을 표현한다.                    |
| DynamicExpression          | 동적 작업을 나타낸다.                                        |
| GotoExpression             | 점프문을 나타낸다.                                           |
| IndexExpression            | 배열의 인덱스 참조를 나타낸다.                               |
| InvocationExpression       | 대리자나 람다식 호출을 나타낸다.                             |
| LabelExpression            | 레이블을 나타낸다.                                           |
| LambdaExpressiom           | 람다식을 나타낸다.                                           |
| ListInitExpression         | 켈렉션 이니셜라이저가 있는 생성자 호출을 나타낸다.           |
| LoopExpression             | 무한 루프를 나타낸다. break문을 사용하여 종료할수 있다.      |
| MemberExpression           | 객체의 필드나 속성을 나타낸다.                               |
| MemberInitExpression       | 생성자를 호출하고 새 객체의 멤버를 초기화하는 동작을 나타낸다. |
| MethodCallExpression       | 메소드 호출을 나타낸다.                                      |
| NewArrayExpression         | 새 배열과 생성자 초기화를 나타낸다.                          |
| NewExpression              | 생성자 호출을 나타낸다.                                      |
| ParameterExpression        | 명명된 매개변수를 나타낸다.                                  |
| RuntimeVariablesExpression | 변수에 대한 런타임 읽기/쓰기 권한을 제공한다.                |
| SwitchExpression           | 다중 선택 제어 식을 나타낸다.                                |
| TryExpression              | try ~ catch ~ finally 블록을 나타낸다.                       |
| TypeBinaryExpression       | 형식 테스트를 비롯한 형식(Type)과 식(Expression)의 연산을 나타냅니다. |
| UnaryExpression            | 단항연산자를 갖는 식을 나타낸다.                             |

```c#
using System;
using System.Linq.Expressions;

namespace UsingExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //1*2+(x-y)
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);

            Expression leftExp = Expression.Multiply(const1, const2);

            Expression param1 = Expression.Parameter(typeof(int));
            Expression param2 = Expression.Parameter(typeof(int));

            Expression rightExp = Expression.Subtract(param1, param2);

            Expression exp = Expression.Add(leftExp, rightExp);
			//람다식클래스의 파생클래스인 Expression<TDelegate>를 사용했다.
            Expression<Func<int, int, int>> expression 
                = Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>
                (exp, new ParameterExpression[] { (ParameterExpression)param1, (ParameterExpression)param2 });

            Func<int, int, int> func = expression.Compile();

            //x=7, y=8
            Console.WriteLine($"1*2+({7}-{8}) = {func(7,8)}");

        }
    }
}
/*
1*2+(7-8) = 1
*/
```



람다식을 사용하면 더 간단하게 식 트리를 만들수 있다.  하지만 동적으로 식 트리를 만들기는 어려워진다. 

Expression 형식은 불변이기 때문에 한번 인스턴스가 만들어진 후에는 변경하기가 힘들기 때문이다.

```c#
using System;
using System.Linq.Expressions;

namespace ExpressionTreeViaLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression =
                (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            Console.WriteLine($"1*2 + ({7}-{8}) = {func(7, 8)}");
        }
    }
}
/*
1*2 + (7-8) = 1
*/
```

##  식으로 이루어지는 멤버

#### 식 본문 멤버( Expression-Bodied Member )

메소드 , 속성(인덱서), 생성자, 종료자는 클래스의 멤버로서 본문이 중괄호{}로 이루어져있다. 이러한 멤버의 본문을 식만으로 구현할수 있고, 식으로 구현된 멤버를 식 본문 멤버라고 한다.

```c#
멤버 => 식;
```



```c#
//1. FriendList 클래스 선언
class FriendList
{
    private List<string> = new List<string>();
}
//2. 식 멤버 추가 - Add()와 Remove()메소드는 각각 list.Add()메소드를 호출하는 식과 list.Remove()를 호출하는 식으로 이루어져 있다.
class FriendList
{
    //...
    public void Add(string name) => list.Add(name);
    public void Remove(string name) => list.Remove(name);
}
//3. 생성자와 종료자 식 구현
class FriendList
{
    //...
    public FriendList() => Console.WriteLine("FriendList()");
    ~FriendList() => Console.WriteLine("~FriendList");
}
//4-1. 읽기전용속성과 인덱서
class FriendList
{
    //...
    public int Capacity => list.Capacity; //읽기전용 속성
    public string this[int index] => list[index]; //읽기전용 인덱서
}
//4-2. 읽기/쓰기 모두 가능한 속성
class
{
    //..
    public int Capacity
    {
        get => list.Capacity;
        set => list.Capacity = value;
    }
    public string this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }
}
```

```c#
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpressionBodiedMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }
        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Alice");
            obj.Add("Optimus");
            obj.Add("Bumblebee");
            obj.Add("Thundercracker");
            obj.Remove("Thundercracker");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Jazz";
            obj.PrintAll();
        }
    }
}
/*
FriendList()
Alice
Optimus
Bumblebee
4
10
Alice
Jazz
Optimus
Bumblebee
*/
```

