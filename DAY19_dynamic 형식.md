# dynamic 형식			20.08.20

## dynamic형식

- dynamic형식도 int, string 과 같은 하나의 데이터 형식이다.

- 다만 형식검사가 컴파일할 때 이루어지는 다른형식과는 달리 형식검사가 프로그램 실행중에 이루어진다는 점이 다르다.

```c#
class MyClass
{
    public void FuncAAA()
    {
        //do nothing
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.FuncAAA();
        obj.FuncBBB();	//MyClass에 정의되어있지 않으므로 컴파일 에러발생
    }
}
/***********************************************************************************************************/
class MyClass
{
    public void FuncAAA()
    {
        //do nothing
    }
}
class Program
{
    static void Main(string[] args)
    {
        dynamic obj = new MyClass();
        obj.FuncAAA();
        obj.FuncBBB();	//dynamic 형식은 일탄 컴파일러의 형식검사를 피해간다.
    }
}
```

## 오리 타이핑

> "오리처럼 걷고 오리처럼 헤엄치며 오리처럼 꽉꽉거리는 새를 봤을 대, 나는 그 새를 오리라고 부른다."		- 제임스 위트콤 라일리

- 오리 타이핑에서는 어떤 형식이 오리로 인정받으려면 어느 형식으로부터 상속받는지는 중요하지 않고, 오리처럼 걷고, 오리처럼 꽉꽉거리고, 오리처럼 헤엄치기만 하면된다.
- C# 컴파일러에 오리 타이핑 철학을 적용시키기 위해 형식검사를 미루는 dynamic형식을 사용한다.
- 오리타이핑은 인터페이스와 비슷한 일을 하지만, 인터페이스에 비해 수정이 간편하다는 장점이 있다.
- 비주얼 스튜디오의 리팩토링 기능을 사용할 수 없다.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTyping
{
    class Duck
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + ".Walk");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType() + ".Swim");
        }
        public void Quack()
        {
            Console.WriteLine(this.GetType() + ".Quack");
        }
    }
    class Mallard : Duck
    { }
    class Robot
    {
        public void Walk()
        {
            Console.WriteLine("Robot.Walk");
        }
        public void Swim()
        {
            Console.WriteLine("Robot.Swim");
        }
        public void Quack()
        {
            Console.WriteLine("Robot.Quack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //duck[] arr = new Duck[]{new Duck(), new Mallard(), new Robot()};
            //암시적으로 DuckTyping.Robot 형식을 DuckTyping.Duck 형식으로 변환할 수 없습니다.
            dynamic[] arr = new dynamic[]{new Duck(), new Mallard(), new Robot()};

            foreach(dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Quack();

                Console.WriteLine();
            }
        }
    }
}
/*
DuckTyping.Duck
DuckTyping.Duck.Walk
DuckTyping.Duck.Swim
DuckTyping.Duck.Quack

DuckTyping.Mallard
DuckTyping.Mallard.Walk
DuckTyping.Mallard.Swim
DuckTyping.Mallard.Quack

DuckTyping.Robot
Robot.Walk
Robot.Swim
Robot.Quack
*/
```

## COM 과  .NET 사이의 상호 운용성을 위한 dynamic 형식

> COM 이란?
>
> COM 은 Component Object Model의 약자로, 마이크로소프트 소프트웨어 컴포넌트 규격을 말한다.

C#을 비롯한 .NET언어들은 RCW( Runtime Code Wrapper )를 통해 COM컴포넌트를 사용할 수 있다. 하지만 C#은 RCW가 있음에도 다음 두가지 이유로 사용하기가 어려웠다.

1. COM은 메소드가 결과를 반환할 때 실제형식이 아닌 object로 반환하기 때문에, c#에서는 이 결과를 실제 형식으로 변환을 해줘야 하는 번거로움이 있었다.
2. COM은 오버로딩을 지원하지 않고, 메소드의 선택적 매개변수와 기본값 매개변수를 지원한다. C#은 4.0전까지 선택적 매개변수와 기본값 매개변수를 지원하지 못했기 때문에 COM API 하나를 호출하기 위해 사용하지 않을 수많은 매개변수를 입력해야 했다.

하지만 dynamic형식으로 1번을 해결하고, 선택적 매개변수와 기본값 매개변수를 통해 2번을 해결함으로서 COM친화적인 언어가 되었다.



 **C#으로 엑셀파일 출력하기**

1. 새 프로젝트 생성
2. 솔루션 탐색기에서 '참조' 항목 마우스 우클릭 후, [참조 추가] 항목 선택
3. 창의 왼편에서 [COM] -> [향식 라이브러리] 항목을 선택하고 구성요소에서 'Microsoft Excel xx.x(버전에 따라 다름) Object Library' 를 선택한 후 확인.
4. 성공적으로 추가 되었다면 '참조'항목에 'Microsoft.Office.Core' 어셈블리와 'Microsoft.Office.Interop.Excel'어셈블리가 추가된다.

```c#
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMInterop
{
    class MainApp
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
           
            for(int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)workSheet.Cells[ i + 1 , 2]).Value2 = data[i, 0];
            }
            workSheet.SaveAs(savePath + "\\book-old.xlsx",
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
            excelApp.Quit();
        }
        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            for(int i=0; i< data.GetLength(0); i++)
            {
                workSheet.Cells[i + 1, 1] = data[i, 0];
                workSheet.Cells[i + 1, 2] = data[i, 1];
            }
            workSheet.SaveAs(savePath + "\\book-dynamic.xlsx");
            excelApp.Quit();
        }
        static void Main(string[] args)
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                {"Alice in Wonderland" ,"Alice"},
                {"Transformers Dark of the moon","Bumblebee" },
                {"Bumblebee" ,"Bumblebee"},
                {"Transformers MTMTE", "Megatron" }
            };

            Console.WriteLine("Creating Excel document in oldway...");
            OldWay(array, savePath);

            Console.WriteLine("Creating Excel document in newway...");
            NewWay(array, savePath);
        }
    }
}

```

## 동적 언어와의 상호 운용성을 위한 dynamic형식

CRL( Common Language Runtime )은 IL( Intermediate Language )로 컴파일할 수 있는 언어들은 지원하지만, 파이썬이나 루비와 같이 실행할 때 코드를 해석해서 실행하는 방식의 동적언어는 지원할 수 없었다. 마이크로 소프트는 동적언어를 실행할 수 있는 플랫폼인 DLR (Dynamic Language Runtime )을 선보였다. 

DLR은 CLR위에서 동작하며, 동적언어를 실행할 수 있다. 또한 동적언어의 코드에서 만들어진 객체에 C# 이나 VB와 같은 정적언어의 코드에서 접근할 수 있게 해준다. 즉, C#코드에서 루비나 파이썬코드를 실행하고 돌려볼 수 있다.

