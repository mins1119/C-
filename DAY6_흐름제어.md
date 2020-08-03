# DAY6												20.07.27

## 흐름 제어

### 분기문

프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름제어 구문이다.

#### if  , else, else if

```
if ( 조건식 )
{
	//참인 경우 실행 할 코드
}
else if ( 조건식 )
{
	//참인 경우 실행 할 코드
}
else
	...
```

```c#
Console.WriteLine("숫자를 입력하세요");

string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if ( number > 0)
{
    if ( number % 2  ==0)
    {
        Console.WriteLine("0보다 큰 짝수");
    }
    else
    {
        Console.WriteLine("0보다 큰 홀수");
    }
}
else
{
    Console.WriteLine("0보다 작거나 같은 수");
}
```

#### switch

```c#
switch ( 조건식 )
{
    case 상수1:	//조건식이 상수 1일때
        //실행할 코드
        break;
    case 상수N:	//조건식이 상수N일때
        //실행할 코드
        break;
    default:	//조건식이 어떤 경우와도 맞지 않은 경우, 생략가능
        //
        btreak;
}
```

switch문에 사용되는 조건식은 정수형식과 문자열 형식 두가지만 지원한다.

break문은 프로그램의 흐름을 멈추고 현재 실행중인 코드의 바깥으로 실행위치를 옯기는 역할을 한다. case 절이나 default 절에 사용된 break문은 조건식과 일치하는 경우의 코드를 실행한 후  switch문 바같으로 옮긴다.

```c#
static void Main(string[] args)
{
    Console.WriteLine("요일을 입력하세요");

    string input = Console.ReadLine();

    switch (input) 
    {
        case "일":
            Console.WriteLine("sunday");
            break;
        case "월":
            Console.WriteLine("monday");
            break;
        case "화":
            Console.WriteLine("tuesday");
            break;
        default:
            Console.WriteLine("월 화 수 중에 입력해 주세요");
            break;
    }
}
```

C# 7.0 부터는 switch문에 데이터 형식을 조건으로 사용 할 수 있게 되었다.

```c#
static void Main(string[] args)
{
    object obj = null;

    Console.WriteLine("입력하세요: ");
    string s = Console.ReadLine();
    if (int.TryParse(s, out int out_int))
        obj = out_int;
    else if (float.TryParse(s, out float out_f))
        obj = out_f;
    else
        obj = s;

    switch(obj)
    {
        case int i:
            Console.WriteLine($"{i}는 int형식입니다.");
            break;
        case float f:
            Console.WriteLine($"{f}는 float 형식입니다.");
            break;
        default:
            Console.WriteLine($"{obj}는 모르는 형식입니다.");
  			break;
    }
}
```

##### when

switch문에 when을 이용하여 추가적인 조건 검사를 수행할 수 있다.

```c#
switch(obj)
{
    case int i:
        Console.WriteLine($"{i}는 int형식입니다.");
        break;
    case float f when f >= 0:
        Console.WriteLine($"{f}는 양의 float 형식입니다.");
        break;
    case float f:
        Console.WriteLine($"{f}는 음의 float 형식입니다.");
        break;
    default:
        Console.WriteLine($"{obj}는 모르는 형식입니다.");
        break;
}
```

### 반복문

특정 조건을 만족하는 동안 코드 또는 코드블록을 계속 반복해서 실행하도록 하는 문장이다.

#### while

조건문이 참인 동안 코드를 반복실행한다.

```
while (조건식)

	반복 실행할 코드
```

```c#
static void Main(string[] args)
{
    int i = 10;
    while ( i > 0 )
    {
        Console.WriteLine($"{i--}");
    }
}
```

#### do while

while문은 조건식을 평가한 후에 참이면 코드를 실행하는데, do while은 일단 코드를 실행한다. while 문의 끝에 세미콜론을 반드시 붙여줘야 한다.

```
do{
	//반복 실행할 코드 블록
}
while( 조건식 );
```

```c#
static void Main(string[] args)
{
    int i = 10;
    do
    {
        Console.WriteLine("A) i: {0}", i--);
    }
    while (i > 0);
    do
    {
        Console.WriteLine("B) i: {0}", i--);
    }
    while (i > 0);
}/*
A) i: 10
A) i: 9
A) i: 8
A) i: 7
A) i: 6
A) i: 5
A) i: 4
A) i: 3
A) i: 2
A) i: 1
B) i: 0			//0보다 작지만 do문으로 이미 실행이됨
*/
```

#### for

```
for ( 초기화식; 조건식; 반복식)
	반복실행할 코드;

초기화식 : 반복을 실행하기 전에 가장 먼저, 띡 한번만 실행되는 코드.
for반복문에서 사용할 변수등을 이곳에서 초기화한다.
조건식 : 반복을 계속 수행할지를 결정하는 식. 조건식의 결과가 false이면 반복을 중단한다.
반복식 : 반복이 끝날때마다 실행된다. 조건식에서 사용되는 변수의 값을 조정한다.
```

```c#
static void Main(string[] args)
{
    for(int i = 0;i < 5; i++)
    {
        for(int j =0; j <= i ; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
}
```

#### foreach

배열(또는 컬렉션)을 순회하며 각 데이터의 요소에 접근하도록 해준다. 배열의 끝에 도달하면 자동으로 반복이 동료된다.

```
foreach(데이터 형식 변수명 in 배열_또는_컬렉션)
	코드_또는_코드블록
```

```c#
static void Main(string[] args)
{
    int[] arr = new int[] { 0,1,2,3,4};
    foreach (int a in arr)
    {
        Console.WriteLine(a);
    }
}
```

#### 무한 반복문

```
for ( ; ; )
	//반복실행할 코드
while( true )
	//반복실행할 코드
```

### 점프문

흐름을 끊고 프로그램의 실행위치를 원하는 곳으로 도약시킬 수 있다.

- break
- continue
- goto
- return
- throw

#### break

현재 실행중인 반복문이나 switch문을 중단하고자 할때 사용한다.

```c#
static void Main(string[] args)
{
    while ( true)
    {
        Console.Write("계속할까요? 예/아니오");
        string s = Console.ReadLine();

        if(s == "아니오")
        {
            break;
        }
    }
}
```

#### continue

한 회 건너뛰어 반복을 계속 수행하게 한다.

```c#
static void Main(string[] args)
{
    for(int i = 1; i <10; i++)
    {
        if (i % 2 == 0) continue;
        Console.WriteLine($"i: {i} : 홀수");
    }
}/*
i: 1 : 홀수
i: 3 : 홀수
i: 5 : 홀수
i: 7 : 홀수
i: 9 : 홀수
*/
```

#### goto

레이블이 가리키는 곳으로 바로 이동한다. 중첩된 반복문을 뚫고 나오는데 유용하게 사용한다.

```
goto 레이블;
	레이블 : 
	//이어지는 코드
```

### 연습문제

```c#
1.
static void Main(string[] args)
{
    for(int i = 0; i < 5; i++)
    {
        for(int j= 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
```

```c#
2.
static void Main(string[] args)
{
    for(int i = 0; i < 5; i++)
    {
        for(int j= 0; 5-j>i ; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
```

```c#
3. while
static void Main(string[] args)
{
    int i = 0;

    while(i < 5)
    {
        int j = 0;
        while (j<=i)
        {
            Console.Write("*");
            j++;
        }
        i++;
        Console.WriteLine();
    }
}
static void Main(string[] args)
{
    int i = 0;

    while(i < 5)
    {
        int j = 0;
        while (5-j> i)
        {
            Console.Write("*");
            j++;
        }
        i++;
        Console.WriteLine();
    }
}
```

```c#
3. do ~ while
static void Main(string[] args)
{
    int i = 0;
    do
    {
        for(int j= 0; i-j >= 0; j++)
        {
            Console.Write("*");
        }
        i++;
        Console.WriteLine();
    }
    while (i<5);
}
static void Main(string[] args)
{
    int i = 0;
    do
    {
        for(int j= 0; 5-j >i; j++)
        {
            Console.Write("*");
        }
        i++;
        Console.WriteLine();
    }
    while (i<5);
}
```

```c#
4.
static void Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("반복 횟수를 입력하세요:");
        string s = Console.ReadLine();
        int num = Convert.ToInt32(s);

        if (num <= 0)
        {
            Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
```

