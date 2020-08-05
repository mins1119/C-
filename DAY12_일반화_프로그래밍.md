# 일반화 프로그래밍															  	20.08.05

## 일반화 ( Generalization )

특수한 개냠으로부터 공콩된 개념을 찾아 묶는 것이다.

일반화 프로그래밍은 "데이터 형식"을 일반화한다.

```C#
void CopyArray ( int[] source, int[] target )
{
    for( int i = 0; i < source.Length; i++ )
        target[i] = souce[i];
}
```

CopyArray 라는 메소드를 다른 형식으로 지원하려면 오버로딩을 하면 된다. 하지만 더 많은 형식을 지원해야 하는 경우, 내부 논리는 같고 매개변수의 입력형식만 다른 오버로딩을 여러번 작성하기 번거롭다. 일반화 프로그래밍은 오버로딩없이 모든 형식을 지원하는 프로그래밍 패러다임이다.



## 일반화 메소드 ( Generic Method )

데이터 형식을 일반화한 메소드

메소드와 선언 방식은 동일하지만 일반화할 형식이 들어가갈 자리에 구체적인 이름 대신 형식 매개변수'T'가 들어간다.

```C#
한정자 반환형식 메소드이름< 형식 매개 변수 > (매개변수 목록)
{
    // ...
}
```

```c#
using System;

namespace CopyingArray
{
    class Program 
    { 

            static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i =0 ; i < source.Length; i++)
                target[i] = source[i];
        }
    
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int element in target)
                Console.WriteLine(element);
            
            string[] source2 = { "A", "B", "C", "D", "E" };
            string[] target2 = new string[source.Length];

            CopyArray<string>(source2, target2);

            foreach (string element in target2)
                Console.WriteLine(element);
        }
    }
}
/*
1
2
3
4
5
A
B
C
D
E
*/
```

일반화 클래스

```C#
class Array_Generic<T>
{
    private T<> array;
    // . . 
    public T GetElement( int index ) { return aray[index]; }
}
```

![스크린샷(25)](https://user-images.githubusercontent.com/40557177/89359761-82588580-d701-11ea-9e8a-2490ab3498c2.png)

```c#
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Generic
{
    class MyList<T>
    {
        private T[] array;
        public MyList()
        {
            array = new T[3];
        }
        public T this [int index]
        {
            get { return array[index]; }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "a";
            str_list[1] = "b";
            str_list[2] = "c";
            str_list[3] = "d";
            str_list[4] = "e";

            for (int i = 0; i < str_list.Length; i++)
                Console.WriteLine(str_list[i]);
            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;

            for (int i = 0; i < int_list.Length; i++)
                Console.WriteLine(int_list[i]);
        }
    }
}
/*
Array Resized : 4
Array Resized : 5
a
b
c
d
e

Array Resized : 4
0
1
2
3
*/
```

## 형식 매개변수 제약

일반화 메소드나 일반화 클래스가 입력받는 형식 매개변수 T는 모든 데이터 형식을 대신할 수 있다. 하지만 형식매개변수의 조건에 제약을 걸어 특정 조건의 형식매개변수만을 사용할 수도 있다.

```c#
class MyList<T> where T:Myclass{
    // . . . 
}

where 형식매개변수 : 제약조건
```

| 제약                       | 설명                                               |
| -------------------------- | -------------------------------------------------- |
| where T : struct           | T는 값형식이어야 한다.                             |
| where T : class            | T는 참조형식 이어야 한다.                          |
| where T : new()            | T는 반드시 매개변수가 없는 생성자가 있어야 한다.   |
| where T : 기반 클래스 이름 | T는 명시한 기반 클래스의 파생 클래스여야 한다.     |
| where T : 인터페이스 이름  | T는 명시한 인터페이스를 반드시 구현해야 한다.      |
| where T : U                | T는 또 다른 형식매개변수 U로부터 상속받을 수 있다. |

### where T : new()

```c#
public static T CreateInstance<T>() where T : new()
{
    return new T();
}
```

CreateInstance<T>() 메소드는 기본 생성자를 가진 어떤 클래스의 객체라도 생성한다.

이 메소드를 호출할 때 기본 생성자가 없는 클래스를 형식 매개변수로 넘기면 컴파일 에러가 발생한다.

### where T : U

상위 코드에서 사용되는 형식매개변수 U로부터 상속받는 형식으로 제약조건을 준다.

```C#
class BaseArray<U> where U : Base
{
    public U[] Array { get;set; }
    public BaseArray(int size)
    {
        Array = new U[size];
    }
    public void CopyArray<T>(T[] source) where T : U
    {
        Source.CopyTo(Array, 0);
    }
}
// CopyArray<T>() 는 소속클래스인 BaseArray<U>의 형식매개변수 U로부터 T가 상속받아야 할 것을 강제한다.
```

## 일반화 컬렉션

컬렉션은 모두 object형식을 기반으로 한다. 때문에 어떠한 형식이든 사용이 가능하지만 접근할때마다 형식변환이 발생하기 때문에 성능에 문제가 있다.

일반화 컬렉션은 컴파일 할 때 컬렉션에서 사용될 형식이 결정되고 쓸데 없는 형변환을 일으키지 않는다.

### List< T >

ArrayList와 동일한 기능을 수행하지만, 아무 형식이나 넣을 수 있었던 ArraList와는 달리 형식매개변수로 입력한 형식 외에는 입력을 허용하지 않는다.

인스턴스를 만들 때 형식 매개 변수를 필요로 한다. 

```c#
using System;
using System.Collections.Generic;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int element in list)
                Console.Write($"{element}");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach(int element in list)
                Console.Write($"{element}");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
                Console.Write($"element");
            Console.WriteLine();
        }
    }
}
/*
01234
0134
01234
*/
```

### Queue< T >

```c#
using System;
using System.Collections;

namespace UsingGenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
           
        }
    }
}
/*1
2
3
4
5*/
```

### Stack< T >

```c#
using System;
using System.Collections;
using System.Collections.Generic;

namespace UsingGenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
/*
5
4
3
2
1
*/
```

Dictionary< TKey, TValue >

```c#
using System;
using System.Collections.Generic;

namespace UsingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["Alice"] = "Liddel";
            dic["Optimus"] = "Prime";
            dic["Rain"] = "Umbrella";

            Console.WriteLine(dic["Alice"]);
            Console.WriteLine(dic["Optimus"]);
            Console.WriteLine(dic["Rain"]);
        }
    }
}
/*
Liddel
Prime
Umbrella
*/
```

## foreach

일반화 클래스 역시 IEnumerable과 IEnmerator을 사용해서 foreach 문을 통헤 순회할 수 있지만, 요소를 순회할 때마다 형식변환을 수행하는 오버로드가 발생할 수 있다.

IEnumerator IEnumerable의 일반화 버전인 IEnumeratoe< T > ,IEnumerable< T >을 상속하여 메소드와 프로퍼티를 구현하면, 형식변환으로 인한 성능저하가 없으면서도 foreach 순회가 가능한 클래스를 만들수 있다.

### IEnumerable< T >

두 메소드는 이름이 같지만 반환형식이 다르다. 

IEnumerator를 반환하는 GetEnumerator() 메소드는 IEnumerable < T > 인터페이스가 IEnumerable인터페이스로부터 상속을 받은 것이고, IEnumerator< T >를 반환하는 버전은 IEnumerable< T >에서 새로 선언된 메소드다. 두 가지를 모두 구현해야 한다. 

| 메소드                           | 설명                                                         |
| -------------------------------- | ------------------------------------------------------------ |
| IEnumerator GetEnumerator()      | IEnumerator 형식의 객체를 반환 (IEnumerable 로부터 상속받은 메소드) |
| IEnumerator< T > GetEnumerator() | IEnumerator< T > 형식의 객체를 반환                          |

### IEnuerator< T >

Current 프로퍼티가 두 가지 버전을 가지고 있다.

Object Current는 IEnumerator에서 상속받은 것이고, T Current는 IEnumerator< T >에서 선언된 일반화를 지원하는 버전이다.

두가지 모두 구현해야한다.

| 메소드 또는 프로퍼티    | 설명                                                         |
| ----------------------- | ------------------------------------------------------------ |
| boolean  MoveNext()     | 다음 요소로 이동한다. 칼렉션의 끝을 지난 경우에는 false, 이동이 성공한 경우에는 true를 반환한다. |
| void Reset()            | 컬렉션의 첫번째 위치의 "앞"으로 이동한다.                    |
| Object Current { get; } | 컬렉션의 현재 요소를 반환한다. ( IEnumerator로부터 상속받은 프로퍼티 ) |
| T Current { get; }      | 컬렉션의 현재 요소를 반환한다.                               |



```c#
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace EnumerableGeneric
{
    class MyList<T> : System.Collections.Generic.IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i<array.Length; i++)
            {
                yield return (array[i]);
            }
        }
        public T Current
        {
            get { return array[position]; }
        }
        Object IEnumerator.Current
        {
            get { return array[position]; }
        }
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "a";
            str_list[1] = "b";
            str_list[2] = "c";
            str_list[3] = "d";
            str_list[4] = "e";

            foreach (string str in str_list)
                Console.WriteLine(str);
            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 1;
            int_list[1] = 2;
            int_list[2] = 3;
            int_list[3] = 4;
            int_list[4] = 5;

            foreach (int i in int_list)
                Console.WriteLine(i);

        }
    }
}
/*
Array Resized : 4
Array Resized : 5
a
b
c
d
e

Array Resized : 4
Array Resized : 5
1
2
3
4
5
*/
```







메소드 일반화 단계

1. 데이터 형식이 사용된 부분을 T기호로 치환
2. <>를 이용해 형식을 매개변수로 넘겨준다.
3. 메소드 호출시 <> 사이의 T대신에 형식의 이름을 대입한다.



 클래스 일반화 단계

데이터 형식을 다르나 기능은 같은 클래스

형식 매개변수를 이용해 일반화 클래스로 개선

객체 생성시 입력받은 형식으로 치환



