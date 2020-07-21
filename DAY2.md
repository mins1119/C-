# DAY2												20.07.21

**어셈블리어** 

복잡한 기계명령을 사람이 이해할 수 있는 기호나 단어로 바꿔만든것

이 어셈블리어는 변환가정을 거쳐 컴퓨터가 이해하는 기계어 코드로 변환되는데 이를 컴파일이라고 한다.



**.NET(닷넷)**

 인터넷 서비스를 모든 종류의 기기에서 사용할수도록하는 마이크로소프트의 플랫폼



**네임스페이스**

 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 대리자 , 열거  형식 등을 하나의 이름아래 묶는 일을 한다.

**클래스**

 C#을 구성하는 기본 단위로서 데이터와 데이터를 처리하는 기능으로 이루어진다.

**static void Main(string[] args)  메소드**

프로그램의 진입점으로서 프로그램을 시작하면 반드시 실행되고 , 이 메소드가 종료시 프로그램도 종료된다. 

모든 프로그램은 Main이라는 이름을 가진 메소드를 하나 가지고 있어야한다.



**CLR(Common Language Runtime)** 

 C#으로 만든 프로그램이 실행되는 환경이다. C#뿐만아니라 CLS규격을 따르는 모든 언어를 지원한다. 언어를 동작시키는 환경 기능외에도 프로그램의 오류가 발생했을대 이를 처리하도록 도와주는 기능, 언어간의 상속 지원, COM과의 상호 운영성 지원, 자동메모리 관리 등의 기능을 제공한다



### 변수

리터럴 고정값으 나타내는 표기법

 ```c#
int a = 100; 				//리터럴 : 100
int b = 0X200;				//리터럴 : 0x200
 ```



#### 값 형식과 참조 형식

값 형식(Value Types)은 변수가 값을 담는 데이터 형식

참조형식(Reference Types) 은 변수가 값 대신 값이 있는곳의 위치(참조)를 담는 데이터 형식



스택

코드블록 안에서 생성된 모든 값 형식의 변수들은 스택에 저장되고 프로그램 실행이 '}'를 만나면 메모리에서 제거된다.

힙

코드블록이 종료되는 시점과는 상관없이 남아있다가. 더이상 사용하지 않을때 가비지컬렉터가 수거

가비지 컬렉터(Garbag Collector)는 프로그램 뒤에 숨어 힙에 더이상 사용하지 않는 객체가 있으면 그 객체를 쓰레기로 간주하고  수거하는 기능



#### 기본 데이터 형식

##### 정수 계열 형식

| 데이터 형식 | 설명                         | 크기(바이트) | 담을수 있는 값의 범위                               |
| ----------- | ---------------------------- | ------------ | --------------------------------------------------- |
| byte        | 부호 없는 정수               | 1 (8비트)    | 0 - 255                                             |
| sbyte       | signed byte                  | 1 (8비트)    | -128 - 127                                          |
| short       | 정수                         | 2 (16비트)   | -32,786 - 32,767                                    |
| ushort      | unsigned short 부호없는 정수 | 2 (16비트)   | 0 - 65,535                                          |
| int         | 정수                         | 4 (32비트)   | -2,147,483,648 - 2,147,483,647                      |
| uint        | unsigned int 부호없는 정수   | 4 (32비트)   | 0 - 4,294,967,295                                   |
| long        | 정수                         | 8 (64비트)   | -922,337,203,685,477,508 - 922,337,203,685,,477,507 |
| ulong       | unsigned long 부호 없는 정수 | 8 (64비트)   | 0 - 18,447,744,073,709,551,615                      |
| char        | 유니코드 문자                | 2 (16비트)   |                                                     |

```c#
static void Main(string[] args) 
{
    sbyte a = -10;
    byte b = 40;

    Console.WriteLine($"a = {a}, b ={b}");

    short c = 30000;
    ushort d = 60000;

    Console.WriteLine($"c = {c}, d ={d}");

    int e = -1000_0000;
    uint f = 3_0000_0000;

    Console.WriteLine($"e = {e}, f ={f}");

    long g = -5000_0000_0000;
    ulong h = 200_0000_0000_0000_0000;

    Console.WriteLine($"g = {g}, h ={h}");
}
```

2의보수 구하기

1. 전체비트를 반전시킨다.
2. 1을 더한다.



##### 부동 소수점 형식

소수점이 고정되어있지 않고 움직이면서 수를 표현한다.

부동소수점이 정수를 대체하지 못하는 이유

1. 부동 소수점 형식은 소수점을 표현하기 위해 일부비트를 사용하기 때문에 같은 크기의 정수 계열 형식과 같은 수를 표현 할 수 없다.
2. 산술연간과정이  정수계열 형식보다 복잡해서 느리다.

| 데이터 형식 | 설명                                                         | 크기 (바이트) | 범위                                         |
| ----------- | ------------------------------------------------------------ | ------------- | -------------------------------------------- |
| float       | 단일 정밀도 부동 소수점 형식(7개의 자릿수만 다룰 수 있음)    | 4 (32비트)    | -3.402823e38 ~ 3.402823e38                   |
| double      | 복수 정밀도 부동 소수점 형식(15~16개의 자릿수를 다룰 수 있음) | 8 (64비트)    | -1.79769313486232e308 ~ 1.79769313486232e308 |

float은 굉장히 넓은 범위의 수를 다루지만 유효숫자는 7자리밖에 되지 않는다. 7자리 이상의 수는 대략적으로 표현하고 이를 "한정된 정밀도"를 가진다고 한다. float에 비해 두 배의 메모리를 가지는 double 형식을 복수 정밀도를 가지는 부동소수점 형식이라고 한다.



#####  Decimal 형식

부동 소수점보다 정밀도가 훨씬 높다.

| 테이터 형식 | 설명                                     | 크기 (바이트) | 범위                        |
| ----------- | ---------------------------------------- | ------------- | --------------------------- |
| decimal     | 29자리 데이터를 표현할 수 있는 소수 형식 | 16 (128비트)  | 1.0  X 10e-28 ~ 7.9 X 10e28 |

```c#
 static void Main(string[] args) 
 {
     float a = 3.1415_9265_3598_7923_9265_3598_7923_9846f;
     Console.WriteLine(a);					//3.1415927

     double b = 3.1415_9265_3598_7923_9265_3598_7923_9846;
     Console.WriteLine(b);					//3.1415926535987926

     decimal c = 3.1415_9265_3598_7923_9265_3598_7923_9846m;
     Console.WriteLine(c);					//3.1415926535987923926535987924
 }
```

##### char 형식과 string 형식

char 형식은 ''(작은따옴표)를 사용하여 문자 데이터를 다룬다.

string 형식은 ""(큰 따옴표)를 사용하여 문자열 데이터를 다룬다.

```c#
static void Main(string[] args) 
{
    char a = 'H';
    char b = 'e';
    char c = 'l';
    char d = 'l';
    char e = 'o';

    string text = "Hello";

    Console.WriteLine(a);				//H
    Console.WriteLine(b);				//e
    Console.WriteLine(c);				//l
    Console.WriteLine(d);				//l
    Console.WriteLine(e); 				//o
    Console.WriteLine(text);			//Hello
}
```



##### 논리 형식

| 데이터 형식 | 설명      | 크기      | 범위        |
| ----------- | --------- | --------- | ----------- |
| bool        | 논리 형식 | 1 (8비트) | True, False |

bool 형식은 참(True : 1)과 거짓(False : 0)만을 다루기 때문에 1비트만으로도 표현이 가능하겠지만, 컴퓨터가 기본적으로 다루는 데이터의 크기가 바이트 단위이기 때문에 1비트만 저장하려 해도 한 바이트가 통재로 사용된다.



##### Object 형식

모든 데이터 형식은 자동으로 object 형식으로부터 상속받는다.

따라서 컴파일러는 어떤 형식의 데이터라도 object에 담아 처리 할 수가 있다.

```c#
static void Main(string[] args) 
{
    object a = "Hello";
    object b = 123;
    object c = true;

    Console.WriteLine(a);			//Hello
    Console.WriteLine(b);			//123
    Console.WriteLine(c);			//True

}
```



##### 박싱과 언박싱

object 형식은 참조형식이기 때문에 힙에 데이터를 할당한다. int, double의 경우 값 형식이기 때문애 스택에 데이터를 할당한다. 



object 형식은 값 형식의 데이터를 힙에 할당하기 위한 "Boxing"기능을 제공한다. object 형식에 값 형식의 데이터를 할당하려고 하면 object형식은 "박싱"을 수행해서 해당 데이터를 힙에 할당한다. 박싱되어 있는 값을 거냐 값 형식 변수에 저장하는 과정을 일컬어서 "언박싱(unboxing)" 이라고 한다.

```c#
static void Main(string[] args) 
{
    int a = 123;
    object b = (object)a;   //a에 담긴 값을 박싱해서 힙에 저장
    int c = (int)b;         //b에 담긴 값을 언박싱해서 스택에 저장

    Console.WriteLine(a);		//123
    Console.WriteLine(b);		//123
    Console.WriteLine(c);		//123
    double x = 3.1414213;
    object y = x;           //x에 담긴 값을 박싱해서 힙에 저장
    //object 형식에 형식변환 연산자를 지정하지 않으면 암시적으로 object 형식으로 변환한다.
    object z = (double)y;   //y에 담긴 값을 언박싱해서 스택에 저장

    Console.WriteLine(x);		//3.1414213
    Console.WriteLine(y);		//3.1414213
    Console.WriteLine(z);		//3.1414213

}
```



##### 데이터 형식 바꾸기

###### 크기가 서로 다른 정수 형식 사이의  변환

```c#
static void Main(string[] args) 
{
    sbyte a = 127;      //1바이트크기
    Console.WriteLine(a);	//127

    int b = (int)a;     //4바이트 크기
    Console.WriteLine(b);	//127

    int x = 128;        //sbyte의 최대값127 보다 1큰 수
    Console.WriteLine(x);	//128

    sbyte y = (sbyte)x;     //오버플로우 발생
    Console.WriteLine(y);	//-128

}
```

오버플로우

데이터 형식의 최대값을 넘어가는 데이터를 저장하면 발생하는 현상



###### 크기가 서로 다른 부동 소수점 형식 사이의 변환

부동소수점의 특성상 오버플로우는 일어나지 않는다. 대신 정밀성에 손상을 입는다.

```c#
static void Main(string[] args)
{
    float a = 69.6875f;
    Console.WriteLine("a : {0}", a);		//a : 69.6875

    double b = (double)a;
    Console.WriteLine("b : {0}", b);		//b : 69.6875

    Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);	//69.6875 == b : True

    float x = 0.1f;
    Console.WriteLine("x : {0}", x);		//x : 0.1

    double y = (double)x;
    Console.WriteLine("y : {0}", y);		//y : 0.10000000149011612

    Console.WriteLine("0.1 == y : {0}", 0.1 == y);	//0.1 == y : False

}
```

###### 부동 소수점과 정수 형식 사이의 변환

소수점 아래의 값은 버리고 소수점 위의 값만 남는다.

```c#
static void Main(string[] args)
{
    float a = 0.9f;
    int b = (int)a;
    Console.WriteLine(b);		//0

    float c = 1.1f;
    int d = (int)c;
    Console.WriteLine(d);		//1
}
```

###### 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환

```c#
static void Main(string[] args)
{
    int a = 500;
    Console.WriteLine(a);			//500

    uint b = (uint)a;
    Console.WriteLine(b);			//500

    int x = -30;
    Console.WriteLine(x);			//-30	
	
    uint y = (uint)x;				//언더플로우
    Console.WriteLine(y);			//4294967266
}
```

###### 문자열 형식과 숫자 형식 사이의 변환

```c#
static void Main(string[] args)
{
    int a = 123;
    string b = a.ToString();
    Console.WriteLine(b);		//123

    float c = 3.14f;
    string d = c.ToString();
    Console.WriteLine(d);		//3.14

    string e = "123456";
    int f = Convert.ToInt32(e);
    Console.WriteLine(f);		//123456

    string g = "1.234";
    float h = float.Parse(g);
    Console.WriteLine(h);		//1.234
}
```

#### 상수와 열거 형식

**상수**

상수는  cosnt 키워드가 위치하고 값을 반드시 선언해야한다. 상수는 변수와 동일하게 사용이 가능하지만 값을 바꿀수는 없다.

**열거 형식**

const 키워드 대신 enum 키워드를 사용한다. 열거 형식의 각  요소는 중복되지 않은 값을 가진다.

```c#
class MainApp
{
    enum Dialogresult { YES, NO, CANCEL}
    static void Main(string[] args)
    {
        Console.WriteLine((int)Dialogresult.YES);		//0
        Console.WriteLine((int)Dialogresult.NO);		//1
        Console.WriteLine((int)Dialogresult.CANCEL);	//2
    }
}
```

DialogResult의 요소에 어떤 값도 주지 않으면,  컴파일러가 자동으로 첫번째 요소는 0, 두번째 요소는 1...이런식으로 선언된 순서에 따라 1씩 증가된 값을 할당한다.

```c#
class MainApp
{
    enum Dialogresult { YES, NO = 10, CANCEL = 20,CONFIRM = 50, OK}
    static void Main(string[] args)
    {
        Console.WriteLine((int)Dialogresult.YES);		//0
        Console.WriteLine((int)Dialogresult.NO);		//10
        Console.WriteLine((int)Dialogresult.CANCEL);	//20
        Console.WriteLine((int)Dialogresult.CONFIRM);	//50
        Console.WriteLine((int)Dialogresult.OK);		//51
    }
}
```

각 요소를 직잡 지정할 수 있다. 값을 지정하고 그 다음값을 지정하지 않으면 자동으로 1이 커진 숫자가 배정된다.

#### Nullable 형식

Nullable은 "비어있는 상태가 될 수 있는" 형식이라는 뜻을 나타낸다. Nullable 의 변수는 값 형식에 한해 사용이 가능하고, 선언할 때는 원래 데이터형식의 이름 뒤에 "?"를 붙여주면 된다.

```c#
static void Main(string[] args)
{
    int? a = null;

    Console.WriteLine(a.HasValue);		//False
    Console.WriteLine(a != null);		//False

    a = 3;
    Console.WriteLine(a.HasValue);		//True
    Console.WriteLine(a != null);		//True
    Console.WriteLine(a.Value);			//3
}
```

Nullable 형식은   HasValue 와 Value 두 가지 속성을 갖고있다.

HasValue 속성은 해당 변수가 값을 가지고 있는지 안갖고있는지를 나타내고 ,

Value 속성은 변수에 담겨있는 값을 나타낸다.

#### Var

var 을 사용하여 변수를 선언하면 컴파일러가 자동으로 해당 변수의 형식을 지정해준다.

var은 지역변수로만 사용할 수 있다.

```c#
static void Main(string[] args)
{
    var a = 20;
    Console.WriteLine("Type :{0}, Value : {1}", a.GetType(), a);
		//Type :System.Int32, Value : 20
    var b = 3.141213;
    Console.WriteLine("Type :{0}, Value : {1}", b.GetType(), b);
		//Type :System.Double, Value : 3.141213
    var c = "Hello";
    Console.WriteLine("Type :{0}, Value : {1}", c.GetType(), c);
		//Type :System.String, Value : Hello
}
```

### 문자열 다루기

#### 문자열 안에서 찾기

| 메소드        | 설명                                                         |
| ------------- | ------------------------------------------------------------ |
| IndexOf()     | 현재 문자열 내에서 찾고자 하는 문자 또는 문자열의 위치를 찾는다. |
| LastIndexOf() | 현재 문자열 내에서 찾고자 하는 문자 또는 문자열의 위치를 뒤에서부터 찾는다. |
| StartsWith()  | 현재 문자열이 지정된 문자열로 시작하는지 평가                |
| EndsWith()    | 현재 문자열이 지정된 문자열로 끝나는지 평가                  |
| Contains()    | 현재 문자열이 지정된 문자열을 포함하는지 평가                |
| Replace()     | 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바귄 새 문자열을 반환 |

```c#
static void Main(string[] args)
{
    string text = "Alice in wonderland";

    WriteLine(text);
    WriteLine();

    //IndexOf
    WriteLine("Index Of 'in' : {0}", text.IndexOf("in"));
    WriteLine("Index Of ' e' : {0}", text.IndexOf('e'));

    //LastIndexOf
    WriteLine("Last index of 'Alice' : {0}", text.LastIndexOf("Alice"));
    WriteLine("Last index of 'i' : {0}", text.LastIndexOf('i'));

    //StartsWith
    WriteLine("Starts With 'Wonderland' : {0}", text.StartsWith("wonderland"));
    WriteLine("Starts With 'Alice' : {0}", text.StartsWith("Alice"));

    //EndsWith
    WriteLine("Ends With 'Wonderland' : {0}", text.EndsWith("wonderland"));
    WriteLine("Ends With 'Alice' : {0}", text.EndsWith("Alice"));

    //Contains
    WriteLine("Contains 'Liddel' : {0}", text.Contains("Liddel"));
    WriteLine("Contains 'Alice' : {0}", text.Contains("Alice"));

    //Replace
    WriteLine("Replaced 'Alice' with 'Ariel' : {0}", text.Replace("Alice", "Ariel"));
}/*
Alice in wonderland

Index Of 'in' : 6
Index Of ' e' : 4
Last index of 'Alice' : 0
Last index of 'i' : 6
Starts With 'Wonderland' : False
Starts With 'Alice' : True
Ends With 'Wonderland' : True
Ends With 'Alice' : False
Contains 'Liddel' : False
Contains 'Alice' : True
Replaced 'Alice' with 'Ariel' : Ariel in wonderland*/
```

#### 문자열 변형하기

| 메소드      | 설명                                                         |
| ----------- | ------------------------------------------------------------ |
| ToLower()   | 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열을 반환   |
| ToUpper()   | 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열을 반환   |
| insert()    | 현재 문자열의 지정된 위치에 지정한 문자열이 삽입된 새 문자얄을 반환 |
| Remove()    | 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환 |
| Trim()      | 현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열 반환      |
| TrimStart() | 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환       |
| TrimEnd()   | 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열을 반환       |

```c#
static void Main(string[] args)
{
    WriteLine("ToLower() : '{0}'", "ABC".ToLower());
    WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

    WriteLine("Insert() : '{0}'", "Happy Friday".Insert(5, " Sunny"));

    WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));

    WriteLine("Trim() :'{0}'", "  no spaces  ".Trim());
    WriteLine("TrimStarts() : '{0}'", "  no spaces  ".TrimStart());
    WriteLine("TrimEnds() : '{0}'", "  no spaces  ".TrimEnd());
}
/*ToLower() : 'abc'
ToUpper() : 'ABC'
Insert() : 'Happy Sunny Friday'
Remove() : 'I Love You'
Trim() :'no spaces'
TrimStarts() : 'no spaces  '
TrimEnds() : '  no spaces'*/
```



#### 문자열 분할하기

| 메소드      | 설명                                                         |
| ----------- | ------------------------------------------------------------ |
| Split()     | 현재 문자열을 지정된 문자를 기준으로 분리한 문자열의 배열을 반환 |
| SubString() | 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환 |

```c#
static void Main(string[] args)
{
    string text = "Alice in Wonderland";

    WriteLine(text.Substring(0, 5));		//Alice
    WriteLine(text.Substring(5));			// in Wonderland

    string[] arr = text.Split(
        new string[] { " " }, StringSplitOptions.None);
    WriteLine("Word Count: {0}", arr.Length);		//Word Count: 3

    foreach (string element in arr)
        WriteLine("{0}", element);		//Alice/in/Wonderland
}
```

#### 문자열 서식 맞추기

Format()

문자열 틀에 입력하는 {0},{1}..을 일컬어 '서식항목(Format Item)' 이라고 한다.

{ 첨자 , 맞춤: 서식 문자열 }

- 왼쪽 / 오른쪽 맞춤

```c#
static void Main(string[] args)
{
    string fmt = "{0, -20}{1,-15}{2,30}";

    WriteLine(fmt, "Alice ","in", "wonderland");
    WriteLine(fmt, "the", "little", "mermaid");
    WriteLine(fmt, "belle", "caroline", "diana");
    WriteLine(fmt, "Alice", "Ariel", "Asmeralda");
}
/*
Alice               in                                 wonderland
the                 little                                mermaid
belle               caroline                                diana
Alice               Ariel                               Asmeralda
*/
```

- 숫자 서식화

| 서식 지정자 | 대상 서식                | 설명                                    |
| ----------- | ------------------------ | --------------------------------------- |
| D           | 10진수                   | 입력된 수를 10진수로 서식화             |
| X           | 16진수                   | 입력된 수를 16진수로 서식화             |
| N           | 콤마(,)로 묶어 표현한 수 | 입력된 수를 콤마로 구분하여 출력        |
| F           | 고정소수점               | 입력된 수를 고정 소수점 형식으로 서식화 |
| E           | 지수                     | 입력된 수를 지수 표기로 서식화          |

```c#
static void Main(string[] args)
{
    //10진수 D
    WriteLine("10진수: {0:D}", 123);				//10진수: 123
    WriteLine("10진수: {0:D5}", 123);				//10진수: 00123
    //16진수 X
    WriteLine("16진수: {0:X}", 0xFF1234);			//16진수: FF1234
    WriteLine("16진수: {0:X8}", 0xFF1234);		//16진수: 00FF1234
    //숫자  N
    WriteLine("숫자:{0:N}", 123456789);			//숫자:123,456,789.00
    WriteLine("숫자:{0:N0}", 123456789);			//숫자:123,456,789
    //고정소수점 F
    WriteLine("고정소수점: {0:F}", 123.456);			//고정소수점: 123.46
    WriteLine("고정소수점: {0:F5}", 123.456);		//고정소수점: 123.45600
    //공학용 E
    WriteLine("공학용: {0:E}", 123.456789);		//공학용: 1.234568E+002
}
```

날짜 및 시간 서식화

| 서식 지정자 | 대상 서식    | 설명       |
| ----------- | ------------ | ---------- |
| y           | 연도         | yy / yyyy  |
| M           | 월           | M / MM     |
| d           | 일           | d / dd     |
| h           | 시( 1 - 12 ) | h / hh     |
| H           | 시( 1 - 24 ) | H / HH     |
| m           | 분           | m / mm     |
| s           | 초           | s / ss     |
| tt          | 오전 / 오후  | tt         |
| ddd         | 요일         | ddd / dddd |

```c#
static void Main(string[] args)
{
    DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

    WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
    WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

    CultureInfo ciKo = new CultureInfo("ko-KR");
    WriteLine();
    WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
    WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
    WriteLine(dt.ToString(ciKo));

    CultureInfo ciEn = new CultureInfo("en-US");
    WriteLine();
    WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
    WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
    WriteLine(dt.ToString(ciEn));
}
/*
12시간 형식: 2018-11-03 오후 11:18:22 (토)
24시간 형식: 2018-11-03 23:18:22 (토요일)

2018-11-03 오후 11:18:22 (토)
2018-11-03 23:18:22 (토요일)
2018-11-03 오후 11:18:22

2018-11-03 PM 11:18:22 (Sat)
2018-11-03 23:18:22 (Saturday)
11/3/2018 11:18:22 PM
*/
```

문자열 보간

```
$ "텍스트{<보간식>[,길이] [:서식]텍스트{...}.."
```

