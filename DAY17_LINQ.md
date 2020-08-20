# sLINQ													20.08.17

## LINQ ( Language INtegrated Query )

C#에 통합된 데이터 질의 기능

데이터 질의는 기본적으로 다음 세 가지를 포함한다.

- from : 어떤 데이터를 찾을 것인가?
- Where : 어떤 값의 데이터를 찾을 것인가?
- Select : 어떤 항목을 추출할 것인가?

```C#
Profile[] arrProfile =
            {
                new Profile() { Name = "Alice", Height = 150 },
                new Profile() { Name = "Belle", Height = 163 },
                new Profile() { Name = "Caroline", Height = 178 },
                new Profile() { Name = "Danny", Height = 145 },
                new Profile() { Name = "Eric", Height = 160 }
            };
//arrProfile에서 Height 프로퍼티가 160미만인 데이터를 골라 추출해야한다면 

//1. LINQ를 사용하지 않음
List<Profile> profiles = new List<Profile>();
foreach(Profile profile in arrProfile)
{
    if (profile.Height < 160)
        profiles.Add(profile);
}
profiles.Sort(
    (profile1, profile2) =>
    {
        return profile1.Height - profile2.Height;
    });
foreach (var profile in profiles)
    Console.WriteLine($"{profile.Name},{profile.Height}");

//2. LINQ를 사용함
 var profiles = from profile in arrProfile	//arrProfile에 있는 데이터에서
     			where profile.Height < 160	//Height가 160미만인 객체들을골라
     			orderby profile.Height		//키순으로 정렬하여
     			select profile;				//profile 객체를 추출한다.
foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name},{profile.Height}");
```



## LINQ 쿼리식

### from

모든 LINQ 쿼리식은 from 절로 시작한다. 

쿼리식의 대상이 될 원본 ( Data source )과 데이터 원본안에 들어있는 각 요소 데이터를 나타내는 범위변수( Rangd Variable )를 from 절에서 지정해야한다.

from 절의 데이터원본은 IEnumerable<T> 인터페이스를 상속받는 형식이어야 한다.

범위변수( Range Variavle )는 쿼리변수( Query Variable )이라고도 하는데, foreach의 반복변수와 비슷한 기능을 한다.



> **LINQ의 범위변수와 foreach의 반복변수의 차이점**
>
> foreach문의 반복변수는 데이터 원본으로부터 데이터를 담아내지만, 범위변수는 실제로 데이터를 담지는 않는다.

```c#
from <범위변수> in <데이터 원본>
```

```c#
using System;
using System.Linq;

namespace From
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers	//범위변수 n 데이터원본 numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            foreach (int n in result)
                Console.WriteLine($"짝수:{n}");
        }
    }
}

```

### where

필터 역할을 수행한다.

where 연산자에 조건을 매개변수로 입력하면 LINQ가 해당 조건에 부합하는 데이터만을 걸러낸다.

조건에는 반환타입이 bool 형식인 코드를 사용할 수 있다.

```c#
where 조건
```

```c#
using System;
using System.Linq;

namespace From
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers
                         where n % 2 == 0	//where 조건 : n을 2로 나누었을때 나머지가 0인 데이터
                         orderby n
                         select n;
            foreach (int n in result)
                Console.WriteLine($"짝수:{n}");
        }
    }
}
```

### orderby

데이터의 정렬을 수행한다.

기본적으로 오름차순으로 정렬하지만, ascending을 명시해도 상관없다.

내림차순 정렬시 orderby ~ descending 을 사용한다.

```c#
using System;
using System.Linq;

namespace From
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers
                         where n % 2 == 0	
                         orderby n			//n을 오름차순으로 정렬
                		 // orderby n descending n을 내림차순으로 정렬
                         select n;
            foreach (int n in result)
                Console.WriteLine($"짝수:{n}");
        }
    }
}
```

### select

최종결과를 추출하는 쿼리식의 마침표 같은 존재이다. select문을 사용해서 최종 결과를 추출한다.

```c#
var result = from n in numbers
		     where n % 2 == 0	
    		 orderby n			//n을 오름차순으로 정렬
    		 select n;
```

무명형식을 사용해서 새로운 형식을 만들어 낼 수 있다.

```c#
var 변수명 = from 범위변수 in 데이터원본
    		where 조건
    		orderby 기준항목
    		select new
			{
    			Name = profile.Name,
    			InchHeight = profile.Height * 0.393
			};
```



> **var로 선언된 변수의 실제 형식**
>
> LINQ의 질의결과는 IEnumerable<T>로 반환되는데, 이때 형식매개변수 T는 select문에 의해 결정된다.

```c#
using System;
using System.Linq;

namespace LINQ
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="Alice", Height = 150},
                new Profile(){Name="Belle", Height = 160},
                new Profile(){Name="Caroline", Height = 155},
                new Profile(){Name="Daisy", Height = 166},
                new Profile(){Name="Eve", Height = 148}
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 160
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };
            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}.{profile.InchHeight}");
            
        }
    }
}/*
Eve.58.164
Alice.58.95
Caroline.60.915
*/
```

## from 중첩

여러개의 데이터 원본에 접근하는 방법

```c#
var 변수명 = from 범위변수 in 데이터원본		//첫번째 데이터 원본
    			from 범위변수 in 데이터원본	  //두번째 데이터 원본
	    		where 조건
    		select 
```

```c#
using System;
using System.Linq;
namespace FromFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class(){Name="연두반",Score = new int[]{99,32,75,85}},
                new Class(){Name="분홍반",Score = new int[]{23,87,34}},
                new Class(){Name="개나리반",Score = new int[]{100,77,75,89}},
                new Class(){Name="햇님반",Score = new int[]{12,54,98,99,100}},
                new Class(){Name="파랑반",Score = new int[]{77,78,79,77}}
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };
            foreach (var c in classes)
                Console.WriteLine($"낙제 : {c.Name}({c.Lowest})");
        }
    }
}
/*
낙제 : 햇님반(12)
낙제 : 분홍반(23)
낙제 : 연두반(32)
낙제 : 분홍반(34)
낙제 : 햇님반(54)
*/
```

## group by

- 데이터를 특정기준에 따라 나누어 정리한다.

```c#
group A by B into C
```

- A에는 from절에서 뽑아낸 범위변수를, B에는 분류기준을, C에는 그룹변수를 위치시킨다.

- LINQ의 group...by는 지정된 값을 기준으로 컬렉션의 요소를 그룹으로 분류하고 최종적으로 모든 그룹의 컬렉션을 반환한다.

```c#
Profile[] arrProfile =
            {
                new Profile() { Name = "Alice", Height = 150 },
                new Profile() { Name = "Belle", Height = 163 },
                new Profile() { Name = "Caroline", Height = 178 },
                new Profile() { Name = "Danny", Height = 145 },
                new Profile() { Name = "Eric", Height = 160 }
            };

//160을 기준으로 미만 이상으로 분류
var listProfile = from profile in arrProfile
    			  group profile by profile.Height < 160 into g
    			  select new { Groupkey = g.Key, Profiles = g };
```

```c#
using System;
using System.Linq;

namespace GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "Alice", Height = 150 },
                new Profile() { Name = "Belle", Height = 163 },
                new Profile() { Name = "Caroline", Height = 178 },
                new Profile() { Name = "Danny", Height = 145 },
                new Profile() { Name = "Eric", Height = 160 }
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 160 into g
                              select new { GroupKey = g.Key, Profiles = g };
            foreach( var Group in listProfile)
            {
                Console.WriteLine($"- 160cm 미만? : {Group.GroupKey}");
                foreach(var profile in Group.Profiles)
                {
                    Console.WriteLine($"   {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
/*
- 160cm 미만? : True
   Danny, 145
   Alice, 150
- 160cm 미만? : False
   Eric, 160
   Belle, 163
   Caroline, 178
*/
```

## join

두 데이터의 원본을 연결하는 연산.

### 내부조인 ( Inner Join )

두 데이터 원본 사이에서 일치하는 데이터들만 연결한 후 반환한다.

첫 번째 데이터 원본의 데이터를 기준으로 이 데이터의 특정 필드와 두번째 데이터 원본이 갖고 있는 각 데이터의 특정 필드를 비교해서 일치하는 데이터들만 모아 반환한다.

![innerjoin](https://user-images.githubusercontent.com/40557177/90361005-13334780-e098-11ea-974a-ecabb1fd248b.png)

내부 조인을 수행할 때 기준 데이터 원본에는 존재하지만 연결할 데이터 원본에는 존재하지 않는 데이터, 반대로 원본에는 존재하지 않고 연결할 데이터 원본에만 존재하는 데이터는 조인 결과에 포함되지 않는다.

```c#
from a in A
join b in B on a.XXXX equals b.YYYY
```

내부조인은 위와 같이 join절을 통해 수행한다. 

join절의 on 키워드는 조인 조건을 수반하며, 이때 on 절의 조인조건은 "동등 ( equality )"만 허용된다.

비교연산은 허용되지 않는다.



### 외부 조인 ( Outer Join )

조인결과에 기준이 되는 데이터 원본이 모두 포함된다.

![outerjoin](https://user-images.githubusercontent.com/40557177/90361001-12021a80-e098-11ea-8dc0-918dab976db3.png)

B에 Eve의 Story가 없음에도 조인결과에 Eve가 Story 란이 빈채로 포함되었다. 외부조인이 기준이 되는 데이터 원본의 모든 데이터를 조인결과에 반드시 포함시키기 때문이다.  

```c#
from a in A
join b in B on a.XXXX equals b.YYYY into c
from b in c.DefaultIfEmpty()
```



```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Story
    {
        public string Character { get; set; }
        public string Title { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "Alice", Height = 150 },
                new Profile() { Name = "Belle", Height = 163 },
                new Profile() { Name = "Caroline", Height = 178 },
                new Profile() { Name = "Dorothy", Height = 145 },
                new Profile() { Name = "Eve", Height = 160 }
            };
            Story[] arrStory =
            {
                new Story(){Character="Alice",Title="Wonderland"},
                new Story(){Character="Belle",Title="Beauty"},
                new Story(){Character="Belle",Title="Beast"},
                new Story(){Character="Caroline",Title="Caroline"},
                new Story(){Character="Dorothy",Title="Oz"},
            };

            var listProfile =
                from profile in arrProfile
                join story in arrStory on profile.Name equals story.Character
                select new
                {
                    Name = profile.Name,
                    Title = story.Title,
                    Height = profile.Height
                };

            Console.WriteLine("---내부 조인 결과---");

            foreach ( var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name,-10}, 작품 : {profile.Title,-10}, 키 : {profile.Height}");
            }

            listProfile =
                from profile in arrProfile
                join story in arrStory on profile.Name equals story.Character into sc
                from story in sc.DefaultIfEmpty(new Story() { Title = "Nothing" })
                select new
                {
                    Name = profile.Name,
                    Title = story.Title,
                    Height = profile.Height
                };
            Console.WriteLine();
            Console.WriteLine("---외부 조인 결과---");
            foreach(var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name,-10}, 작품 : {profile.Title,-10}, 키 : {profile.Height}");
            }
        }
    }
}
/*
---내부 조인 결과---
이름 : Alice     , 작품 : Wonderland, 키 : 150
이름 : Belle     , 작품 : Beauty    , 키 : 163
이름 : Belle     , 작품 : Beast     , 키 : 163
이름 : Caroline  , 작품 : Caroline  , 키 : 178
이름 : Dorothy   , 작품 : Oz        , 키 : 145

---외부 조인 결과---
이름 : Alice     , 작품 : Wonderland, 키 : 150
이름 : Belle     , 작품 : Beauty    , 키 : 163
이름 : Belle     , 작품 : Beast     , 키 : 163
이름 : Caroline  , 작품 : Caroline  , 키 : 178
이름 : Dorothy   , 작품 : Oz        , 키 : 145
이름 : Eve       , 작품 : Nothing   , 키 : 160
*/
```



## LINQ 분석

LINQ 쿼리식이 실행될 수 있도록, C#컴파일러는 LINQ쿼리식을 CLR이 이해할 수 있는코드로 번역을 해준다.

```c#
var profiles =  from profile in arrProfile
                where profile.Height < 160
                orderby profile.Height
                select new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                };
//위와 같은 쿼리식을 분석헤서 아래와 같은 일반적인 메소드 호출 코드로 바꾼다.
var profiles = arrProfile.
                Where(profile => profile.Height < 160).
                OrderBy(profile => profile.Height).
                Select(profile => new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                });
```

쿼리식의 where은 Where()메소드로, orderby는 OrderBy()로, select는 Select() 로 바뀌고 from절의 범위변수 profile은 각 메소드에 입력되는 람다식의 매개변수로 바뀌었다.



```c#
using System;
using System.Globalization;
using System.Linq;

namespace LINQ2
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="Alice", Height = 150},
                new Profile(){Name="Belle", Height = 160},
                new Profile(){Name="Caroline", Height = 155},
                new Profile(){Name="Daisy", Height = 166},
                new Profile(){Name="Eve", Height = 148}
            };
            var profiles = arrProfile.
                Where(profile => profile.Height < 160).
                OrderBy(profile => profile.Height).
                Select(profile => new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                });
            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name},{profile.InchHeight}");
        }
    }
}

```



## LINQ 표준 연산자

### 정렬

| 메소드 이름       | 설명                              | C#쿼리식 구문              |
| ----------------- | --------------------------------- | -------------------------- |
| OrderBy           | 값을 오름차순으로 정렬한다.       | orderby                    |
| OrderByDescending | 값을 내림차순으로 정렬한다.       | orderby ... descending     |
| ThenBy            | 2차 정렬을 오름차순으로 수행한다. | orderby..., ...            |
| ThenByDescending  | 2차 정렬을 내림차순으로 수행한다. | order by..., ...descending |
| Reverse           | 컬렉션에서 요소를 반대로 바꾼다.  | 해당사항 없음              |

```c#
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1차 오름차순 정렬
            string[] words = {"Alice","in","the","wonderland" };

            IEnumerable<string> query = from word in words
                                        orderby word.Length
                                        select word;
            foreach (string str in query)
                Console.WriteLine(str);
          //1차 내림차순 정렬
            IEnumerable<string> query_2 = from word in words
                                          orderby word.Substring(0, 1) descending
                                          select word;
            foreach (string str in query_2)
                Console.WriteLine(str);
        }
    }
}
```

```c#
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sort2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "transformers", "revenge", "of", "the", "fallen" };
            IEnumerable<string> query = from word in words
                                        orderby word.Length, word.Substring(0, 1)
                                        select word;
            foreach (string str in query)
                Console.WriteLine(str);

            IEnumerable<string> query2 = from word in words
                                         orderby word.Length, word.Substring(0, 1) descending
                                         select word;
            foreach (string str in query2)
                Console.WriteLine(str);
        }
    }
}
```

### 집합작업

| 메소드 이름 | 설명                                                         | C#쿼리식 구문 |
| ----------- | ------------------------------------------------------------ | ------------- |
| OrderBy     | 컬렉션에서 중복값을 제거한다.                                | 해당사항 없음 |
| Except      | 두 번째 컬렉션에 표시되지 않는 한 컬렉션의 요소를 의미하는 차집합을 반환한다. | 해당사항 없음 |
| Intersect   | 두 컬렉션에 각각 표시되는 요소를 의미하는 교집합을 반환한다. | 해당사항 없음 |
| Union       | 두 컬렉션 중 하나에 표시되는 고유한 요소를 의미하는 합집합을 반환한다. | 해당사항 없음 |

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Distinct-----");
            string[] planets = { "Mercury","Venus","Mars","Pluto","Venus","Earth","Pluto"};

            IEnumerable<string> distinct = from planet in planets.Distinct()
                                        select planet;
            foreach(var str in distinct)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----Except-----");
            string[] planets1 = { "Mercury", "Venus", "Earth", "Jupiter" };
            string[] planets2 = { "Mercury", "Earth", "Mars", "Jupiter" };
            IEnumerable<string> except = from planet in planets1.Except(planets2)
                                         select planet;

            foreach(var str in except)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----Intersect-----");
            IEnumerable<string> intersect = from planet in planets1.Intersect(planets2)
                                            select planet;
            foreach(var str in intersect)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----Union-----");
            IEnumerable<string> union = from planet in planets1.Union(planets2)
                                        select planet;
            foreach(var str in union)
            {
                Console.WriteLine(str);
            }
        }
    }
}
/*
-----Distinct-----
Mercury
Venus
Mars
Pluto
Earth
-----Except-----
Venus
-----Intersect-----
Mercury
Earth
Jupiter
-----Union-----
Mercury
Venus
Earth
Jupiter
Mars
*/
```

### 데이터 필터링

| 메서드 이름 | 설명                                                         | C# 쿼리식 구문 |
| ----------- | ------------------------------------------------------------ | -------------- |
| OfType      | 지정된 형식으로 캐스트 할 수 있는지 여부에 따라 값을 선택한다. | 해당 사항 없음 |
| Where       | 조건자 함수를 기반으로 하는 값을 선택한다.                   | where          |

### 수량

| 메소드 이름 | 설명                                               | C# 쿼리식 구문 |
| ----------- | -------------------------------------------------- | -------------- |
| All         | 시퀀스의 모든 요소가 조건을 만족하는지를 확인한다. | 해당 사항 없음 |
| Any         | 시퀀스의 임의의 요소가 조건을 만족하는지 확인한다. | 해당 사항 없음 |
| Contains    | 시퀀스에 지정된 요소가 있는지 확인한다.            | 해당 사항 없음 |

```c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Market
    {
        public string Name { get; set; }
        public string[] Items { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Market> markets = new List<Market>
            {
                new Market{Name="Alice's",Items =new string[]{"rabbit","hatter","flower"}},
                new Market{Name="Belle's",Items =new string[]{"rose","beast","cup","flower"}},
                new Market{Name="Jasmin's",Items =new string[]{"carpet","tiger","lamp"}},
            };
            Console.WriteLine("-----All-----");
            IEnumerable<string> all_names = from market in markets
                                        where market.Items.All(item => item.Length == 6)
                                        select market.Name;
            foreach (string name in all_names)
            {
                Console.WriteLine($"{name} market");
            }

            Console.WriteLine("-----Any-----");
            IEnumerable<string> any_names = from market in markets
                                            where market.Items.Any(item => item.StartsWith("c"))
                                            select market.Name;
            foreach(string name in any_names)
            {
                Console.WriteLine($"{name} market");
            }
            Console.WriteLine("-----Contains-----");
            IEnumerable<string> con_names = from market in markets
                                            where market.Items.Contains("flower")
                                            select market.Name;
            foreach(string name in con_names)
            {
                Console.WriteLine($"{name} market");
            }
        }
    }
}
/*
-----All-----
Alice's market
-----Any-----
Belle's market
Jasmin's market
-----Contains-----
Alice's market
Belle's market
*/
```

### 프로젝션

| 메서드 이름 | 설명                                        | C# 쿼리식 구문 |
| ----------- | ------------------------------------------- | -------------- |
| Select      | 변환함수를 기반으로 하는 값을 프로젝션한다. | select         |
| SelcetMany  | 조건자 함수를 기반으로 하는 값을 선택한다.  | from 중첩      |

```c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "Alice", "in", "wonderland" };

            Console.WriteLine("-----select-----");
            var s_query = from word in words
                          select word.Substring(0, 1);
            foreach (string s in s_query)
                Console.WriteLine(s);

            Console.WriteLine("-----SelectMany-----");
            List<string> phrases = new List<string>() { "Alice in wonderland", "Transformers Dark of the Moon" };

            var m_query = from phrase in phrases
                          from word in phrase.Split(' ')
                          select word;

            foreach (string s in m_query)
                Console.WriteLine(s);


        }
    }
}
/*
-----select-----
A
i
w
-----SelectMany-----
Alice
in
wonderland
Transformers
Dark
of
the
Moon
*/
```

```c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectVSSelctMany
{
    class Bouquet
    {
        public List<string> Flowers { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Bouquet> bouquets = new List<Bouquet>()
            {
                new Bouquet{Flowers = new List<string>{ "Daisy","Jasmin","Rose","tulip"} },
                new Bouquet{Flowers = new List<string>{ "iris","lilac","lupin"} },
                new Bouquet{Flowers = new List<string>{"lily","peach","morning glory","orchid"}},
                new Bouquet{Flowers = new List<string>{ "Azalea","Clover","camellia","dandelion"} }
            };
         
            IEnumerable<List<string>> query1 = bouquets.Select(bq => bq.Flowers);

            IEnumerable<string> query2 = bouquets.SelectMany(bq => bq.Flowers);

            Console.WriteLine("Results by using Select() : ");
            foreach(IEnumerable<string> collection in query1)
                foreach(string item in collection)
                    Console.WriteLine(item);

            Console.WriteLine("-----\nResults by using SelectMany() :");
            foreach (string item in query2)
                Console.WriteLine(item);

        }
    }
}
```

### 데이터 분할

| 연산자 이름 | 설명                                                         | C# 쿼리식 구문 |
| ----------- | ------------------------------------------------------------ | -------------- |
| Skip        | 시퀀스에서 지정한  위치까지 요소를 건너뒨다.                 | 해당 사항 없음 |
| SkipWhile   | 요소가 조건을 충족하지 않을 때까지 조건자 함수를 기반으로 하여 요소를 건너뛴다. | 해당 사항 없음 |
| Take        | 시퀀스에서 지정한 위치까지 요소를 사용한다.                  | 해당 사항 없음 |
| TakeWhile   | 요소가 조건을 충족하지 않을 때까지 조건자 함수를 기반으로 하여 요소를 사용한다. | 해당 사항 없음 |

### 조인 작업

| 메소드 이름 | 설명                                                         | c# 쿼리식 구문                          |
| ----------- | ------------------------------------------------------------ | --------------------------------------- |
| Join        | 키 선택기 함수를 기준으로 두 시퀀스를 join한 다음 값 쌍을 추출한다. | join ... in ... on ... equals ...       |
| GroupJoin   | 키 선택기 함수를 기준으로 두 시퀀스를 join한 다음 결과로 생성된 일치 항목을 요소마다 그룹화 한다. | join ... in ...on ... equals ..into ... |

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JoinGroupJoin
{
    class Product
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{Name ="Jelly", CategoryId = 0},
                new Product{Name = "Cookies",CategoryId = 0},
                new Product{Name = "IceCream",CategoryId = 0},
                new Product{Name = "Doll",CategoryId = 1},
                new Product{Name = "Robot",CategoryId = 1},
                new Product{Name = "TeaSet",CategoryId = 2},
                new Product{Name = "AirFryer"}
            };
            List<Category> catrgories = new List<Category>
            {
                new Category{Id = 0, CategoryName="Food"},
                new Category{Id = 1, CategoryName="Stationary"},
                new Category{Id = 2, CategoryName="DiningWare"}
            };
            Console.WriteLine("-----join-----");
            var g_query = from product in products
                          join category in catrgories on product.CategoryId equals category.Id
                          select new { product.Name, category.CategoryName };
            foreach (var item in g_query)
            {
                Console.WriteLine($"{item.Name} - {item.CategoryName}");
            }

            Console.WriteLine("-----GroupJoin-----");
            var ProductsGroups = from category in catrgories
                                 join product in products on category.Id equals product.CategoryId into productGroup
                                 select productGroup;

            foreach(IEnumerable<Product> productGroup in ProductsGroups)
            {
                Console.WriteLine("Group");
                foreach(Product product in productGroup)
                {
                    Console.WriteLine($"{product.Name,10}");
                }    
            }
        }
    }
}
/*
-----join-----
Jelly - Food
Cookies - Food
IceCream - Food
Doll - Stationary
Robot - Stationary
TeaSet - DiningWare
AirFryer - Food
-----GroupJoin-----
Group
     Jelly
   Cookies
  IceCream
  AirFryer
Group
      Doll
     Robot
Group
    TeaSet
*/
```

### 데이터 그룹화

| 메소드 이름 | 설명                                                         | c# 쿼리식 구문                          |
| ----------- | ------------------------------------------------------------ | --------------------------------------- |
| GroupBy     | 공통 특성을 고유하는 요소를 그룹화한다.                      | group ... by<br />group ... by ... into |
| ToLookup    | 키 선택기 함수에 따라 Lookup<TKey, TElement>에 요소를 삽입한다. | 해당 사항 없음                          |

### 생성작업

| 메소드 이름    | 설명                                                   | c#쿼리식 구문  |
| -------------- | ------------------------------------------------------ | -------------- |
| DefaultIfEmpty | 빈 컬렉션을 기본값을 갖는 singleton 컬렉션으로 바꾼다. | 해당 사항 없음 |
| Empty          | 비어있는 컬렉션을 반환한다.                            | 해당 사항 없음 |
| Range          | 일련의 숫자를 포함하는 컬렉션을 생성한다.              | 해당 사항 없음 |
| Repeat         | 반복되는 값이 하나 들어있는 컬렉션을 생성한다.         | 해당 사항 없음 |

### 같음 연산

| 메소드 이름   | 설명                                                         | c# 쿼리 식 구문 |
| ------------- | ------------------------------------------------------------ | --------------- |
| SequenceEqual | 쌍 단위 방식으로 요소를 비교하여 두 시퀀스가 서로 같은지 확인한다. | 해당 사항 없음  |

### 요소 작업

| 메소드 이름      | 설명                                                         | c# 쿼리 식 구문 |
| ---------------- | ------------------------------------------------------------ | --------------- |
| ElementAt        | 컬렉션에 지정된 인덱스에 있는 요소를 반환한다.               | 해당 사항 없음  |
| ElementOrDefault | 켈렉션에 지정된 인덱스에 있응 요소를 반환하거나, 인덱스가 범위를 벗어나면 기본값을 반환한다. | 해당 사항 없음  |
| First            | 컬렉션의 첫 번째 요소 또는 특정 조건에 맞는 첫 번째 요소를 반환한다. | 해당 사항 없음  |
| FirstOrDefault   | 컬렉션의 첫 번째 요소 또는 특정 조건에 맞는 첫 번째 요소를 반환하거나, 이러한 요소가 없으면 기본값을 반환한다. | 해당 사항 없음  |
| Last             | 컬렉션의 마지막요소 또는 특정 조건에 맞는 마지막 요소를 반환한다. | 해당 사항 없음  |
| LastOrDefault    | 컬렉션의 마지막 요소 또는 특정 조건에 맞는 마지막 요소를 반환하거나, 이러한 요소가 없으면 기본값을 반환한다. | 해당 사항 없음  |
| Single           | 컬렉션의 유일한 요소 도는 특정 조건에 맞는 유일한 요소를 반환한다. 반환할 요소가 없거나 두 개 이상 있는 경우 InvalidOperationException을 던진다. | 해당 사항 없음  |
| SingleOrDefault  | 컬렉션의 유일한 요소 또는 특정 조건에 맞는 유일한 요소를 반환한다. 반환할 요소가 없으면 기본값을 반환하고, 두개 이상이면 InvalidOperationException을 던진다. | 해당 사항 없음  |



### 데이터 형식 변환

| 메소드 이름  | 설명                                                         | c# 쿼리 식 구문                                             |
| ------------ | ------------------------------------------------------------ | ----------------------------------------------------------- |
| AsEnumerable | IEnumerator<T>로 형식화된 입력을 반환한다.                   | 해당 사항 없음                                              |
| AsQueryable  | (제네릭)IEnumerable을 (제네릭)IQueryable로 변환한다.         | 해당 사항 없음                                              |
| Cast         | 컬렉션의 요소를 지정된 형식으로 캐스트한다.                  | 명시적 형식범위를 사용한다. (ex : from string str in words) |
| OfType       | 지정된 형식으로 캐스트할 수 있는지 여부에 따라 값을 필터링한다. | 해당 사항 없음                                              |
| ToArray      | 컬렉션을 배열로 반환한다. 쿼리를 강제로 실행한다.            | 해당 사항 없음                                              |
| ToDictionary | 키 선택기 한수에 따라 Dictionary<TKey, TValue>에 요소를 배치한다. 쿼리를 강제로 실행한다. | 해당 사항 없음                                              |
| ToList       | 컬렉션을 List<T>로 변환한다. 쿼리를 강제로 실행한다.         | 해당 사항 없음                                              |

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingDataType
{
    class Plant
    {
        public string Name { get; set; }
    }
    class CarnivorousPlant : Plant
    {
        public string TrapType { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Plant[] plants = new Plant[] 
            {
            new CarnivorousPlant { Name = "Venus Fly Trap", TrapType = "Snap Trap" },
            new CarnivorousPlant { Name = "Pitcher Plant", TrapType = "Pitfall Trap" },
            new CarnivorousPlant { Name = "Sundew", TrapType = "Flypaper Trap" },
            new CarnivorousPlant { Name = "Waterwheel Plant", TrapType = "Snap Trap" }
            };

            var query = from CarnivorousPlant cPlant in plants
                        where cPlant.TrapType == "Snap Trap"
                        select cPlant;

            foreach (Plant plant in query)
                Console.WriteLine(plant.Name);

        }
    }
}
/*
Venus Fly Trap
Waterwheel Plant
*/
```



### 연결 작업

| 메소드 이름 | 설명                                           | c# 쿼리 식 구문 |
| ----------- | ---------------------------------------------- | --------------- |
| Concat      | 두 시퀀스를 연결하여 하나의 시퀀스를 구성한다. | 해당 사항 없음  |



### 집계 작업

| 메소드 이름 | 설명                                                         | c# 쿼리 식 구문 |
| ----------- | ------------------------------------------------------------ | --------------- |
| Aggregate   | 컬렉션 값에 대해 사용자 지정 집계 작업을 수행한다.           | 해당 사항 없음  |
| Average     | 값 컬렉션의 평균 값을 계산한다.                              | 해당 사항 없음  |
| Count       | 컬렉션에서 요소(선택적으로 조건자 함수를 충족하는 요소만)개수를 계산한다. | 해당 사항 없음  |
| LongCount   | 큰 컬렉션에서 요소(선택적으로 조건자 함수를 충족하는 요소만) 개수를 계산한다. | 해당 사항 없음  |
| Max         | 컬렉션의 최대값을 확인한다.                                  | 해당 사항 없음  |
| Min         | 컬렉션의 최소값을 확인한다.                                  | 해당 사항 없음  |
| Sum         | 컬렉션에 있는 값의 합계를 계산한다.                          | 해당 사항 없음  |

