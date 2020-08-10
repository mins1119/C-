# 대리자와 이벤트													  	20.08.10

## 이벤트 기반 프로그래밍 ( Event Driven Programming )

발생하는 이벤트에 반응하도록 프로그래밍하는 것

## 대리자( Delegate )

대리자는 메소드에 대한 참조이다. 대리자에 메소드의 주소를 할당 한 후 대리자를 호출하면 대리자는 메소드를 호출해준다. 인스턴스가 아닌 형식(Type)이다.

```c#
한정자 delegate 반환 형식 대리자이름 ( 매개_변수_목록 );
```



```c#
delegate int MyDelegate(int a, int b);

//Plus 와 Minus 모두 MyDelegate대리자의 반환 형식과 매개 변수를 따르고 있다.
int Plus(int a, int b)
{
    return a + b;
}
int Minus(int a, int b)
{
    return a - b;
}

//대리자는 형식이므로 인스턴스를 따로 만들어야 한다. new 연산자사용
MyDelegate Callback;
Callback = new MyDelegate( Plus );
Console.WriteLine(Callback( 3, 7 ));

Callback = new MyDelegate( Minus );
Console.WriteLine(Callback( 7, 5 ));
```

콜백 구현 과정

1. 대리자를 선언한다.
2. 대리자의 인스턴스를 생성한다. 인스턴스를 생성할 때는 대리자가 참조할 메소드를 매개변수로 넘긴다.
3. 대리자를 호출한다.



```c#
using System;
using System.IO;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);
    class Calculator 
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 7));

            Callback = new MyDelegate(Calc.Minus);
            Console.WriteLine(Callback(7,5));
        }
    }
}

```

대리자는 메소드에 대한 참조이므로, 메소드를 참조할 대리자를 매개변수로 받도록 할 수 있다.

1. 대리자를 선언한다.

```c#
delegate int Compare(int a, int b);
```

2. 대리자가 참조할 메소드를 작성한다.

```C#
static int AscendCompare(int a, int b)
{
    if(a > b)
        return 1;
    else if(a == b)
        return 0;
    else
        return -1;
}
```



3. 메소드를 참조할 대리자를 매개변수로 받는 메소드를 작성한다.

```c#
static void BubbleSort(int[] DataSet, Compare Comparer)
{
    int i = 0;
    int j = 0;
    int temp = 0;
    
    for( i = 0; i<DataSet.Length - (i+1); i++)
    {
        if(Comparer(DataSet[j], DataSet[j+1]) > 0)
        {
            temp = DataSet[j+1];
            DataSet[j+1] = DataSet[j];
            DataSet = temp;
        }
    }
}
```

```c#
using System;

namespace UsingCallback
{
    delegate int Compare(int a, int b);
    class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for(j=0;j<DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 2, 8, 4, 9 };

            Console.WriteLine("Sroting ascending...");
            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}");

            int[] array2 = { 4, 6,7, 8, 4, 5 };

            Console.WriteLine("Sroting descending...");
            BubbleSort(array2, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]}");
        }
    }
}
```

## 일반화 대리자

대리자는 보통의 메소드뿐 아니라 일반화 메소드도 참조할 수 있다. 일반화 대리자의 경우 일반화 메소드를 참조할 수 있도록 형식 매개 변수를 사용해서 선언되어야 한다.

```C#
delegate int Compare<T>(T a, T b);
```

```c#
using System;
using System.Collections;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Json;

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }
        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for(j=0; j< DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 6, 8, 4, 20 };
            Console.WriteLine("Sorting Ascending");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length;i++)
                Console.WriteLine($"{array[i]}");

            string[] array2 = { "abc", "mhe", "rew", "tbr", "btr", "kurt", "fdw" };

            Console.WriteLine("Sorting Descending..");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine($"{array2[i]}");
        }
    }
}
/*
Sorting Ascending
2
3
4
6
8
20
Sorting Descending..
tbr
rew
mhe
kurt
fdw
btr
abc
*/
```

## 대리자 체인

하나의 대리자는 여러 개의 메소드를 동시에 참조할 수 있다.

```c#
delegate void ThereIsFire( string location );
void Call119( string location )
{
    Console.WriteLine("fire {0}",location);
}
void ShoutOut( string location )
{
    Console.WriteLine(" Fire!!!{0}",location);
}
void Escape( string location )
{
    Console.WriteLine("get out from {0}",location);
}
```

대리자와 대리자의 형식에 맞춘 메소드들은 += 연산자,  Combine() 을 이용해서 결합할 수 있다.

```c#
ThereIsFire Fire = new ThereIsFire( Call119 );
Fire += new ThereIsFire( ShoutOut );
Fire += new ThereIsFire( Escape );
```



```c#
using System;
using System.Diagnostics.Tracing;

namespace DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }
    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomethingHappened(string message)
        {
            Console.WriteLine($"{name}.Something Happened : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("EventListner1");
            EventListener listener2 = new EventListener("EventListner2");
            EventListener listener3 = new EventListener("EventListner3");

            notifier.EventOccured += listener1.SomethingHappened;
            notifier.EventOccured += listener2.SomethingHappened;
            notifier.EventOccured += listener3.SomethingHappened;
            notifier.EventOccured("You've got mail");
            Console.WriteLine();
            notifier.EventOccured -= listener2.SomethingHappened;
            notifier.EventOccured("Download Complete");
            Console.WriteLine();
            notifier.EventOccured = new Notify(listener2.SomethingHappened)
                                    + new Notify(listener3.SomethingHappened);
            notifier.EventOccured("Nuclear launch detected");
            Console.WriteLine();
            Notify notify1 = new Notify(listener1.SomethingHappened);
            Notify notify2 = new Notify(listener2.SomethingHappened);
            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire");
            Console.WriteLine();
            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG");
        }
    }
}
```

## 익명메소드( Anonymous Method )

delegate메소드를 이용하여 선언한다.

자신이 참조할 대리자의 형식과 동일한 형식으로 선언되어야 한다.

대리자가 참조할 메소드를 넘겨야 할 일이 생겼는데, 이 메소드가 두 번 다시 사용될 일이 없다고 판단되면 익명메소드를 사용한다.

```c#
대리자 인스턴스 = delegate ( 매개변수 목록 )
{
    ..//실행하고자 하는 코드
}
```

```c#
using System;
using System.ComponentModel;

namespace AnonymousMethod
{
    delegate int Compare(int a, int b);
    class Program
    {
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 2, 6, 8, 2, 45 };
            Console.WriteLine("Sorting ascending..");
            BubbleSort(array, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{array[i]}");
            
            int[] array2 = { 4, 6, 2, 6, 8, 2, 45 };
            Console.WriteLine("Sorting descending..");
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine($"{array2[i]}");
        }
    }
}
```

## 이벤트( Event )

1. 클래스 안 혹은 밖에 대리자를 선언한다.
2. 클래스 내에 1. 에서 선언한 대리자의 인스턴스를 event 한정자로 수식해서 선언한다.
3. 이벤트 핸들러를 작성한다. 이벤트 핸들러는 1. 에서 작성한 메소드면 된다.
4. 클래스의 인스턴스를 생성하고 이 객체의 이벤트에 3. 에서 작성한 이벤트 핸들러를 등록한다.
5. 이벤트가 발생하면 이벤트 핸들러가 호출된다.

```c#
using System;

namespace EventTest
{
    //1. 클래스 안 혹은 밖에 대리자를 선언한다.
    delegate void EventHandler(string message);
    class MyNotifier
    {
        //2. 선언한 대리자의 인스턴스를 event 한정자로 수식해서 선언한다.
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
    }
    class Program
    {
        //3. 이벤트 핸들러를 작성한다. SomethingHappened 이벤트에서 사용할 이벤트 핸들러는 EventHandler대리자의 형식과 동일한 메소드여야 한다.
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            //4. 클래스의 인스턴스를 생성하고 이 객체의 이벤트에 3에서 작성한 이벤트 핸들러를 등록한다.
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);
			//SomethingHappened 이벤트에 MyHandler()메소드를 이벤트 핸들러로 등록한다.
            for(int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i);
                //이벤트가 발생하면 이벤트 핸들러가 호출된다.
            }
        }
    }
}
/*
3 : 짝
6 : 짝
9 : 짝
13 : 짝
16 : 짝
19 : 짝
23 : 짝
26 : 짝
29 : 짝
*/
```



이벤트와 대리자의 가장 큰 차이점은 바로 이벤트는 외부에서 직접 사용할 수 없다는 것이다.

이벤트는 public한정자로 선언되어 있어도 자신이 선언되어있는 클래스 외부에서는 호출이 불가능하다. 반면에 대리자는 public이나 internal로 수식되어 있으면 클래스 외부에서라도 얼마든지 호출이 가능하다.

이벤트가 외부에서 호출이 불가능하다는 사실은 견고한 이벤트 프로그래밍을 가능하게 한다.

이벤트를 객체 외부에서 임의로 호출할 수 있게 된다면, 객체의 외부에서 허위로 네트워크 상태 변화를 일으킬 수 있게 된다. 

대리자는 콜백 용도로 사용하고, 이벤트는 객체의 상태 변화나 사건의 발생을 알리는 용도로 구분해서 사용해야 한다.

