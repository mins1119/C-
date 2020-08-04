# 배열과 컬렉션																		  	20.08.04

## 배열

같은 성격을 띈 다수의 데이터를 한번에 다룰 수 있다.

```c#
데이터형식[] 배열이름 = new 데이터형식[ 용량 ];

//용량이 5개인 int 형식의 배열
int[] array = new int[5];
```

배열의 인덱스는 0부터 시작하며, 배열이름 뒤에  [] 를 붙여두고 그 사이에 인덱스를 적어 값을 할당하면 된다.

```c#
int[] scores = new int[5];
scores[0] = 3;
scores[1] = 5;
```

```c#
using System;
using System.Net.Sockets;

namespace SampleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 30;
            scores[3] = 40;
            scores[4] = 100;

            foreach (int score in scores)
                Console.WriteLine(score);
            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score: {average}");
        }
    }
}
/*
30
0
0
40
100
Average Score: 34
*/
```

### 배열 초기화

배열의 객체를 초기화하는 {} 블록을 일컬어 컬렉션 초기자( Collection Initializer )라고 한다.

```C#
string[] array1 = new string[3]{ "Alice", "in", "Wonderland"};

string[] array2 = new string[] { "Alice", "in", "Wonderland"};

string[] array3 = { "Alice", "in", "Wonderland"};
```

### System.Array

배열은 객체이며, .NET프레임워크의 CTS( Common Type System )에서  System.Array에 대응된다.

```c#
int[] array = new int[] { 10, 20, 30, 40 };
Console.WriteLine($"Type of array : {array.GetType()}");
Console.WriteLine($"Base Type OF array : {array.GetType().BaseType}");
/*
Type of array : System.Int32[]
Base Type OF array : System.Array
int 기반의 배열이 System.Array형식에서 파생되었음을 보여준다.*/
```

#### Array  클래스의 주요 메소드와 프로퍼티

| 분류            | 이름                | 설명                                                         |
| --------------- | ------------------- | ------------------------------------------------------------ |
| 정적 메소드     | Sort()              | 배열을 정렬한다.                                             |
|                 | BinarySearch< T >{} | 이진 탐색을 수행한다.                                        |
|                 | IndexOf()           | 배열에서 찾고자 하는 특정 데이터의 인덱스를 반환한다.        |
|                 | TrueForAll< T >()   | 배열의 모든 요소가 지정한 조건에 부합한지의 여부를 반환한다. |
|                 | FindIndex< T >()    | 배열에서 지정한 조건에 부합하는 첫번째 요소의 인덱스를 반환한다.<br />IndexOf() 메소드가 특정 값을 찾는다면, FindIndexOf< T >()메소드는 지정한 조건에 바탕하여 찾는다. |
|                 | Clear()             | 배열의 모든 요소를 초기화한다.<br />배열이 숫자 형식 기반이면 0으로, 논리 형식 기반이면 false, 참조 향식 기반이면 null로 초기화한다. |
|                 | Foreach< T >()      | 배열의 모든 요소에 대해 동일한 작업을 수행하게 한다.         |
|                 | Resize< T >()       | 배열의 크기를 재조정한다.                                    |
| 인스턴스 메소드 | GetLength()         | 배열에서 지정한 차원의 길이를 반환한다.                      |
| 프로퍼티        | Length              | 배열의 길이를 반환한다.                                      |
|                 | Rank                | 배열의 차원을 반환한다.                                      |

```c#
using System;
using System.Net.Sockets;

namespace MoreOnArray
{
    class Program
    {
        //Checkedpassed : 60초과만 패스로 판별
        private static bool CheckPassed(int score)
        {
            if (score > 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 61, 75, 43, 69, 99 };
            //scores의 값들 출력
            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

			//scores 정렬 43 61 69 75 99
            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
			//scores 의 차원 반환 : 1
            Console.WriteLine($"Number of dimension : {scores.Rank}");
			//
            Console.WriteLine("Binary Search : 43 is at {0}",Array.BinarySearch<int>(scores,43));
            //69의 인덱스 2
            Console.WriteLine("Linear Search : 69 is at {0}", Array.IndexOf(scores, 69));
			//모든 요소가 CheckPassed의 조건에 부합하는지 판별 : false
            Console.WriteLine("Everyone passed ? :{0}",Array.TrueForAll<int>(scores, CheckPassed));
			
            //60보다 작은 첫번째 요소의 인덱스 반환
            int index = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60)
                    return true;
                else
                    return false;
            });
			
            //43을 61로 바꿈. 모든 요소가 CheckPassed의 조건을 만족 : true
            scores[index] = 61;
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));
			//차원의 길이 : 5
            Console.WriteLine($"Old Length of scores : {scores.GetLength(0)}");
			//차원의 길이를 10으로 바꿈
            Array.Resize<int>(ref scores, 10);
			//차원의 길이 : 10
            Console.WriteLine($"New length of scores : {scores.GetLength(0)}");
			
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
			//3번째 부터 7번째인덱스까지 초기화
            Array.Clear(scores, 3, 7);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
/*
61 75 43 69 99
43 61 69 75 99
Number of dimension : 1
Binary Search : 43 is at 0
Linear Search : 69 is at 2
Everyone passed ? :False
Everyone passed ? : True
Old Length of scores : 5
New length of scores : 10
61 61 69 75 99 0 0 0 0 0
61 61 69 0 0 0 0 0 0 0
*/
```

### 2차원 배열

2개의 차원 ( 가로 + 세로 ) 으로 원소를 배치한다. 

1차원 배열과 선언형식이 같지만 각 차원의 용량길이를 콤마( , )로 구분해서 [ ]사이에 입력한다.

```c#
데이터형식[,] 배열이름 = new 데이터형식[2차원 길이, 1차원 길이];

int[ , ] array = new int [ 2, 3 ];
array[ 0, 0 ] = 1;
array[ 0, 1 ] = 2;
```

#### 2차원 배열 초기화

```c#
int[,] arr = new int[2,3]{{1,2,3},{4,5,6}};		//형식과 길이를 명시
int[,] arr2 = new int[,]{{1,2,3},{4,5,6}};		//배열의 길이를 생략
int[,] arr3 = { {1,2,3},{4,5,6} };				//형식과 길이를 모두 생략
```

```c#
using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i} , {j}] : {arr[i,j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();            
            
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i = 0; i < arr2.GetLength(0); i++)
            {
                for(int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"[{i} , {j}] : {arr2[i,j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();            
            
            int[,] arr3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i = 0; i < arr3.GetLength(0); i++)
            {
                for(int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write($"[{i} , {j}] : {arr3[i,j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
/*
[0 , 0] : 1[0 , 1] : 2[0 , 2] : 3
[1 , 0] : 4[1 , 1] : 5[1 , 2] : 6

[0 , 0] : 1[0 , 1] : 2[0 , 2] : 3
[1 , 0] : 4[1 , 1] : 5[1 , 2] : 6

[0 , 0] : 1[0 , 1] : 2[0 , 2] : 3
[1 , 0] : 4[1 , 1] : 5[1 , 2] : 6
*/
```

### 다차원 배열

2차원 배열을 포함한 차원이 둘 이상인 배열

```c#
using System;

namespace _3DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[4, 3, 2]
            {
                { {1,2},{3,4},{5,6} },
                { {1,2},{3,4},{5,6} },
                { {1,2},{3,4},{5,6} },
                { {1,2},{3,4},{5,6} }
            };

            for(int i = 0; i< array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for(int k = 0; k< array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i,j,k]}");
                    }
                    Console.Write(" } ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*
{ 12 } { 34 } { 56 }
{ 12 } { 34 } { 56 }
{ 12 } { 34 } { 56 }
{ 12 } { 34 } { 56 }
*/
```

### 가변배열( Jagged Array )

다양한 길이의 배열을 요소로 가지는 다차원 배열

가변배열의 요소로 입력되는 배열은 길이가 모두 같을 필요가 없다.

```C#
데이터형식[][] 배열이름 = new 데이터형식[ 가변배열의 용량 ][];

int[][] jagged = new int[3][];
jagged[0] = new int[5]{1,2,3,4,5};
jagged(1) = new int[]{7,8,9};
jagged(2) = new int[]{100,200};
//선언과 동시에 초기화도 가능하다.
int jagged2 = new int[2][]{
    new int[]{100,200},
    new int[4]{6,4,3,4}
};
```

```c#
using System;
using System.Net.Http.Headers;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20 };
            jagged[2] = new int[] { 9, 3, 2, 1 };

            foreach( int[] arr in jagged)
            {
                Console.WriteLine($"Length : {arr.Length}");
                foreach( int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
/*
Length : 5
1 2 3 4 5
Length : 2
10 20
Length : 4
9 3 2 1
*/
```

## 컬렉션 ( Collection )

같은 성격을 띄는 데이터의 모음을 담는 자료구조

### ArrayList

배열과 닮은 컬렉션. 

요소에 접근할때는 []연산자를 이용하고, 특정위치에 있는 요소에 데이터를 임의로 할당할 수도 있다. 배열과는 달리 생성시 용량을 미리 지정할 필요가 없이 필요에 따라 자동으로 용량이 늘거나 줄어든다.

대신 제네릭 List<T> 사용을 권장한다.

```c#
using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

namespace UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i = 0; i <5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Console.Write($"{list[i]} ");
            Console.WriteLine();
        }
    }
}
/*
0 1 2 3 4
0 1 3 4
0 1 2 3 4
0 1 2 3 4 abc def
*/
```

### Queue

대기열이라는 뜻의 Queue 자료구조는 데이터나 작업을 차례대로 입력해뒀다가 입력된 순서대러 하나식 꺼내 처리하기 위해 사용된다.

입력은 오직 뒤에서, 출력은 앞에서만 이루어진다.



데이터 입력은 Enqueue()메소드를 통해 이루어진다.

```c#
Queue que = new Queue();
que.Enqueue( 1 );
que.Enqueue( 2 );
que.Enqueue( 3 );
que.Enqueue( 4 );
```

데이터 출력은 Dequeue() 메소드를 통해 이루어진다.

Dequeue()를 실행하면 제일 앞에 있던 항목이 출력되고 그 뒤에 있던 항목이 제일 앞으로 옮겨진다.

```C#
int a = que.Dequeue();
```

```c#
using System;
using System.Collections;

namespace UsingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}
/*
1
2
3
4
*/
```

### Stack

Queue 와 반대로 먼저들어온 데이터가 나중에 나가고, 나중에 들어온 데이터가 먼저나가는 구조의 컬렉션

데이터를 넣을때는 Push()메소드를 이용하여 "쌓고", Pop()메소드를 이용하여 제일 위에 쌓여있는 데이터를 "꺼낸다."

Pop()을 이용하여 데이터를 꺼내면 그 데이터는 컬렉션에서 제거가 되고 그 아래에있던 데이터가 제일 위로 올라온다.

```c#
using System;
using System.Collections;

namespace UsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
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

### Hashtable

키( key )와 값( value )의 쌍으로 이루어진 데이터를 다룰 때 사용한다. 탐색속도가 빠르고 사용하기 편리하다.

데이터를 저장할 요소의 위치로 키 데이터를 그대로 사용한다. 키는 어떤 형식이든 사용할 수 있다.

Hashtable은 탐색속도가 거의 소요되지 않는다. 키를 사용하여 단번에 데이터가 저장되어있는 컬렉션내의 주소를 찾아내고, 이를 해싱이라고 한다.

```c#
using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace UsingHashtale
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["Alice"] = "Liddel";
            ht["Harry"] = "Potter";
            ht["Optimus"] = "Prime";
            ht["Chris"] = "Pratt";
		
            Console.WriteLine(ht["Alice"]);
            Console.WriteLine(ht["Harry"]);
            Console.WriteLine(ht["Optimus"]);
            Console.WriteLine(ht["Chris"]);
        }
    }
}/*
Liddel
Potter
Prime
Pratt*/
```

### 컬렉션 초기화

#### ArrayList, Queue, Stack

ArrayList, Queue, Stack은 배열의 도움을 받아 초기화를 할 수 있다. 생성자를 호출할 때 매개변수로 배열 객체를 넘기면 컬렉션 객체는 해당 배열을 바탕으로 내부 데이터를 채운다.

```c#
int[] arr = {123, 456, 789 };

ArrayList list = new ArrayList(arr);
Stack stack = new Stack(arr);
Queue queue = new Queue(arr);
```

ArrayList는 배열없이 컬렉션 초기자를 이용해서 초기화하는 것이 가능하다.

```c#
ArrayList list2 = new ArrayList(){ 11,22,33 };
```

Stack 과 Queue 는 컬렉션초기자를 사용할 수 없다. 컬렉션 초기자는 IEnumerable인터페이스와 Add()메소드를 구현하는 컬렉션만 지원하는데, 

Stack 과 Queue 는 IEnumerable은 상속하지만 Add()메소드를 구현하고 있지 않기 때문이다.

```c#
using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace InitializingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                Console.WriteLine($"ArrayList : {item}");
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                Console.WriteLine($"Stack : {item}");
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                Console.WriteLine($"Queue : {item}");
            Console.WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (object item in list2)
                Console.WriteLine($"ArrayList2 : {item}");
            Console.WriteLine();
        }
    }
}
/*
ArrayList : 123
ArrayList : 456
ArrayList : 789

Stack : 789
Stack : 456
Stack : 123

Queue : 123
Queue : 456
Queue : 789

ArrayList2 : 11
ArrayList2 : 22
ArrayList2 : 33
*/
```

#### Hashtable

딕셔너리 초기자 (Dictionary Initializer)와 컬렉션 초기자를 사용할 수 있다. 하지만, 딕셔너리 초기자가 쓰고 읽기 수월하다.

```c#
Hashtable ht = new Hashtable()
{
    ["하나"] = 1,
    ["둘"] = 2,
    ["셋"] = 3
};

Hashtable ht2 = new Hashtable()
{
    {"하나",1},
    {"둘",2},
    {"셋",3}
};
```

### 인덱서 ( Indexer )

인덱서는 인덱스를 이용하여 객체내의 데이터에 접근하게 해주는 프로퍼티와 비슷하다. 객체를 배열처럼 사용할 수 있게 해준다.

인덱서는 프로퍼티처럼 식별자를 따로 가지지 않는다. 프로퍼티가 이름을 통해 객체 내의 데이터에 접근하게 해준다면, 인덱셔는 이름을 통해 객체 내의 데이터에 접근하게 해준다.

```c#
class 클래스이름
{
    한정자 인덱서형식 this[형식 index]
    {
        get
        {
            //index를 이용하여 내부 데이터 반환
        }
        set
        {
            //index를 이용하여 내부 데이터 저장
        }
    }
}
```

```c#
using System;
using System.Runtime.CompilerServices;

namespace Indexer
{
    class Mylist	//Mylist는 내부에 정수형식배열을 갖고있고 인덱서를 통헤 이 배열에 접근한다.
    {
        private int[] array;

        public Mylist()
        {
            array = new int[3];
        }
        public int this[int index]	//인덱서
            //인덱서를 통해 데이터를 저장하고자 하는 시도가 이루어질 때 지정한 인덱스보다 배열의 크기가 작디면, 인덱스에 맞춰 배열의 크기를 재조정한다.
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get
            {
                return array.Length;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mylist list = new Mylist();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
/*
Array Resized : 4
Array Resized : 5
0
1
2
3
4
*/
```

### foreach가 가능한 객체

foreach 구문은 IEnumerable 과 IEnumerable을 상속하는 형식만 지원한다.

| 메소드                      | 설명                           |
| --------------------------- | ------------------------------ |
| IEnumerable GetEnumerator() | IEnumerator 형식의 객체를 반환 |

GetEnumerator() 메소드를 구현할 때는 yield return문의 도움을 받는다. yield return 문은 현재 메소드(GetEnumerator())의 실행을 정지시켜놓고 호출자에게 결과를 반환한다. 메소드가 다시 호출되면, 일시정지된 실행을 복구하여 yield return 또는 yield break문을 만날때까지 나머지 작업을 실행한다.

```c#
using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace Yield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;	//yield break는 GetEnumerator()메소드를 종료시킨다.
            yield return numbers[3];	//이 코드는 실행되지 않는다.

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);
        }
    }
}
/*
1
2
3
*/
```

#### IEnumerator 인터페이스의 메소드 및 프로퍼티 목록



| 메소드 또는 프로퍼티    | 설명                                                         |
| ----------------------- | ------------------------------------------------------------ |
| boolean MoveNext()      | 다음요소로 이동한다.<br />컬렉션의 끝을 지난 경우에는 false, 이동이 성공한 경우에는 true를 반환한다. |
| void Reset()            | 컬렉션의 첫 번째 위치의 '앞'으로 이동한다. 첫번 째 위치가 0이라면, Reset()을 호출하면 -1로 이동한다. 첫번째 위치의 이동은 MoveNext()를 호출한 다음 이루어진다. |
| Object Current { get; } | 컬렉션의 현재 요소를 반환한다.                               |

```c#
using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Threading;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        //Inumerator 멤버
        public object Current
        {
            get
            {
                return array[position];
            }
        }
        //IEnumeraor 멤버
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
        //IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }
        //IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            for (int i =0; i< array.Length; i++)
            {
                yield return (array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
}
/*
Array Resized : 4
Array Resized : 5
0
1
2
3
4
*/
```

