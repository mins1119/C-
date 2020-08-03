# DAY1												20.07.20



### Tutorial

#### 데이터 타입

| Data Type | Size                   |                           |
| --------- | ---------------------- | ------------------------- |
| int       | 4 bytes                |                           |
| long      | 8 bytes                | end the value with an "L" |
| float     | 4 bytes                | end the value with an "F" |
| double    | 8 bytes                | end the value with an "D" |
| bool      | 1 bit                  |                           |
| char      | 2 bytes                |                           |
| string    | 2 bytes per characters |                           |

`"e" indicate the power of 10`

`12e4 = 120000`



#### 형변환

Implict Casting (automatically)

char -> int -> long -> float -> double

```c#
int a = 9;
double b = a;
```



Explict Casting (manually)

double -> float -> long -> int -> char

```c#
double a = 9.78;
int b = (int) a;

Console.WriteLine(a);	//9.78
Console.WriteLine(b);	//9

int num = 9;
Console.WriteLine(Convert.ToString(num));
```



#### 입력받기

Console.ReadLine - string 으로 리턴

```c#
Console.WriteLine("Enter name");
string username = Console.ReadLine();
Console.WriteLine("user name is " + username);

Console.WriteLine("your age is :");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("your age is " + age);
```



#### 연산자

| 연산자 | 기능       | 예제  |
| ------ | ---------- | ----- |
| +      | 더하기     | x + y |
| -      | 빼기       | x - y |
| *      | 곱하기     | x * y |
| /      | 나누기     | x / y |
| %      | 나머지     | x % y |
| ++     | 1씩 더하기 | x++   |
| --     | 1씩 빼기   | x--   |

|      |         |            |
| ---- | ------- | ---------- |
| =    | x = 5   | x = 5      |
| +=   | x += 3  | x = x + 3  |
| -=   | x -= 3  | x = x - 3  |
| *=   | x *= 3  | x = x * 3  |
| /=   | x /= 3  | x = x / 3  |
| %=   | x%= 3   | x = x % 3  |
| &=   | x &= 3  | x = x & 3  |
| \|=  | \| != 3 | x = x \| 3 |
| ^=   | x ^= 3  | x = x ^ 3  |
| >>=  | x >>=3  | x = x >> 3 |
| <<=  | x <<= 3 | x = x << 3 |

|      |             |        |
| ---- | ----------- | ------ |
| ==   | 같음        | x == y |
| !=   | 같지 않음   | x != y |
| >    | 크다        | x > y  |
| <    | 작다        | x < y  |
| >=   | 크거나 같다 | x >= y |
| <=   | 작거나 같다 | x <= y |

|      |                               |                       |
| ---- | ----------------------------- | --------------------- |
| &&   | 조건들을 모두 만족하면  true  | x < 5 && x < 10       |
| \|\| | 조건중 하나라도 만족하면 true | x < 5 \|\| x > 10     |
| !    | 결과를 반대로 출력            | !( x < 5 \|\| x > 10) |



#### Math

|               |             |                             |
| ------------- | ----------- | --------------------------- |
| Math.Max(x,y) | 최대값찾기  | Math.Max( 5 , 10)    //10   |
| Math.Min(x,y) | 최소값찾기  | Math.Min( 5 , 10)    //5    |
| Math.Sqrt(x)  | 루트 반환   | Math.Sqrt(64)          //8  |
| Math.Abs(x)   | 절댓값 반환 | Math.Abs(-4.7)        //4.7 |
| Math.Round()  | 올림        | Math.Round(4.99)  //5       |



#### String



- ToUpper() / ToLower()

```
대문자 /소문자로 변환
```

- concat

```
문자열 결합
```

-  String[x]

```
x-1번째 문자 찾기
```

- String.IndexOf("A")

```
"A"가 포함된 인덱스번호 출력
```

```c#
string txt = "Alice";
Console.WriteLine("The length of txt string is : " + txt.Length);	//5

Console.WriteLine(txt.ToUpper());									//ALICE
Console.WriteLine(txt.ToLower());									//alice

string firstname = "Alice";
string lastname = "Liddel";
string fullname = string.Concat(firstname, lastname);
Console.WriteLine(fullname);										//Alice Liddel

Console.WriteLine("My name is {0} {1}", firstname, lastname);		//My name is Alice Liddel
//$를 넣으면 중괄호 안에 직접 변수를 입력할 수 있다
string name = $"My name is : {firstname} {lastname}";
Console.WriteLine(name);									//My name is Alice Liddel

Console.WriteLine(txt[0]);									//A
Console.WriteLine(txt[1]);									//l

Console.WriteLine(txt.IndexOf("e"));						//4

int charPos = fullname.IndexOf("L");					
string last = fullname.Substring(charPos);
Console.WriteLine(last);									//Liddel
```



#### 반복문

##### If....Else

```
if (condition)
{		}
else if
{		}
else
{		}
```

###### Short If...Else

```
variable = (condition) ? expressionTrue : expressionFalse;
```



##### Switch

```c#
switch(expression)
{
	case x:
		//code
		break;
	case y:
		//code
		break;
	default:
		//code
		break;
}
```

##### LOOP

###### While Loop

```c#
while (condition)
{
	//code
}
```

###### Do/While Loop

  조건문을 체크하기 전에 실행코드를 수행한 뒤, 조건문이  true이면 실행 반복

```c#
do
{
    //code
}
while(condition);
```

###### For Loop

```c#
for( statement1 ; statement 2; statement 3){
    //code
}
```

###### The foreach Loop

```c#
Foreach (type variableName in arrayName){
    //code
}
```

#### Arrays

```c#
string[] cars = { "volvo", "BMW", "Ford" };
cars[0] = "Opel";
Console.WriteLine(cars.Length);		//

foreach (string car in cars) {
    Console.WriteLine(car);}		//Opel, BMW, Ford
```

- Length

```c#
배열 길이 구하기

string[] cars = { "volvo", "BMW", "Ford" };
cars[0] = "Opel";
Console.WriteLine(cars.Length);			//4
```

- Sort

```c#
배열 정렬

string[] cars = { "volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
	Console.WriteLine(i);		//BMW, Ford, Mazda, volvo
}
```

- System.Linq

```c#
int[] num = { 5, 1, 8, 9 };
Console.WriteLine(num.Max());			//9	
Console.WriteLine(num.Min());			//1
Console.WriteLine(num.Sum());			//23
```



### Methods

#### Method

```c#
static void Main(string[] args)
{
    MyMethod();			//여러번 호출도 가능하다.
}

static void MyMethod()
{
    Console.WriteLine("I got executed");
}
```

#### Method Parameter

```c#
static void Main(string[] args)
{
    MyMethod("LIsa");			//Lisa refsnes
    MyMethod("Alice");			//Alice refsnes
}

static void MyMethod(string fname)
{
    Console.WriteLine(fname +" Refsnes");
}
```

##### default parameter

```c#
static void Main(string[] args)
{
    MyMethod("LIsa");			//Lisa refsnes
    MyMethod("Alice");			//Alice refsnes
    MyMethod();					//Ann refsnes
}

static void MyMethod(string fname = "Ann")
{
    Console.WriteLine(fname +" Refsnes");
}
```

##### Method Overloading

같은 이름의 메소드를 다른 파라미터들을 이용하여 사용할 수 있다.

```c#
static void Main(string[] args)
{
    int mynum = PulseMethod(3, 5);
    double mynum2 = PulseMethod(4.25, 2.5);

    Console.WriteLine("Int:" + mynum);			//Int: 8
    Console.WriteLine("Double: " + mynum2);		//Double: 6.75
}

static int PulseMethod(int x, int y)
{
    return x + y;
}
static double PulseMethod( double x, double y)
{
    return x + y;
}
```



### Classes

#### OOP

= Object-Oriented Programming

- OOP is faster and easier to execute
- OOP provides a clear structure for the programs
- OOP helps to keep the C# code DRY -"Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
- OOP makes it possible to create full resuable applications with less code and shorter development time

#### classes and object

```c#
 class Car
 {
     string color = "red";

     static void Main(string[] args)
     {
         Car myobj = new Car();		//복수 호출 가능
         Console.WriteLine(myobj.color);		//red
     }
 }
```

```c#
class Car
{
    string color = "blue";
    int maxspeed = 200;
    static void (string[] args)
    {
        Car myobj = new Car();
        Console.WriteLine(myobj.color);
        Console.WriteLine(myobj.maxspeed);
    }
}
```

```c#
class Car
{
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1696;

        Car Opel = new Car();
        Opel.model = "Astar";
        Opel.color = "blue";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);		//Mustang
        Console.WriteLine(Opel.model);		//Astar
    }
}
```

#### Constructors

```c#
class Car
{
    public string model;

    public Car()
    {
        model = "Mustang";
    }
    static void Main(string[] args)
    {
        Car Ford = new Car();
        Console.WriteLine(Ford.model);
    }
}
```



```c#
class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color+" "+Ford.model+" "+Ford.year);
        }
    }
```

#### Acess Modifiers

| 접근 제한자        | 설명                                                         |
| ------------------ | ------------------------------------------------------------ |
| private            | 클래스 내부에서만 접근이 가능                                |
| public             | 모든 곳에서 해당 멤버로 접근이 가능                          |
| internal           | 같은 어셈블리에서만 public으로 접근이 가능                   |
| protected          | 클래스 외부에서 접근 할 수 없으나 파생 클래스에서는 접근이 가능 |
| protected internal | 같은 어셈블리에서만 protected로 접근이 가능                  |

#### Properties (Get and Set)

이해 후 추가

#### Inheritance

```c#
class Vehicle //base class (parent)
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut,tuut!");
    }
}

class Car : Vehicle //derived class
{
    public string modelName = "Mustang";
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.honk();

        Console.WriteLine(myCar.brand + " " + myCar.modelName);		//Ford \n Mustang
    }
}
```

sealed : 상속을 원치 않는 클래스 앞에

```c#
seales class Vehicle //base class (parent)
{
 ...
}

class Car : Vehicle //오류 상속 불가
{

}
```

####  Polymorphism ( 다형성 )

```c#
class Animal //parent
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal // chils
{
    public void animalSound()
    {
        Console.WriteLine("The pig says : wee wee");
    }
}
class Dog : Animal //child
{
    public void animalSound()
    {
        Console.WriteLine("The dog says : bow bow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myPig = new Pig();
        Animal myDog = new Dog();

        myAnimal.animalSound();				//The animal makes a sound
        myPig.animalSound();				//The animal makes a sound
        myDog.animalSound();				//The animal makes a sound
    }
}
```

virtual	override

```c#
class Animal //parent
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal // chils
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says : wee wee");
    }
}
class Dog : Animal //child
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says : bow bow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myPig = new Pig();
        Animal myDog = new Dog();

        myAnimal.animalSound();			//The animal makes a sound
        myPig.animalSound();			//The pig says : wee wee
        myDog.animalSound();			//The dog says : bow bow
    }
}
```

#### Abstraction

여러개의 파생클래스에서 공유할 기본클래스의 공통적인 정의를 제공

```c#
abstract class Animal
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("zzz");
    }
}

class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();				//The pig says: wee wee
        myPig.sleep();						//ZZZ
    }
}
```

#### Interface

멤버필드(변수)를 사용할 수 없다. 여러 클래스에 공통적인 기능을 추가하기 위해 사용

```c#
interface IAnimal
{
    void animalSound();
}
class Pig : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("The pig says : wee wee");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();
        myPig.animalSound();		//The pig says : wee wee
    }
}
```

```c#
interface IFirstInterface		
{
    void myMethod();
}

interface ISecondInterface
{
    void myOtherMethod();
}
class DemoClass : IFirstInterface,ISecondInterface	//여러개의 인터페이스 상속 가능
{
    public void myMethod()
    {
        Console.WriteLine("some tsxt ... ");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some Other text,,");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DemoClass obj = new DemoClass();
        obj.myMethod();					//some tsxt ...
        obj.myOtherMethod();			//Some Other text,,
    }
}
```

#### Enums

Enum (열거형)



이해 후 추후 추가 예정



#### Exceptions

Try...Catch

try 와 catch는 쌍으로 온다. try는 시도할 코드, catch는 에러가 발생했을 시 실행할 코드

```c#
 static void Main(string[] args)
 {
     try
     {
         int[] num = { 1, 2, 3 };
         Console.WriteLine(num[10]);
     }
     catch(Exception e)
     {
         Console.WriteLine(e.Message);		//Index was outside the bounds of the array.
     }
 }
```



Finally try...catch의 결과에 상관없이 실행되는 코드

```c#
static void Main(string[] args)
{
    try
    {
        int[] num = { 1, 2, 3 };
        Console.WriteLine(num[10]);
    }
    catch(Exception e)
    {
        Console.WriteLine("Something wrong");
    }
    finally
    {
        Console.WriteLine("try...catch is finished");
    }
}
```

Thorw Keyword 에러 항목을 커스텀 할 수 있다.

