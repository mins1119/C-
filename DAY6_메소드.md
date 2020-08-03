# DAY6												20.07.27

## 메소드

메소드(Method)는 일련의 코드를 하나의 이름아래 묶은 것이다.  이렇게 묶은 코드는 이름을 불러주는 것만으로 실행할 수 있다. 이를 메소드를 호출(call)한다고 한다.

```
class 클래스의_이름
{
	한정자 반환형식 메소드의_이름 ( 매개 변수_목록 )
	{
		//실행하고자 하는 코드
		
		return 메소드의 결과;
	}
}
한정자 : 메소드의 속성을 수식
메소드 결과의 데이터 형식은 메소드의 반환형식과 일치해야한다.
```

메소드 호출시에 일어나는 흐름 변화

![스크린샷(19)](https://user-images.githubusercontent.com/40557177/88510605-53198880-d01e-11ea-9ea0-6a2b77b043c7.png)

### return

점프문의 한 종류이다. 

언제든지 메소드 중간에 호출되어 메소드를 종결시키고 프로그램의 흐름을 호츨자에게 돌려줄수 있다.

반환할 것이 아무것도 없는 void인 경우에도 return문을 사용할 수 있다.

```c#
void PrintProfile( string name, string phone)
{
	if (name == "")
    {
        Console.WriteLine("이름을 입력해주세요");
        return;
    }
    Console.WriteLine("Name: {0}, Phone: {1}",name, phone);
}
```

**재귀호출 (Recursive call)**

메소드가 자기 자신을 스스로 호출하는 것을 일컫는다. 

코드를 단순하게 호출 할 수 있다는 장점이 있지만 성능에는 나쁜영향을 준다.

```c#
int Fibonacci( int i ){
    if(n<2)
        return n;
    else
        return Fibonacci( n-1 ) + Fibonacci( n-2 );
}
```

### 매개 변수

#### 값에 의한 전달 ( Pass by value )

```c#
public static void Swap(int a, int b)
{
    int temp = b;
    b = a;
    a = temp;
}
static void Main(string[] args)
{
    int x = 3;
    int y = 4;

    Console.WriteLine($"x:{x}, y :{y}");	//x:3, y :4

    Swap(x, y);

    Console.WriteLine($"x:{x}, y :{y}");	//x:3, y :4
}
```

Swap 메소드를 통해 값을 교환했음에도 서로의 값이 바뀌지 않았다.  

메소드가 매개변수를 받아들일때에는 데이터의 '복사'가 이루어진다. 즉,  Swap()의 첫번째매개 변수 a는 x가 담고있는 3을 복사해서 받고, 두번재 매개변수b는 y가 담고 있는 4를 복사해서 받는다. 이처럼 메소드를 호출할 때 데이터를 복사해서 매개변수에 넘기는 것을 "값에 의한 전달 (pass by value) "라고 한다.

![스크린샷(20)](https://user-images.githubusercontent.com/40557177/88514343-e0f87200-d024-11ea-8b9e-666b68ca6bf8.png)

a는 x가 갖고있는 것과 똑같은 데이터를 갖고있지만, a와x는 완전히 별개의 메모리 공간을 사용한다.  다라서 a를 수정한다고 해도 x는 아무런 영향을 받지 않는다.

#### 참조에 의한 전달 ( Pass by reference )

메소드이 선언에서 ref를 붙여준다. 값에 의한 전달이 매개변수가 변수나 상수로부터 값을 복사하는 것과는 달리, 참조에 의한 전달은 매개 변수가 메소드에 넘겨진 원본 변수를 직접 참조한다. 따라서 메소드 안에서 매개변수를 수정하면 이 매개 변수가 참조하고 있는 원본 변수에 수정이 이루어진다.

```c#
public static void Swap(ref int a, ref int b)
{
    int temp = b;
    b = a;
    a = temp;
}
static void Main(string[] args)
{
    int x = 3;
    int y = 4;

    Console.WriteLine($"x:{x}, y :{y}");	//x:3, y :4

    Swap(ref x, ref y);

    Console.WriteLine($"x:{x}, y :{y}")\;	//x:4, y :3
}
```

![스크린샷(21)](https://user-images.githubusercontent.com/40557177/88515172-4305a700-d026-11ea-9956-4521d4ebce11.png)



#### 참조 반환값 ( ref return )

메소드의 결과를 참조로 반환한다. 반환받은 결과를 참조로 다룰 수 있다.

ref 한정자를 이용하여 메소드를 선언하고, return문이 반환하는 변수 앞에도 ref키워드를 명시한다.

참조를 반환하도록 구현해도 결과를 받는 지역변수와 호출 할 메소드 앞에 ref를 붙이지 않으면 평범한 메소드로 동작한다. 참조로 반환받은 결과를 담는 지역변수를 참조지역변수 ( ref local ) 이라 한다.

```c#
class Product
{
    private int price = 100;

    public ref int GetPrice()
    {
        return ref price;
    }
    public void PrintPrice()
    {
        Console.WriteLine($"Price:{price}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Product carrot = new Product();
        ref int ref_local_price = ref carrot.GetPrice();
        int normal_local_price = carrot.GetPrice();

        carrot.PrintPrice();
        Console.WriteLine($"Ref Local Price: {ref_local_price}");
        Console.WriteLine($"Normal Local Price: {normal_local_price}");

        ref_local_price = 200;

        carrot.PrintPrice();
        Console.WriteLine($"Ref Local Price: {ref_local_price}");
        Console.WriteLine($"Normal Local Price: {normal_local_price}");
    }
}
```



#### 출력 전용 매개 변수

```c#
static void Divide(int a, int b, out int quotient, out int remainder)
{
    quotient = a / b;
    remainder = a % b;
}
static void Main(string[] args)
{
    int a = 20;
    int b = 3;

    Divide(a, b, out int c, out int d);
    Console.WriteLine($"a :{a},b: {b}, a / b: {c}, a % b : {d}");
}
```

out 키워드를 이용한다. 

ref 키워드를 이용해서 매개변수를 넘기는 경우에는 메소드가 해당 매개 변수에 결과를 저장하지 않아도 컴파일러는 아무런 경고를 하지 않는다. 

out 키워드를 이용해서 매개 변수를 넘길 때는 메소드가 해당 변수에 결과를 저장하지 않으면 컴파일러가 에러 메세지를 출력한다. 또한 컴파일러가 호출당하는 메소드에서 지역변수를 할당할 것을 보장하기 때문에, 호출하는 쪽에서 초기화를 하지 않은 지역변수를 넘기는 것도 가능하다. 

사실 메소드를 호출하기 전에 미리 선언할 필요가 없다. 호츨힐 때 매개변수 목록 안에서 즉석으로 선언하면 되기 때문이다.

#### 메소드 오버로딩 ( Overloading )

메소드 오버로딩은 하나의 메소드 이름에 여러개의 구현을 올리는 것을 뜻한다.

컴파일러가 호출코드에 사용되는 매개변수의 수와 형식을 분석해서 어떤 버전이 호출될지를 찾아준다. 코드를 일관성있게 유지해주고, 사용자에게도 높은 생산성을 제공한다는 장점이 있다.

```c#
static int Plus(int a, int b)
{
    Console.WriteLine("Calling int Plus(int, int)..");
    return a + b;
}
static double Plus(double a, double b)
{
    Console.WriteLine("Calling double Plus(double, double)..");
    return a + b;
}
static int Plus(int a, int b, int c)
{
    Console.WriteLine("Calling int Plus(int, int)..");
    return a + b + c;
}
static void Main(string[] args)
{
    Console.WriteLine(Plus(1,2));
    Console.WriteLine(Plus(1.0,2.4));
    Console.WriteLine(Plus(1,2,8));
}
/*
Calling int Plus(int, int)..
3
Calling double Plus(double, double)..
3.4
Calling int Plus(int, int)..
11
*/
```

#### 가변길이 매개 변수

params 키워드와 배열을 이용해서 선언한다.

개수가 유연하게 변할 수 있는 매개 변수를 뜻한다.

```c#
static int Sum(params int[] args)
{
    Console.Write("summing...");
    int sum = 0;
    for(int i = 0; i<args.Length; i++)
    {
        if (i > 0)
            Console.Write(", ");
        Console.Write(args[i]);
        sum += args[i];
    }
    Console.WriteLine();
    return sum;
}
static void Main(string[] args)
{
    int sum = Sum(3,4,5,8,9,6,5);
    Console.WriteLine($"Sum : {sum}");
}
```

#### 명명된 매개 변수 ( Named Parameter )

메소드를 호출 할 때, 매개변수의 이름에 근거해서 데이터를 할당할 수 있는 기능이다. 메소드를 호출할 때만 매개 변수의 이름 뒤에 콜론(:)을 붙인 뒤 그 뒤에 할당할 데이터를 넣어주면 된다.

```c#
static void PrintProfile(string name, string phone)
{
    Console.WriteLine($"Name: {name}, Phone: {phone}");
}

static void Main(string[] args)
{
    PrintProfile(name:"박찬호",phone:"010-5555-5555");
    PrintProfile(phone:"010-222-2222",name:"가가가");
    PrintProfile("박세리", "010-111-1515");
}/*
Name: 박찬호, Phone: 010-5555-5555
Name: 가가가, Phone: 010-222-2222
Name: 박세리, Phone: 010-111-1515
*/
```

#### 선택적 매개 변수 ( Optional Parameter )

기본값을 가지는 매개 변수는 필요에 따라 데이터를 할당하거나 할당하지 않을 수 있다.

메소드 오버로딩과 함께 사용할 수 없다.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        

```c#
static void PrintProfile(string name, string phone = "")
{
    Console.WriteLine($"Name:{name},Phone:{phone}");
}

static void Main(string[] args)
{
    PrintProfile(name:"Alice");
    PrintProfile(phone:"010-222-2222",name:"Anne");
    PrintProfile(name: "yuri");
}
/*Name:Alice,Phone:
Name:Anne,Phone:010-222-2222
Name:yuri,Phone:*/
```

#### 로컬 함수 ( Local Function )

로컬함수는 메소드 안에서 선언되고, 선언된 메소드안에서만 사용되는 특별한 함수이다. 클래스이 멤버가 아니기 때문에 메소드가 아니라 함수라고 부른다. 선언방법은 메소드와 다르지 않지만, 로컬함수는 자신이 존재하는 지역에 선언되어 있는 변수를 사용할 수 있다. 메소드 밖에서는 다시 쓸 일없는 반복적인 작업을 하나의 이름 아래 묶어 놓는데 사용한다.

```c#
static string ToLower( string input)
{
    var arr = input.ToCharArray();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = ToLowerChar(i);
    }
    char ToLowerChar(int i)
    {
        if (arr[i] < 65 || arr[i] > 90)
            return arr[i];
        else
            return (char)(arr[i] + 32);
    }
    return new string(arr);
}
static void Main(string[] args)
{
    Console.WriteLine(ToLower("HELLO"));
    Console.WriteLine(ToLower("Good Mormning"));
    Console.WriteLine(ToLower("This is a Pen"));
}
```

```c#
static double Square(double arg)
{
    return arg * arg;
}

static void Main(string[] args)
{
    Console.WriteLine("수를 입력하세요:");
    string input = Console.ReadLine();
    double arg = Convert.ToDouble(input);

    Console.WriteLine("결과 : {0}",Square(arg));
}
```

```c#
static double Square(double arg)
{
    return arg * arg;
}

static void Main(string[] args)
{
    double mean = 0;
    Mean(1, 2, 3, 4, 5, out mean);
    Console.WriteLine("평균 : {0} ",  mean);
}
public static void Mean(double a, double b, double c, double d, double e, out double mean)
{
    mean = (a + b + c+ d +e) / 5;
}
```

```c#
static void Main(string[] args)
{
    int a = 3;
    int b = 4;
    int resultA = 0;

    Plus(a, b, out resultA);
    Console.WriteLine($"{a} + {b} = {resultA}");

    double x = 2.4;
    double y = 3.1;
    double resultB = 0;

    Plus(x, y, out resultB);
    Console.WriteLine($"{x} + {y} = {resultB}");
}
public static void Plus(int a, int b, out int c)
{
    c = a + b;
}
public static void Plus(double a, double b, out double c)
{
    c = a + b;
}
```

