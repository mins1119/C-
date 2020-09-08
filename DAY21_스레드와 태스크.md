

# 프로세스와 스레드

![thread](https://user-images.githubusercontent.com/40557177/91240725-bdd4f580-e77d-11ea-8e63-39fcf8e7507a.png)

**프로세스**

실행파일이 실행되어 메모리에 적재된 인스턴스.

프로세스는 반드시 하나 이상의 스레드로 구성된다.

**스레드**

운영체제가 CPU시간을 할당하는 기본 단위.



**멀티 스레드**

프로세스 하나에 여러개의 스레드를 가지는 구조

장점

- 사용자 대화형 프로그램 ( 콘솔 프로그램과 GUI프로그램 모두) 에서 멀티 스레드를 이용하면 응답성을 높일 수 있다.
  - 단일스레드로 만든 프로그램에서 파일을 복사하는 중, 취소 명령을 내려도 사용자에게 반응하지 않으므로 복사를 취소할 수 없다.
- 멀티 프로세스 방식에 비해 멀티 스레드 방식이 자원 공유가 쉽다.
  - 멀티 프로세스는 GUI가 없는 웹 서버 같은 서버용 애플리케이션에서 많이 취하는 구조인데, 프로세스끼리 데이터를 교환하려면 IPC를 사용해야한다. 반면 스레드 방식에서는 코드내의 변수를 같니 사용하는 것으로 데이터 교환이 가능하다.
- 경제적이다.
  - 프로세스를 띄우기 위해 메모리와 자원을 할당하는 작업은 비용이 비싼데, 스레드를 띄울때는 이미 프로세스에 할당된 메모리와 작업을 그대로 사용하므로 할당비용을 지불할 필요가 없다.

단점

- 구현하기 까다롭다.
  - 테스트가 쉽자 않다.
  - 멀티 프로세스 기반의 소프트웨어는 자식 소프트웨어중 하나에 문제가 생기면 그 자식 프로세스 하나가 죽는 것으로 끝나지만, 멀티 스레드 방식에서는 자식 프로세스 하나에 문제가 생기면 전체 프로세스가 영향을 받게 된다.
- 스레드를 너무 많이 사용하면 오히려 성능이 저하된다.
  - 스레드가 CPU를 사용하기 위해서는 작업간 전환을 해야하는데, 작업간 전환은 적지 않은 비용을 소모한다. 자주 작업간 전환을 수행하면 애플리케이션이 실제로 일하는 시간에 비해 작업간 전환에 사용되는 시간이 커지기 때문에 성능이 저하된다.



----

-------

# 스레드

.NET 프레임워크에서는 스레드를 나타내는 클래스로 System.Threading.Thread를 제공한다.

---------

## 스레드 시작하기

![thread_Start](https://user-images.githubusercontent.com/40557177/91244147-90407a00-e786-11ea-8392-b11d8c517f57.png)

1. Thread의 인스턴스를 생성한다.
2. Threas.Start() 메소드를 호출하여 스레드를 시작한다.
3. Thread.Join() 메소드를 호츨하여 스레드가 끝날 때가지 기다린다.

```c#
static void DoSomething(){		//스레드가 실행할 메소드
    for(int i = 0; i < 5; i++;){
       Console.WriteLine($"DoSomething : {i}"); 
    }
}

static void Main(string[] args){
    Thread t1 = new Thread(new ThreadStart(DoSomething));	//Thread의 인스턴스 생성
    
    t1.Start();		//스레드 시작
    
    t1.Join();		//스레드의 종료 대기
}
```

 Thread 클래스의 인스턴스는 '준비'를 하고 실제 메모리에 적재되는 시점은  t1.Strat() 메소드를 호출했을 때다. t1.Start() 메소드가 호출되고 나면,CLR은 스레드를 실제로 생성하여 Dosomething() 메소드를 호출한다.

t1.Join() 메소드는 블록되어 있다가 DoSomething()  메소드의 실행이 끝나면 반환되어 다음 코드를 실행할 수 있게 한다. 스레드를 실행하면 밧줄(프로세스)에서 실( 스레드 )이 한 갈래 빠져 나왔다가 Join()메소드가 반환되는 시점에서 이 실( 스레드 )이 밧줄( 프로세스 )로 다시 합류한다고 생각하면 된다.



```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThread
{
    class Program
    {
        static void DoSomething()
        {
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);	//Sleep()메소드는 다른 스레드도 CPU를 사용할 수 있도록 CPU점유를 내려놓는다. 
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Start Threading...");
            t1.Start();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }
            Console.WriteLine("Waiting until thread stops..");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
/*
Start Threading...
Main : 0
DoSomething : 0
Main : 1
DoSomething : 1
Main : 2
DoSomething : 2
DoSomething : 3
Main : 3
Main : 4
DoSomething : 4
Waiting until thread stops..
Finished
*/
```

--------

## 스레드 종료

### Abort()

스레드를 종료시키려면 Thread객체의 Abort() 메소드를 호출한다.

![thread_Abort](https://user-images.githubusercontent.com/40557177/91244149-90d91080-e786-11ea-8d1f-f9907b69cbd6.png)

Abort()메소드를 호출하면 CLR은 해당 스레드가 실행중이던 코드에 ThreadAbortException을 호출한다. 이 때 예외를 catch하는 코드가 있가면 예외를 처리한 다음, finally블록까지 실행항 후에 스레드가 완전히 종료된다. 따라서 Abort() 메소드를 호출하 때는 처리시간을 염두에 둬야한다.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbortingThread
{
    class SideTask
    {
        int count;
        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                while(count >0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resources...");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting Thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Aborting thread...");
            t1.Abort();

            Console.WriteLine("Waiting until thresd stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
/*
Starting Thread...
100 left
99 left
98 left
97 left
96 left
95 left
94 left
93 left
Aborting thread...
System.Threading.ThreadAbortException: 스레드가 중단되었습니다.
   위치: System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   위치: System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   위치: AbortingThread.SideTask.KeepAlive() 파일 C:\Users\User\Desktop\mskang\ThreadAndTask\AbortingThread\Program.cs: 줄 24
Waiting until thresd stops...
Clearing resources...
Finished
*/
```

> Thread.Abort() 는 사용을 지양한다. 



### Interrupt()

Thread.Interrupt() 메소드는 스레드가 한참 동작중인 상태( Running 상태 )를 피해서 WaitJoinSleep 상태에 들어깄을 때, ThreadInterruptException을 던져 스레드를 중지시킨다. 

스레드가 이미 WaitJoinSleep 상태인 경우에는 즉시 중단시키지만, 아닌 경우에는 스레드를 지켜보고 있다가 WaitJoinSleep 상태가 되면 그제서야 스레드를 중지시킨다. 때문에, 최소한 코드가 "절대로 중단되면 안되는" 작업을 하고 있을때에는 중단되지 않는다는 보장을 받을 수 있다.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterruptingThread
{
    class SideTask
    {
        int count;
        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Runnung thread isn't gonna be interrupted");
                Thread.SpinWait(1000000000);
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Console.WriteLine("Entering into WaitJoinSleep State..");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resources...");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting Thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();

            Console.WriteLine("Waiting until thresd stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
/*
Starting Thread...
Runnung thread isn't gonna be interrupted
Interrupting thread...
Waiting until thresd stops...
100 left
Entering into WaitJoinSleep State..
System.Threading.ThreadInterruptedException: 스레드가 대기 상태에서 인터럽트되었습니다.
   위치: System.Threading.Thread.SleepInternal(Int32 millisecondsTimeout)
   위치: System.Threading.Thread.Sleep(Int32 millisecondsTimeout)
   위치: InterruptingThread.SideTask.KeepAlive() 파일 C:.../Program.cs:줄 27
Clearing resources...
Finished
*/
```



--------

## 스레드의 상태변화

스레드의 상태는 TreadState 열거형에 정의되어있다.

| 상태          | 설명                                                         |
| ------------- | ------------------------------------------------------------ |
| Unstarted     | 스레드가 객체를 생성항 후 Thread.Start()메소드가 호출되기 전의 상태 |
| Running       | 스레드가 시작하여 동작중인 상태를 나타낸다. Unstarted 상태의 스레드를 Thread.Start() 메소드를 통해 이 상태로 만들 수 있다. |
| Suspended     | 스레드의 일시 중단 상태를 나타낸다.                          |
| WaitSleepJoin | 스레드가 블록(Blocked)된 상태를 나타낸다.                    |
| Aborted       | 스레드가 취소된 상태를 나타낸다.  Aborted상태가 된 스레드는 다시 Stopped상태로 전환되어 완전히 중지된다. |
| Stopped       | 중지된 스레드의 상태를 나타낸다.                             |
| Background    | 스레드가 백그라운드로 동작하고 있음을 나타낸다. 포어그라운드(Foreground)스레드는 하나라도 살아있는 한 프로세스가 죽지 않지만, 백그라운드는 살아있어도 프로세스가 죽고 사는것에 영향을 끼치지 않는다. |

ThreadState 열거형은 Flags애트리뷰트를 가진다.  Flags는 자신이 수식하는 열거형을 비트필드 (Bit Field), 플래그 집합으로 처리할 수 있음을 나타낸다.

> **비트필드( Bit Field )**
>
> C언어 등에서 구조체를 선언할 때 바이트단위가 아닌 비트단위로 선언한 필드를 말한다.

```c#
using System;
using System.Threading;
namespace UsingTreadState
{
    class Program
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine($"{state,-16} : {(int)state}");
        }
        static void Main(string[] args)
        {
            PrintThreadState(ThreadState.Running);
            PrintThreadState(ThreadState.StopRequested);
            PrintThreadState(ThreadState.SuspendRequested);
            PrintThreadState(ThreadState.Background);
            PrintThreadState(ThreadState.Unstarted);
            PrintThreadState(ThreadState.Stopped);
            PrintThreadState(ThreadState.WaitSleepJoin);
            PrintThreadState(ThreadState.Suspended);
            PrintThreadState(ThreadState.AbortRequested);
            PrintThreadState(ThreadState.Aborted);
            PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
            
        }
    }
}
/*
Running          : 0
StopRequested    : 1
SuspendRequested : 2
Background       : 4
Unstarted        : 8
Stopped          : 16
WaitSleepJoin    : 32
Suspended        : 64
AbortRequested   : 128
Aborted          : 256
Stopped, Aborted : 272
*/
```

| 상태             | 십진수 | 이진수    |
| ---------------- | ------ | --------- |
| Running          | 0      | 000000000 |
| StopRequested    | 1      | 000000001 |
| SuspendRequested | 2      | 000000010 |
| Background       | 4      | 000000100 |
| Unstarted        | 8      | 000001000 |
| Stopped          | 16     | 000010000 |
| WaitSleepJoin    | 35     | 000100000 |
| Suspended        | 64     | 001000000 |
| AbortRequested   | 128    | 010000000 |
| Aborted          | 256    | 100000000 |



--------

## 동기화( Synchoronization)

애플리케이션을 구성하는 각 스레드들은 여러 가지 자원을 공유하는 경우가 많다. 따라서 스레드들이 정연하게 자원을 사용할 수 있도록 질서를 잡아야 한다.

**동기화( Synchoronization)**

스레드들이 순서를 갖춰 자원을 사용하게 하는 것으로 자원을 한번에 하나의 스레드가 사용하도록 보장하는 것이다.

- .NET에서는 lock키워드와 Monitor클래스를 제공한다. lock키워드가 사용에 편리하지만 Monitor클래스가 더 섬세한 동기화 기능을 제공한다.



### lock키워드

> **크리티컬 섹션 ( Critical Section )**
>
> 한번에 한 스레드만 사용할 수 있는 코드 영역

lock 키워드로 감싸기만해도 일반 코드를 크리티컬 섹션으로 바꿀 수 있다.

lock 키워드의 매개변수는 참조형 - public 키워드를 통해 외부접근이 가능한 lock(this), lock(typeof(SoneClass)), lock(obj.GetType()), lock("abc") 는 사용금지

```c#
class Counter
{
    public int count;
    public void Increase()
    {
        count = count + 1;
    }
}
//..
Counter obj = new Counter();
Thread t1 = new Thread(new ThreadStart(obj.Increase));
Thread t2 = new Thread(new ThreatStrat(obj.Increase));
Thread t3 = new Thread(new ThreatStrat(obj.Increase));

t1.Start();
t2.Start();
t3.Start();

t1.Join();
t2.Join();
t3.Join();
Console.WriteLine(obj.count);
```

```c#
class Counter
{
    public int count;
    public void Increase()
    {
        lock(thislock)			//lock키워드와 중괄호로 둘러싼 이 부분은 크리티컬섹션이 된다.
        {						//한 스레드가 이 코드를 실행하다가 lock블록이 끝나는 괄호를 만나기 전까지
        	count = count + 1; 	//다른 스레드는 절대 이 코드를 실행할 수 없다.
        }
    }
}
//..
Counter obj = new Counter();
Thread t1 = new Thread(new ThreadStart(obj.Increase));
Thread t2 = new Thread(new ThreatStrat(obj.Increase));
Thread t3 = new Thread(new ThreatStrat(obj.Increase));

t1.Start();
t2.Start();
t3.Start();

t1.Join();
t2.Join();
t3.Join();
Console.WriteLine(obj.count);
```



- 스레드가 locck키워드를 만나 크리티컬 섹션을 사용하는 동안, lock을 얻지 못한 다른 스레드들은 대기해야하는 상황이 벌어진다. 이는 소프트웨어의 성능을 떨어뜨리는 요인이 된다. 따라서 꼭 필요한 곳에만 사용할수 있도록 해야한다.
- lock키워드의 매개변수로 사용하는 객체는 참조형이면 어느 것이든 쓸 수 있지만, public 키워드를 통해 외부코드에서도 접근할 수 있는 다음 세가지는 절대 사용하지 않기를 권한다. 문법적으로 문제가 없지만 다른 자원을 사용해야 하는 스레드도 예기치 않게 대기하는 상황이 벌어질 수 있기 때문이다. 
  - this :  lock(this)
  - Type형식 : typef연산자나 object클래스로부터 물려받은 GetType() 메소드는 Type 형식의 인스턴스를 반환한다. 코드의 어느곳에서나 특정형식에 대한 Type 객체를 얻을 수 있다. lock(typeof(SomeClass)) 나 lock(obj.GetType())
  - string 형식 : lock("abc")



``` c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synchronize
{
    class Counter
    {
        const int LOOP_COUNT = 100;

        readonly object thisLock;

        private int count;
        public int Count
        {
            get { return count; }
        }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }
        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count++;
                }
                Thread.Sleep(1);
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                }
                Thread.Sleep(1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
/*
0
*/
```



### Monitor 클래스

**Monitor.Enter() :** 크리티켈 섹션을 만든다.

**Monitor.Exit() :** 크리티컬 섹션을 제거한다.

```c#
//lock
public void Increase()
{
    int loopCount = 1000;
    while(loopCount-- > 0)
    {
        lock(thislock){
            count++;
        }
    }
}

//Monitor.Enter() Monitor.Exit()
public void Increase()
{
    int loopCount = 1000;
    while(loopCount-- > 0 )
    {
        Monitor.Enter(thislock);
        try
        {
            count++;
        }
        finally
        {
            Monitor,Exit();
        }
    }
}
```

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingMonitor
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;

        private int count;
        public int Count
        {
            get { return count; }
        }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }
        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    count++;
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while(loopCount-- > 0)
            {
                Monitor.Enter(thisLock);
                try
                {
                    count--;
                }
                finally
                {
                    Monitor.Exit(thisLock);
                }
                Thread.Sleep(1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
/*
0
*/
```



**Monitor.Wait()** : 스레드를 WaitSleepJoin 상태로 만든다. WaitSleepJoin상태에 들어간 스레드는 동기화를 위해 lock을 내려놓고 Waitiing Queue라고 하는 큐에 입력된다.

**Monitor.Pulse() : ** Pulse()메소드를 호출하면 CLR은 Waiting Queue의 가장 첫 요소 스레드를 꺼낸 뒤 Ready Queue에 입력한다. Ready Queue에 입력된 스레드는 입력된 차례에 락을 얻어 Running 상태에 들어간다.

Monitor.Wait()와 Monitor.Pulse()는 단순히 lock키워드만을 사용할 때보다 더 섬세하게 멀티 스레드 간의 동기화를 가능하게 해준다. 두 메소드는 반드시 lock블로록안에서 호출해야한다.

![wait_pulse](https://user-images.githubusercontent.com/40557177/91267274-fbea0d80-e7ad-11ea-8107-ee5c42ca2be1.png)

```c#
// 1. 클래스 안에 다음과 같이 동기화 객체 필드를 선언합니다.
readonly object thisLock = new object();

// 2. 스레드를 WaitSleepJoin 상태로 바꿔 블록시킬 조건(Wait()를 호출할 조건)을 결정할 필드를 선언한다.
bool lockedCount = false;

// 3. 스레드를 블록시키고 싶은 곳에서는 다음과 같이 lock 블록 안에서 2. 에서 선언한 필드를 검사하여 Monitor,Wait()를 호출한다.
lock (thisLock)
{
    while (lockedCount == true)
        Monitor.Wait (thisLock);
    //..
}
/*
4. 3에서 선언한 코드는 count가 0보다 크거나 lockedCount가 true이면 해당 스레드는 블록된다.스레드가 깨어나면 작업을 진행한다. 2.에서 선언한 lockedCount의 값을 true로 변경한다. 이 작업으로 다른 스레드가 이 코드에 접근할 때 3.에서 선언해둔 블로킹코드에 걸려 같은 코드를 실행할 수 없게 된다.
작업을 마치면 lockedCount의 값을 다시 false로 바꾼 뒤 Monitor.Pulse()를 호출한다. 그럼 Waiting Queue에 대기하고 있던 다른 스레드가 깨어나서 false로 바뀐 lockedCount를 보고 작업을 수행한다.
*/
lock (thisLock)
{
    while(lockedCount == true)
        Monitor.Wait(thisLock);
    
    lockedCount = true;
    count++;
    lockedCount = false;
    
    Monitor.Pulse(thisLock);
}
```



```c#
using System;
using System.Net.Http.Headers;
using System.Threading;

namespace WaitPulse
{
    class Counter
    {
        const int LOOP_COUNT = 1000;
        readonly object thisLock;
        bool lockedCount = false;

        private int count;
        public int Count
        {
            get { return count; }
        }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }
        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count > 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count++;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count < 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();
            Console.WriteLine(counter.Count);
        }
    }
}
/*
0
*/
```



-----

----

# Task 와 Task< TResult >, Parallel

고성능 소프트웨어를 위해서 여러개의 코어가 동시에 작업할 수 있도록하는 병렬처리 기법과 비동기 처리기법이 필수적으로 필요하다.

.NET프레임워크 4.0 부터 도입된 System.Threading.Tasks 네임스페이스에는 병행성 코드나 비동기 코드를 쉽게 작성할 수 있도록 돕는 여러 클래스가 있다.

> **병렬 처리와 비동기 처리의 차이**
>
> 병렬 처리 : 하나의 작업을 여러 작업자가 나눠서 수행한 뒤 다시 하나의 결과로 만드는 것.
>
> 비동기 처리 : 작업 A를 시작한 후 A의 결과가 나올 때까지 대기하는 대신 곧이어 다른 작업을 수행하다가 작업 A가 끝나면 그 때 결과를 받아내는 처리 방식.



> **멀티 스레드와의 차이점**
>
> System.Threading.Tasks 네임스페이스의 클래스들은 하나의 작업을 쪼갠 뒤 쪼개진 작업들을 동시에 처리하는 코드와 비동기 코드를 위해 설계되었다.
>
> Thread클래스는 여러개의 작업을 ( 나누지 않고 ) 각각 처리해야 하는 코드에 적합하다.



----------

## System.Threading.Tasks.Task

비동기 코드를 쉽게 작성할 수 있도록 도와준다.

Task 클래스는 인스턴스를 생성할 때 Action 대리자를 넘겨받는다.

> **동기 코드와 비동기 코드**
>
> 동기코드는 검사가 칼을 사용할 때 처럼 동작한다. 검사가 검으로 상대를 찌른 뒤에 다시 칼을 뽑아야 칼을 사용할 수 있는 것처럼, 동기 코드는 메소드를 호출한 뒤에 이 메소드의 실행이 완전히 종료되어야만 ( 반환되어야만 ) 다음 메소드를 호출할 수 있다.
>
> 비동기코드는 궁수가 활을 쏠 때처럼 동작한다. 궁수는 화살을 쏘고 나면 바로 다음 화살을 쏠 준비를 할 수 있다. 이것을 Shoot(Fire) and Forget이라고 하는데 비동기 코드의 동작을 묘사할 때 자주 쓰이는 표현이다. 동기코드와 다르게 메소드를 호출한 뒤 메소드의 종료를 기다리지 않고 바로 다음 코드를 실행한다. 

```c#
//동기코드에서는 Slash() 메소드가 동기로 동작하고 실행시간이 1초라고 한다면 다음코드로 넘어가는데 모두 3초가 걸린다.

Swordman  obj = new Swordman();
obj.slash();
obj.slash();
obj.slash();
//...다음 코드

//비동기코드는 메소드의 종료를 기다리지 않고 다음코드를 실행한다. 
Archer obj = new Archer();
obj.Shoot();
obj.Shoot();
obj.Shoot();
//...다음 코드
```



```c#
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];

            Action<object> FilecopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine($"TaskID : {Task.CurrentId}, ThreadID : {Thread.CurrentThread}, {paths[0]} was copied to {paths[1]}");
            };

            Task t1 = new Task(FilecopyAction, new String[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FilecopyAction(new String[] { srcFile, srcFile + ".copt2" });
            });
            t1.Start();

            Task t3 = new Task(
                FilecopyAction, new String[] { srcFile, srcFile + ".copy3" });

            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();

        }
    }
}
/*
TaskID : 1, ThreadID : System.Threading.Thread, a.txt was copied to a.txt.copy1
TaskID : 2, ThreadID : System.Threading.Thread, a.txt was copied to a.txt.copt2
TaskID : 3, ThreadID : System.Threading.Thread, a.txt was copied to a.txt.copy3
*/
```





------

## Task< TResult > 클래스



```c#
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TaskResult
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;
            if( number %2 == 0 && number != 2 )
                return false;
            for(long i =2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            long from = Convert.ToInt64(args[0]);
            long to = Convert.ToInt64(args[1]);
            int taskCount = Convert.ToInt32(args[2]);

            Func<object, List<long>> FindPrimeFunc =
                (objRange) =>
                {
                    long[] range = (long[])objRange;
                    List<long> found = new List<long>();

                    for (long i = range[0]; i < range[1]; i++)
                    {
                        if (IsPrime(i))
                            found.Add(i);
                    }
                    return found;
                };


            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
            long currentFrom = from;
            long currentTo = to/tasks.Length;
            for(int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"Task[{i}] ; {currentFrom} ~ {currentTo}");
                tasks[i] = new Task<List<long>>(FindPrimeFunc,
                    new long[] { currentFrom, currentTo });
                currentFrom = currentTo + 1;

                if (i == tasks.Length - 2)
                    currentTo = to;
                else
                    currentTo = currentTo + (to / tasks.Length);
            }
            Console.WriteLine("Please press enter to start..");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            foreach (Task<List<long>> task in tasks)
                task.Start();

            List<long> total = new List<long>();

            foreach (Task<List<long>> task in tasks)
            {
                task.Wait();
                total.AddRange(task.Result.ToArray());
            }
            DateTime endTime = DateTime.Now;
            TimeSpan ellapsed = endTime - startTime;

            Console.WriteLine($"Prime number count between {from} and  {to} : {total.Count}");
            Console.WriteLine($"Ellapsed time : {ellapsed}");
        }
    }
}
/*
0  10000 1
Task[0] ; 0 ~ 5000
Please press enter to start..

Started...
Prime number count between 0 and  5000 : 669
Ellapsed time : 00:00:00.0120024

0 10000 5
Task[0] ; 0 ~ 1000
Task[1] ; 1001 ~ 2000
Task[2] ; 2001 ~ 3000
Task[3] ; 3001 ~ 4000
Task[4] ; 4001 ~ 5000
Please press enter to start..

Started...
Prime number count between 0 and  5000 : 669
Ellapsed time : 00:00:00.0070024
*/
```



-----------

## Parallel 클래스

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ParallelLoop
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;
            if (number % 2 == 0 && number != 2)
                return false;
            for(long i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            long from = Convert.ToInt64(args[0]);
            long to = Convert.ToInt64(args[1]);

            Console.WriteLine("Please press the enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started..");

            DateTime startTime = DateTime.Now;
            List<long> total = new List<long>();

            Parallel.For(from, to, (long i) =>
            {
                if (IsPrime(i))
                    total.Add(i);
            });
            DateTime endTime = DateTime.Now;

            TimeSpan ellapsed = endTime - startTime;
            Console.WriteLine($"Prime number count between {from} and {to} : {total.Count}");
            Console.WriteLine($"Ellapsed Time : {ellapsed}");
        }
    }
}
/*
Please press the enter to start...

Started..
Prime number count between 0 and 10000 : 1229
Ellapsed Time : 00:00:00.0120020
*/
```



---------

## async 한정자와 await 연산자

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count}...");
                    await Task.Delay(100);
                }
            });
            Console.WriteLine("G");
            Console.WriteLine("H");
        }
        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }
        static void Main(string[] args)
        {
            Caller();
            Console.ReadLine();
        }
    }
}
/*
A
B
C
D
E
F
1/3...
2/3...
3/3...
G
H
*/
```





