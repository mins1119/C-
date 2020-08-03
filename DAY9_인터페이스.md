# DAY9 - 10										20.07.31 - 03

## 인터페이스

### 선언

```c#
interface 인터페이스 이름
{
    반환 형식 메소드이름1 ( 매개 변수 목록 );
    반환 형식 메소드이름2 ( 매개 변수 목록 );
    반환 형식 메소드이름3 ( 매개 변수 목록 );
    // . . .
}
```

- 인터페이스는 메소드, 이밴트, 인덱서, 프로퍼티만 가질 수 있지만, 구현부가 없다.

- 클래스는 접근 제한 한정자로 수식하지 않으면 기본적으로 private로 선언이 되지만, 인터페이스는 접근 제한 한정자를 사용할 수 없고, 모든것이 public으로 선언된다. 

- 인터페이스는 인스턴스를 가질 수 없지만, 이 인터페이스를 상속받는 클래스의 인스턴스를 만드는 것은 가능하다.

- 인터페이스는 참조는 만들 수 있다.


```c#
using System;
using System.IO;

namespace Interface
{
    interface Ilogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : Ilogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }
    class FileLogger : Ilogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }
    class ClimateMonitor
    {
        private Ilogger logger;
        public ClimateMonitor(Ilogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.WriteLine("온도를 입력해주세요 : ");
                string temperatrue = Console.ReadLine();
                if (temperatrue == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperatrue);
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));

            monitor.start();
        }
    }
}

```

### 상속

- 상속하려는 인터페이스가 소스코드가 아닌 에셈블리로만 제공되는 경우
- 상속하려는 인터페이스의 소스코드를 갖고있어도 이미 인테페이스를 상속하는 클래스들이 존재하는 경우

에 인터페이스를 상속하는 인터페이스를 만들어야 한다.

```c#
interface 파생인터페이스 : 부모 인터페이스
{
    // .. 추가할 코드 목록
}
```

```c#
using System;

namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger
        //IformattableLogger 은 void WriteLog(string message)와 void WriteLog(string message, params Object[] args) 두개를 갖는다.
    {
        void WriteLog(string format, params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("Set the world on fire");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}
```



클래스는  프로그램의 모호성을 방지하고자 다중상속이 금지되어있다.

**죽음의 다이아몬드**

![스크린샷(24)](https://user-images.githubusercontent.com/40557177/89138422-8906c180-d576-11ea-8572-c38bef450205.png)

하나의 할아버지 클래스를 두 개의 파생클래스가 상속하고, 이 두개의 파생클래스를 다시 하나의 자식 클래스가 상속하는 것



```c#
using System;

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run!");
        }
        public void Fly()
        {
            Console.WriteLine("fly");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
/*
Run!
fly
Run!
fly
*/
```

### 추상클래스

추상클래스는 인터페이스와 달리 구현을 가질 수 있지만, 클래스와 달리 인스턴스를 가질 수는 없다.

추상 메소드를 가진다.



#### 추상 메소드

추상클래스를 상속하는 클래스들에게 반드시 구현하도록 강제한다.

네 가지 한정자 ( public, protected, internal, protected internal) 중 하나로 수식된다.

```c#
abstract class 클래스이름
{
    //클래스와 동일하게 구현
}
```

```c#
using System;

namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
/*
Derived.AbstractMethodA()
AbstractBase.PrivateMethodA()
AbstractBase.PublicMethodA()
*/
```

