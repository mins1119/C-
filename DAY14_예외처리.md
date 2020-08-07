# 예외처리															  	20.08.07 - 10

## try ~ catch

```c#
try
{
    //실행하고자 하는 코드
}
catch ( 예외_객체)
{
    //예외가 발생했을 때의 처리
}
catch ( 예외_객체2 )
{
    //예외가 발생했을 때의 처리
}
```

try에서 실행하고자 하는 코드를 처리하다가 예외가 던져지면 catch블록이 받아낸다. 이때 catch절은 try블록에서 던질 예외 객체와 일치해야한다. try블록에서 실행하는 코드에서 한 종류 이상의 예외를 던질 가능성이 있다면, catch블록도 어러개를 둘 수 있다. 던져진 예외가 catch의 예외와 일치하지 않으면 처리되지 않은 예외로 남게 된다.

```C#
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
/*
1
2
3
에외가 발생했습니다.: Index was outside the bounds of the array.
종료
*/
```

## System.Exception

System.Exception은 모든 예외의 조상이다. 

상속관계를 통해 모든 예외클래스는 System.Exception으로 간주할수 있고 System.Exception 형식의 예외를 받는 catch절 하나면 모든예외를 받아낼 수 있다.

하지만 상위코드에서 처리해야 할 문제마저 처리해 버려 버그를 만들수 있으니 사용에 주의해야 한다.

## Throw

```c#
try
{
    //...
    throw new Exception ("예외를 던집니다.");
}
catch (Exception e)
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

throw는 보통 문(statement)로 사용하지만 7.0부터는 식으로도 사용할 수 있다.

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

try ~ catch finally

finally절은 try ~ catch 문의 제일 마지막에 연결해서 사용하는데, 자신이 소속되어있는 try절이 실행된다면 funally절은 어떠한 경우에든 실행된다.

자원해제와 같은 뒷마무리를 할때 사용된다.