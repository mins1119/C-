# 파일 다루기			20.08.25

------

--------

## 파일 정보와 디렉토리 정보 다루기

> 파일 ( File ) : 컴퓨터 저장 매체에 기록되는 데이터의 묶음
>
> 디렉토리 ( Directory ) : 파일이 위치하는 주소, 파일(서류)를 담는 다는 의미에서 폴더( Folder )라고도 한다.

.NET프레임워크에서는 System.IO 네임스페이스 아래에 다음과 같은 클래스들을 제공한다.

| 클래스        | 설명                                                         |
| ------------- | ------------------------------------------------------------ |
| File          | 파일의 생성, 복사, 삭제, 이동, 조회를 처리하는 정적 메소드를 제공한다. |
| FileInfo      | File클래스와 하는 일은 동일하지만 정적 메소드 대신 인스턴스 메소드를 제공한다. |
| Directory     | 디렉토리의 생성, 삭제, 이동, 조회를 처리하는 정적 메소드를 제공한다. |
| DirectoryInfo | Diretory클래스와 하는 일은 동일하지만 정적메소드대신 인스턴스 메소드를 제공한다. |

하나의 파일에 대해 한 두가지의 작업을 할 때는 File클래스의 정적 메소드를 이용하고, 하나의 파일에 대해 여러가지 메소드를 이용할 때는 FileInfo클래스의 인스턴스 메소드를 사용하는 편이다.



------------

### 각 클래스들의 주요 메소드와 프로퍼티

(  ()가 붙어있는 항목은 메소드, ()가 없는 항목은 프로퍼티를 나타낸다. )

| 기능               | File            | FileInfo   | Directory         | DirectoryInfo    |
| ------------------ | --------------- | ---------- | ----------------- | ---------------- |
| 생성               | Create()        | Create()   | CreateDirectory() | Create()         |
| 복사               | Copy()          | CopyTo()   | -                 | -                |
| 삭제               | Delete()        | Delete()   | Delete()          | Delete()         |
| 이동               | Move()          | MoveTo()   | Move()            | MoveTo()         |
| 존재 여부 확인     | Exists()        | Exist      | Exists()          | Exist            |
| 속성 조회          | GetAttributes() | Attributes | GetAttributes()   | Attributes       |
| 하위 디렉토리 조회 | -               | -          | GetDirectories()  | GetDirectories() |
| 하위 파일 조회     | -               | -          | GetFiles()        | GetFiles()       |

**사용 예제**

| 기능           | FIle                                             | FileInfo                                                     |
| -------------- | ------------------------------------------------ | ------------------------------------------------------------ |
| 생성           | FileStream fs = File.Create("a.data");           | FileInfo file = new FileInfo("a.data");<br />FIleStream fs = file.Create(); |
| 복사           | File.Copy("a.data","b.data");                    | FileInfo src = new FileInfo("a.data");<br />FileInfo dst = src.CopyTo("b.data"); |
| 삭제           | File.Delete("a.data");                           | FileInfo file = new FileInfo("a.data");<br />file.Delete();  |
| 이동           | File.Move("a.data","b.data");                    | FileInfo file = new FileInfo("a.data");<br />file.MoveTo("b.data"); |
| 존재 여부 확인 | if(File.Exists("a.data"))<br />//..              | FileInfo file = new FileInfo("a.data");<br />if(file.Exists)<br />..// |
| 속성 조회      | Console.WriteLine(File.GetAttributes("a.data")); | FileInfo file = new FileInfo("a.data");<br />Console.WriteLine(file.Attributes); |

| 기능               | Directory                                           | DirectoryInfo                                                |
| ------------------ | --------------------------------------------------- | ------------------------------------------------------------ |
| 생성               | DirectoryInfo dir = Directory.CreateDirectory("a"); | DirectoryInfo dir = new Directory("a");<br />dir.Create();   |
| 삭제               | Directory.Delete("a");                              | DirectoryInfo dir = new DirectoryInfo("a");<br />dir.Delete(); |
| 이동               | Directory.Move("a","b");                            | DirectoryInfo dir = new DirectoryInfo("a");<br />dir.MoveTo("b"); |
| 존재 여부 확인     | if( Directory.Exists("a.dat"))<br />//..            | DirectoryInfo dir = new DirectoryInfo("a");<br />if( dir.Exists )<br />//.. |
| 속성 조회          | Console.WriteLine( Directory.GetAttributes("a"));   | DirectoryInfo dir = new DirectoryInfo("a");<br />Console.WriteLine(dir.Attributes); |
| 하위 디렉토리 조회 | string[] dirs = Directory.GetDirectories("a");      | DirectoryInfo dir = new DirectoryInfo("a");<br />DirectoryInfo[] dirs = dir.GetDirectories(); |
| 하위 파일 조회     | string[] files = Directory.GetFiles("a");           | DirectoryInfo dir = new DirectoryInfo("a");<br />FileInfo[] files = dir.GetFiles(); |

```c#
/*매개변수를 입력하지 않으면 현재 경로, 입력하면 입력한 경로에 대해 하위 디렉토리 목록과 파일의 목록을 차례대로 출력한다. 
하위 디렉토리 목록을 출력할 때는 이름과 속성을, 파일 목록을 출력할 때는 파일의 이름과 크기를, 속성을 출력한다.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Dir
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";
            else
                directory = args[0];

            Console.WriteLine($"{directory} directory info");
            Console.WriteLine(" - Directories :");
            var directories = (from dir in Directory.GetDirectories(directory) //하위 디렉토리 목록 조회
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes
                               }).ToList();

            foreach (var d in directories)
                Console.WriteLine($"{d.Name}, {d.Attributes}");

            Console.WriteLine(" - Files :");
            var files = (from file in Directory.GetFiles(directory) //하위 파일 목록 조회
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes
                         }).ToList();
            foreach (var f in files)
                Console.WriteLine($"{f.Name} : {f.FileSize},{f.Attributes}");

        }
    }
}
/*
c:\Users directory info
 - Directories :
All Users, Hidden, System, Directory, ReparsePoint, NotContentIndexed
Default, ReadOnly, Hidden, Directory
Default User, Hidden, System, Directory, ReparsePoint, NotContentIndexed
Public, ReadOnly, Directory
User, Directory
 - Files :
desktop.ini : 174,Hidden, System, Archive
*/
```

```c#
//매개변수로 입력받은 경로에 새 디렉토리나 파일을 만든다. 이미 파일이나 디렉토리가 존재한다면 최종 수정시간만을 갱신한다.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Touch
{
    class Program
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Usage : Touch.exe <Path> [Type:File/Directory]");
                return;
            }
            string path = args[0];
            string type = "File";
            if (args.Length > 1)
                type = args[1];

            if (File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated {path} {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Created {path} {type}");
            }
        }
    }
}
```

![fileio_1](https://user-images.githubusercontent.com/40557177/91115598-8276f000-e6c5-11ea-923a-58797a645f1a.png)



------

---------

## 파일의 입력과 출력

**스트림 ( Stream )**

데이터가 흐르는 통로이자 데이터의 흐름

- 메모리에서 하드디스크나 DVD와 같은 저장매체로 데이터를 옮길 때, 먼저 스트림을 만들어 둘 사이를 연결한 뒤에 메모리에 있는 데이터를 바이트 단위로 저장매체로 옮겨넣는다. 저장매체에서 메모리로 옮길 때도 마찬가지.

- 스트림의 구조는 네트워크나 데이터 백업장치의 입/출력 구조와도 통하기 때문에 스트림을 입력하면 파일이 아닌 네트워크를 향해 데이터를 읽거나 보낼수 있고 테이프 백업 장치를 통해 데이터를 기록하거나 읽을 수 있다.

- 순차 접근 방식

> **순차 접근( Sequential Access )방식과 임의 접근 ( Random Access )방식**
>
> 순차 접근 : 데이터를 처음부터 끝까지 순서대로 읽고 쓰는 방식
>
> 임의 접근 : 임의의 주소에 있는 데이터에 접근하는 방식



--------

----------

##  System.IO.Stream

- Stream클래스는 그 자체로 입력 스트림, 출력 스트림의 역할을 모두 할 수 있으며 순차 접근 방식과 임의 접근 방식 모두를 지원한다.

- Stream클래스는 스트림이 다루는 다양한 매체나 장치들에 대한 파일입출력을 다루기 위해 추상클래스이다. 때문에 인스턴스를 직접 만들어 사용할 수 없고, 파생클래스를 사용해야 한다.



- **파생클래스 계보**
  - FileStream :		   디스크 파일에 데이터를 기록한다.
  - NetworkStream :  네트워크 피어에 데이터를 전송한다.
  - GZipStream :         데이터를  GZip(GNU ZIP)형식으로 합축한다.
  - BufferedStream :  데이터 파일이나 네트워크에 즉시 기록하는 대신 메모리 버퍼에 담아뒀다가 일정량이 쌓일 때마다 기록한다.

![stream](https://user-images.githubusercontent.com/40557177/91125688-48b1e380-e6dd-11ea-906e-f3a02ed7b653.png)



-------

### **인스턴스 생성**

```c#
// 새파일 생성
Stream stream1 = new FileStream("a.dat", FileMode.Create);
// 파일 열기
Stream stream2 = new FileStream("b.dat", FileMode.Open);
// 파일을 열거나 파일이 없으면 생성
Stream stream3 = new FileStream("c.dat", FileMode.OpenOrCreate);
// 파일을 비워서 열기
Stream stream4 = new FileStream("d.dat", FileMode.Truncate);
// 덧붙이기 모드로 열기
Stream stream5 = new FileStream("e.dat", FileMode.Append);
```

---------

### **파일 쓰기**

FileStream 클래스는 파일에 데이터를 기록하기 위해 Stream 클래스로부터 물려받은 두가지 메소드를 오버라이딩 한다.

```c#
public override void Write(
		byte[] array,	// 쓸 데이터가 담겨있는 byte배열
		int offest,		// byte 배열 내의 시작 오프셋
		int count		// 기록할 데이터의 총 길이 ( 단위는 바이트 )
);
public override void WriteByte(byte value);
```

byte와 byte배열만을 입력할 수 있지만, BitConverter클래스를 사용해서 각종 형식들을 변환할 수 있다.

```c#
long someValue = 0x123456789ABCDEF0;
// 1. 파일 스트림 생성
Steam OutStream = new FileStream("a.dat", FileMode.Create);
// 2. someValue(long 형식)를 byte배열로 변환
byte[] wBytes = BitConverter.GetBytes(someValue);
// 3. 변환한 byte배열을 파일 스트림을 통해 파일로 기록
outStream.Write(wBytes, 0, wBytes.Length);
// 4. 파일 스트림 닫기
outStream.Close();
```

---------

### 데이터 읽어오기

FileStream 클래스는 파일에서 데이터를 읽기 위해 Stream 클래스로부터 물려받은 두가지 메소드를 구현한다.

```c#
public override int Read(
	byte[] array, // 읽은 데이터를 담을 byte배열
	int offset,	  // byte 배열 내의 시작 오프셋
	int count	  // 읽을 데이터의 최대 바이트 수 
);
public override int ReadByte();
```

```C#
byte[] rBytes = new byte[8];

// 1. 파일 스트림 생성
Stream inStream = new FileStream("a.dat", FileMode.Open);
// 2. rBytes의 길이만큼(8바이트) 데이터를 읽어 rBytes에 저장
inStream.Read(rBytes, 0, tbytes.Length);
// 3. BitConverter를 이용하여 rBytes에 담겨있는 값을 long형식으로 변환
long readValue = BitConverter.ToInt32(rBytes,0);
// 4. 파일 스트림 닫기
inStream.Close();
```



```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data",someValue);

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue);

            Console.Write("{0,-13} : ", "Byte array");

            foreach (byte b in wBytes)
                Console.Write("{0:X2} ", b);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
                rbytes[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rbytes, 0);

            Console.WriteLine("{0,-13} : 0x{1:X16}", "Read Data", readValue);

        }
    }
}
/*
Original Data : 0x123456789ABCDEF0
Byte array    : F0 DE BC 9A 78 56 34 12
Read Data     : 0x123456789ABCDEF0
*/
```

----------

### Position 프로퍼티

현재 스트림의 읽는 위치 또는 쓰는 위치를 나타낸다.





FileStream 객체를 생성할 때 Position이 0이 되고, WriteByte()포지션을 호출 할 때마다 데이터를 기록하고 자동으로 Position이 1씩 증가한다.

- 순차 접근  -  Write() 나 WriteByte()메소드를 차례차례 호출하면 여러개의 데이터를 기록할 수 있다.

- 임의 접근  -  Seek메소드나 프로퍼티에 직접 원하는 값을 대입하여 임의의 위치에 Position을 위치하도록 할 수 있다.

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqRand
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x01);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x02);
            Console.WriteLine($"Position : {outStream.Position}");
            
            outStream.WriteByte(0x03);
            Console.WriteLine($"Position : {outStream.Position}");
            
            outStream.Seek(5,SeekOrigin.Current);
            Console.WriteLine($"Position : {outStream.Position}");
            
            outStream.WriteByte(0x04);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.Close();
        }
    }
}
/*
Position : 0
Position : 1
Position : 2
Position : 3
Position : 8
Position : 9
/*
```



------

### 이진 데이터 처리를 위한 BinaryWriter / BinaryReader

FileStream 클래스는 파일처리를 위한 모든 것을 가지고 있지만, 형변환으로 사용하기 불편하다는 문제가 있었다.

이러한 불편함을 해소하기 위해 BinaryWriter와 binaryReader 클래스를 제공한다.

BinaryWriter 는 스트림에 이진 데이터를 기록하고 BinaryReader 는 스트림으로 부터 이진 데이터를 읽어들이기 위한 목적으로 만들어졌다.

BinaryWriter와 BinaryReader 를 사용하려면 Stream으로부터 파생된 클래스의 인스턴스가 있어야 한다.



```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));

            bw.Write(int.MaxValue);
            bw.Write("Good Morning");
            bw.Write(uint.MaxValue);
            bw.Write("안녕히세요");
            bw.Write(double.MaxValue);

            bw.Close();

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");

            br.Close();
        }
    }
}
/*
File size : 45 bytes
2147483647
Good Morning
4294967295
안녕히세요
1.79769313486232E+308
*/
```



------

### 텍스트 파일 처리를 위한 StreamWriter / StreamReader

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));

            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good Morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요");
            sw.WriteLine(double.MaxValue);

            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            Console.WriteLine($"File size : {sr.BaseStream.Length}bytes");

            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
        }
    }
}
/*
File size : 78bytes
2147483647
Good Morning
4294967295
안녕하세요
1.79769313486232E+308
*/
```



-----

------

## 직렬화

BinaeyReader/writer와 StreamWriter/Reader는 기본 데이터 형식을 지원하며, 직접 정의한 클래스나 구조체 같은 복합데이터 형식은 지원하지 않는다.

복합데이터 형식을 쉽게 스트림에 읽고 쓰게 하기 위해 직렬화( Serialization ) 메커니즘을 제공한다.



----------

### **직렬화( Serialization )**

객체의 상태( 필드에 저장된 값)를 메모리나 영구 저장 장치에 저장이 가능한 0과1의 순서로 바꾸는 것



1. [Serializable] 애트리뷰트를 클래스 앞에 붙여준다.

```c#
[Serializable]
class MyClass{ ... }
```

2. Stream클래스와 BinaryFormatter를 이용해서 간단히 저장할 수 있다.

```c#
Stream ws = new FileStream("a.dat",FileMode.Create);
BinaryFormatter serializer = new BinaryFormatter();

MyClass obj = new MyClass();	//obj의 필드에 값 저장

serializer.Serialize(ws, obj);	//직렬화
ws.Close();
```

> **BinaryFormatter**
>
> System.Runtime.Serialization.Formatters.Binary 네임 스테이스에 소속되어 있고 직렬화(Serialization)하거나 역직렬화(Desrialization) 역할을 한다.

```c#
Stream re = new FileStream("a.dat",FileMode.Open);
BinaryFormatter deserializer = new BinaryFormatter();

MyClass obj = (MyClass)deserializer.Deserialize(rs);
re.Close();
```



-------

### 직렬화 제외

상태를 저장하고 싶지 않은 필드가 있다면 그 필드만 [NonSerialized] 애트리뷰트로 수식한다.

``` c#
[Serializable]
class MyClass
{
	public int myfield1;
    public int myfield2;
    
    [NonSerialized]
    public int myfield3;	//myfield3을 제외한 나머지 필드만 직렬화된다.
    
    public int myfield4;
}
```

> **복합 데이터를 직렬화할 때 주의할 점**
>
> 직렬화하지 않는 필드뿐만아니라 직렬화하지 '못하는' 필드도 Nonserialize필드로 수식해야한다.

```c#
class NonserializableClass
{
    public int myfield;
}
[Serializable]
class MyClass
{
    public int myfield1;
     
    public NonserializableClass myfield2;//NonserializableClass는 Serializable하지 않으므로 직렬화를 수행할때 오류가 발생한다.
    /*
    1. NonserializableClass를 Serializable애트리뷰트로 수식하거나
    2. myfield2를 [NonSerialized]로 수식하거나
    */
}
```

```c#
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            NameCard nc = new NameCard();
            nc.Name = "Alice";
            nc.Phone = "123-456-789";
            nc.Age = 10;

            serializer.Serialize(ws, nc);
            ws.Close();

            Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            NameCard nc2;
            nc2 = (NameCard)deserializer.Deserialize(rs);
            rs.Close();

            Console.WriteLine($"Name : {nc2.Name}");
            Console.WriteLine($"Phone : {nc2.Phone}");
            Console.WriteLine($"Age : {nc2.Age}");
        }
    }
}
/*
Name : Alice
Phone : 123-456-789
Age : 10
*/
```

- 컬렉션들도 직렬화가 가능하다.

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializingCollection
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard("Alice", "123", 10));
            list.Add(new NameCard("Belle", "456", 15));
            list.Add(new NameCard("Cinderella", "789", 16));

            serializer.Serialize(ws, list);
            ws.Close();

            Stream rs = new FileStream("a.dat", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            List<NameCard> list2;
            list2 = (List< NameCard >) deserializer.Deserialize(rs);
            rs.Close();

            foreach(NameCard nc in list2)
            {
                Console.WriteLine($"Name : {nc.Name},Phone : {nc.Phone}, Age : {nc.Age}");
            }
        }
    }
}
/*
Name : Alice,Phone : 123, Age : 10
Name : Belle,Phone : 456, Age : 15
Name : Cinderella,Phone : 789, Age : 16
*/
```



