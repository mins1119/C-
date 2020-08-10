# 예외처리												  	20.08.07 - 10

**예외( Exception )**

프로그래머가 생각하는 시나리오에서 벗어나지 않는 사건

**예외처리( Exception Handling )**

예외가 프로그램의 오류나 다운으로 이어지지 않도록 적절하게 처리하는 것



## try ~ catch

```c#
try
{
    //실행하고자 하는 코드
}
catch(예외 객체1)
{
    //예외가 발생했을 때의 처리
}
catch(예외 객체)
{
    //예외가 발생했을 때의 처리
}
```



try절의 코드 블록에는 예외가 일어나지 않을 경우에 실행되어야할 코드들이 들어가고, catch절에는 예외가 발생했을 때의 코드가 들어간다.

try에서 예외가 던져지면 이를 catch절이 받아낸다. 때문에 try블록에서 던질예외 객체와 형식이 같아야한다. 만약 try블록에서 실행하는 코드에서 여러개의 예외를 던질 가능성이 있다면, 이를 받아낼 catch블록도 여러개를 둘 수 있다.

```c#
using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch( IndexOutOfRangeException e)
            {
                Console.WriteLine($"에외가 발생했습니다.: {e.Message}");
            }
            Console.WriteLine("종료");
        }
    }
}

```

## System.Exception

System.Exception은 모든 예외의 조상이다.  C#의 모든 예외 클래스는 반드시 이 클래스로부터 상속받아야 한다.

```C#
try
{}
catch( IndexOutOfRange e )
{
    //...
}
catch( DivideByZeroException e )
{
    //...
}

try{}
catch(Exception e)
{
    //...
}
```

상속관계로 인해 여러개의 catch블록을 System.Exception 클래스 하나로 처리 할 수 있다.

하지만 Syste.Exception 형식은 계산되지 않은 예외까지 처리해 버릴수 있고, 만약 이가 상위코드에서 처리되어야할 문제라면 버그를 발생시키는 요인이 된다.

## 예외 던지기

throw를 사용해 예외를 던질 수 있다. 던져진 예외 객체는 catch문을 통해 받는다.

```c#
try
{
    //...
    throw new Exception("예외를 던집니다.");
}
catch( Exception e )
{
    Console.WriteLine( e.Message );
}
```

```c#
using System;

namespace Throw
{
    class Program
    {
        static void DoSomething(int arg)
        { 
                if (arg < 10)
                    Console.WriteLine($"arg : {arg}");
                else
                    throw new Exception("arg가 10보다 큽니다.");
            }
        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(3);
                DoSomething(5);
                DoSomething(11);
                DoSomething(13);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*
arg : 1
arg : 3
arg : 5
arg가 10보다 큽니다.
*/
```

throw는 문(statement)으로 사용하지만 7.0부터는 식(expression)으로도 사용할 수 있다.

```c#
int? a = null;
int b = a ?? throw new ArgumentNullException(); //a가 null이므로 throw문이 실행된다.
```

```c#
int[] array = new[] {1,2,3};
int index = 4;
int value = array[ index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
```

```c#
using System;
using System.Net.Http.Headers;

namespace ThrowExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int[] array = new[] { 1, 2, 3, 4 };
                int index = 4;
                int value = array[ index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException() ];
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
/*
System.ArgumentNullException: Value cannot be null.
   at ThrowExpression.Program.Main(String[] args) in C:\Users\User\Desktop\mskang\day14\ThrowExpression\Program.cs:line 13
System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at ThrowExpression.Program.Main(String[] args) in C:\Users\User\Desktop\mskang\day14\ThrowExpression\Program.cs:line 24
*/
```

## try ~ catch , finally

```c#
try
{
    dbconn.Open();	//dbconn은 데이터 베이스 커넥션
    //...
    dbconn.Close();
}
catch(..Exception e)
{
    //...
}



try
{
    dbconn.Open();	//dbconn은 데이터 베이스 커넥션
    //...
}
catch(..Exception e)
{
    //...
}
finally
{
    dbconn.Close();
}
```

finally절은 try ~ catch 문의 제일 마지막에 연결해서 사용하는데, 주로 뒷정리 코드를 넣어둔다.

finally절은 자신이 소속되어 있는 try절이 실행된다면 어떤 경우라도 실행된다. return throw와 같이 코드의 흐름을 외부로 옮겨도 무조건 실행된다.

```c#
using System;

namespace Finally
{
    class Program
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide()시작");
                return divisor / dividend;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("제수를 입력하세요:");
                string temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);
                
                Console.WriteLine("피제수를 입력하세요:");
                temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.WriteLine($"{divisor} / {dividend} = {Divide(divisor, dividend)}");
            }
            catch(FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
/*
제수를 입력하세요:
4
피제수를 입력하세요:

에러 : Input string was not in a correct format.
프로그램을 종료합니다.

제수를 입력하세요:
15
피제수를 입력하세요:
5
Divide()시작
Divide() 끝
15 / 5 = 3
프로그램을 종료합니다.

제수를 입력하세요:
15
피제수를 입력하세요:
0
Divide()시작
Divide() 예외 발생
Divide() 끝
에러 : Attempted to divide by zero.
프로그램을 종료합니다.
*/
```

finally 블록 안에서도   try~catch문을 사용할 수 있다.



## 사용자 정의 예외 클래스

모든 예외 객체는 System.Exception을 상석 받아야 한다. 이 규칙에 의거하여 Exception 클래스를 상속하면 예외클래스를 만들수 있다.

특별한 데이터를 담아서 예외처리루틴에 추가정보를 제공하고 싶다거나, 예외 상황을 더 잘 설명하고 싶을 때 사용한다.

```c#
class MyException : Exception
{
    //...
}
```

```c#
using System;
using System.Reflection.Metadata.Ecma335;

namespace MyException
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException() { }
        public InvalidArgumentException(string message) : base(message) {}
        public object Argument { get; set; }
        public string Range { get; set; }
    }
    class Program
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            foreach(uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException() { Argument = arg, Range = "0~255" };
            }
            return (alpha << 24 & 0xFF000000) |
                (red << 16 & 0x00FF0000) |
                (green << 8 & 0x0000FF00) |
                (blue   & 0x0000FF);
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
                Console.WriteLine("0x{0:X}", MergeARGB(1, 65, 191, 128));
                Console.WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));
            }
            catch(InvalidArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument : {e.Argument},Range : {e.Range}");
            }
        }
    }
}
/*
0xFF6F6F6F
0x141BF80
Exception of type 'MyException.InvalidArgumentException' was thrown.
Argument : 300,Range : 0~255
*/
```



## 예외 필터

6.0부터 예외 객체에 제약 사항을 명시해서 해당 조건을 명시하는 예외객체에 대해서만 예외 처리 코드를 실행할 수 있다.

catch()문 뒤에 when 키워드를 이용해서 제약조건을 기술하면 된다.

## StackTrace