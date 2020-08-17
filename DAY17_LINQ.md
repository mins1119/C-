# LINQ													20.08.17

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

데이터를 특정기준에 따라 나누어 정리한다.

```c#
group A by B into C
```

A에는 from절에서 뽑아낸 범위변수를, B에는 분류기준을, C에는 그룹변수를 위치시킨다.

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

정렬

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

