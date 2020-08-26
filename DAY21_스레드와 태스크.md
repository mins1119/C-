# 스레드와 태스크			 20.08.26

## 프로세스와 스레드

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



## 스레드

.NET 프레임워크에서는 스레드를 나타내는 클래스로 System.Threading.Thread를 제공한다.



### 스레드 시작하기

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

### 스레드 종료

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

### 스레드의 상태변화