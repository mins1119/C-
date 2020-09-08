# Winform

**폼 디자이너 툴**

WYSIWYG ( What You See Is What You Get ) 개발 방식으로, 프로그래머가 그림 그리듯 UI를 만들수 있게 한다. 



--------

-------------

## **Winfrom 클래스를 이용한 윈도우 생성 절차**

1. System.Windows.Forms.Form 클래스에서 파생된 윈도우 폼 클래스를 선언한다.
2. 1. 에서 만든 클래스의 인스턴스를 System.Windows.Forms.Application.Run() 메소드에 매개변수로 넘겨 호출한다.



**프로젝트 생성 절차**

1. '콘솔 앱' 템플릿으로 프로젝트를 생성한다.
2. 프로젝트의 참조 항목에서 추가를 누른 뒤 [어셈블리] -> [프레임워크] 에서 System.Windows.Form 어셈블리를 찾아 선택한다.

```c#
using System;

namespace Winform
{
    class MainApp : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.Run(new MainApp());
        }
    }
}
```



--------

------------------

## Application 클래스

Application 클래스는 크게 두가지 역할을 수행한다.

1. 윈도우 응용 프로그램을 시작하고 종료 시키는 메소드를 제공한다.
2. 윈도우 메세지를 처리한다.



Application.Run()

- 응용 프로그램을 시작하도록 한다.

Application.Exit()

- 응용 프로 그램을 종료시킨다.
  - Exit() 메소드가 호출된다고 바로 종료되는 것은 아니다. Exit()메소드는 응용 프로그램이 갖고 있는 모든 윈도우들을 닫은 뒤 Run()메소드가 반환되도록 한다.

```c#
using System;
using System.Windows.Forms;

namespace UsingApplication
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();

            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });
            Console.WriteLine("Starting Application...");
            Application.Run(form);

            Console.WriteLine("Exiting window Application...");
        }
    }
}
```



### 메시지 필터링 ( Message Filtering )

- 응용 프로그램이 받는 수많은 메세지 중 관심있는 메세지만 걸러내는 기능
- Application.AddMessageFilter() 메소드는 응용 프로그램에 메세지 필터를 설치한다.
  - 매개변수로 IMessageFilter 인터페이스를 구현하는 파생 클래스의 인스턴스를 매개변수로 받으며, IMessageFilter는 PreFilterMessage() 메소드를 구현할 것을 요구한다.



윈도우 운영체제에서 정의하고 있는 메세지는 식별 번호 (ID)가 붙어있다. Application 클래스는 특정 ID를 걸러내는 필터를 함께 등록해뒀다가 해당 프로그램에 메세지가 전달되면 필터를 동작시킨다.

> 윈도우 기반의 프로그램들은 갑자기 일어나는 사건( 이벤트 : Event )에 반응해서 코드가 실행되는 '이벤트 기반 방식' 으로 만들어진다.
>
> '마우스 클릭', '키보드 입력' 과 같은 이벤트들은 윈도우 운영체제가 일으킨다. 사용자가 마우스나 키보드와 같은 하드웨어를 제어하면 인터럽트가 발생하고,, 이 인터럽트를 윈도우 운영체제가 받아들인다. 운영체제는 다시 이 인터럽트를 바탕으로 윈도우 메세지( Window Message )를 만든 뒤 이벤트를 받아야 하는 응용 프로그램에 전달한다.



```c#
public interface IMessageFilter
{
    bool PreFilterMessage(ref Message m);
}
```

```c#
//IMessageFilter를 상속하는 클래스
public class MessageFilter : IMessageFilter
{
    public bool PreFilterMessage( ref Message m )
    {
        if(m.Msg >= 0x200 && m.Msg <- 0x20E )
        {
            Console.WriteLine("발생한 메세지 : "+m.Msg);
            return true; //입력받은 메세지를 처리했으니 응용 프로그램은 관심을 가질 필요가 없다는 의미
        }
        return false;	//메세지를 건드리지 않았으니 응용 프로그램이 처리하면 된다는 의미
    }
}
```



#### Message 구조체의 프로퍼티

| 프로퍼티 | 설명                                                         |
| -------- | ------------------------------------------------------------ |
| HWnd     | 메세지를 받는 윈도우의 핸들(Handle : 윈도우의 인스턴스를 식별하고 관리하기 위해 운영체제가 붙여놓은 번호). |
| Msg****  | **메세지 ID.**                                               |
| LParam   | 메세지를 처리하는 데 필요한 정보가 담겨있다.                 |
| WParam   | 메세지를 처리하는 데 필요한 부가 정보가 담겨있다.            |
| Result   | 메세지 처리에 대한 응답으로 윈도우 운영체제가에 반환되는 값을 지정한다. |

```c#
using System;
using System.Windows.Forms;

namespace MessageFilter
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0F || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x113)
                return false;
            Console.WriteLine($"{m.ToString()} : {m.Msg}");

            if (m.Msg == 0x201)
                Application.Exit();

            return true;
        }
    }
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp());
        }
    }
}
```



## 윈도우를 표현하는 Form 클래스

### Form에 정의되어 있는 이벤트와 이벤트 처리기 연결하기

```c#
class MyFrom : Form
{
    //이벤트 처리기 선언
    private void Form_MouseDown(object sender, System.Windoes.Forms.MouseEventArgs e)
    {
        MessageBox.Show("안녕하세요");
    }
    public MyForm()
    {
        //이벤트 처리기를 이벤트에 연결
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
    }
}
```

**MouseDown 이벤트**

```c#
public event MouseEventHandler MouseDown; //EventHandler는 대리자.
```

**MouseEventHandler**

```c#
public delegate void MouseEventHandler( object sender, MouseEventArgs e);
```

이벤트 처리기는 반환 값이 없고, 두 개의 매개변수를 받아들인다. 

첫 번재 매개변수는 object형식으로, sender는 이벤트가 발생한 객체를 가리킨다. 두 번재 매개변수는 MouseEventArgs 형식인데 마우스 이벤트의 상세 정보를 제공한다.

| 프로퍼티 | 설명                                                         |
| -------- | ------------------------------------------------------------ |
| Button   | 마우스의 어떤 버튼(좌우 떠는 가운데)에서 이벤트가 발생했는지 나타낸다. |
| Clicks   | 마우스의 버튼을 클릭한 횟수를 나타낸다.                      |
| Delta    | 마우스 휠의 방향과 회전한 거리를 나타낸다.                   |
| X        | 마우스 이벤트가 발생한 폼 또는 컨트롤 상의 x(가로) 좌표를 나타낸다. |
| Y        | 마우스 이벤트가 발생한 폼 도는 컨트롤 상의 y(세로) 좌표를 나타낸다. |

```c#
using System;
using System.Windows.Forms;

namespace FromEvent
{
    class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e )
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X : {e.X}, Y : {e.Y}");
            Console.WriteLine($"Button : {e.Button}, clicks : {e.Clicks}");
            Console.WriteLine();
        }
        public MainApp(string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event Test"));
        }
    }
}
```



### Form의 프로퍼티를 조절하여 윈도우 모양 바꾸기

| 종류   | 프로퍼티        | 설명                                           |
| ------ | --------------- | ---------------------------------------------- |
| 크기   | Width           | 창의 너비를 나타낸다.                          |
|        | Height          | 파의 높이를 나타낸다.                          |
| 색깔   | BackColor       | 창의 배경 색깔을 나타낸다.                     |
|        | BackgroundImage | 창의 배경이미지를 나타낸다.                    |
|        | Opacity         | 창의 투명도를 나타낸다.                        |
| 스타일 | MaximizeBox     | 최대화 버튼을 설치할 것인지의 여부를 나타낸다. |
|        | MinimizeBox     | 최소화 버튼을 설치할 것인지의 여부를 나타낸다. |
|        | Text            | 창의 제목을 나타낸다.                          |

Opacity

- double형식으로 0.00부터 1.00사이의 값을 가진다. 0에 가까울 수록 투명해지고, 1에 가까울 수록 불투명해진다.

 MaximizeBox / MinimizeBox

- boolean형식으로 버튼을 창에 표시하고자 할 때는 true를 입력하고 감추고자 할 때는 false를 입력한다.

Text

- string형식으로 창의 제목이 변경된다



```c#
//우클릭 : 가로가 길게, 좌클릭 : 세로가 길게
using System;
using System.Windows.Forms;

namespace FormSize
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.Width = 300;
            form.Height = 200;

            form.MouseDown += new MouseEventHandler(form_MouseDown);
            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldWidth = form.Width;
            int oldHeight = form.Height;

            if(e.Button == MouseButtons.Left)
            {
                if(oldWidth < oldHeight)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(oldWidth < oldHeight)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }  
            }
            Console.WriteLine("윈도우의 크기가 변경되었습니다.");
            Console.WriteLine($"Width : {form.Width}. Height : {form.Height}");
        }
    }
}

```

```c#
//배경이미지와 투명도 조절
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FromBackground
{
    class Mainapp : Form
    {
        Random rand;
        public Mainapp()
        {
            rand = new Random();

            this.MouseWheel += new MouseEventHandler(Mainapp_MouseWheel);
            this.MouseDown += new MouseEventHandler(Mainapp_MouseDown);
        }
        void Mainapp_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0,255), rand.Next(0, 255));
            }
            else if(e.Button == MouseButtons.Right)
            {
                if(this.BackgroundImage != null)
                {
                    this.BackgroundImage = null;
                    return;
                }
                string file = "bee.jpg";	//실행 파일과 같은 디렉토리
                if (System.IO.File.Exists(file) == false)
                    MessageBox.Show("이미지 파일이 없습니다.");
                else
                    this.BackgroundImage = Image.FromFile(file);
            }
        }
        void Mainapp_MouseWheel(object sender, MouseEventArgs e)
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1: -0.1);
            Console.WriteLine($"Opacity : {this.Opacity}");
        }

        static void Main(string[] args)
        {
            Application.Run(new Mainapp());
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Mainapp
            // 
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Name = "Mainapp";
            this.ResumeLayout(false);

        }
    }
}
```

```c#
//최대화 최소화 버튼 및 창 제목
using System;
using System.Windows.Forms;

namespace FormStyle
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            
            form.Width = 400;
            form.MouseDown += new MouseEventHandler(form_MouseDown);

            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;

            if(e.Button == MouseButtons.Left)
            {
                form.MaximizeBox = true;
                form.MinimizeBox = true;
                form.Text = "최소화/ 최대화 버튼이 활성화 되었습니다.";
            }
            else if(e.Button == MouseButtons.Right)
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Text = "최소화/ 최대화 버튼이 비활성화 되었습니다.";
            }
        }
    }
}
```



### Form 위에 컨트롤 올리기

> 컨트롤 ( Control )
>
> 윈도우 운영체제가 제공하는 사용자 인터페이스 요소를 말한다. 버튼, 텍스트 박스등이 있다.
>
> 유닉스의 모티프나 자바의 스윙 같은 GUI프로그램에서는 위젯이라고 하고, 델파이에서는 VCL (Visual Component Library)라고 한다.

1. 컨트롤의 인스턴스 생성

   - WinFrom의 모든 컨트롤은 System.Windows.Forms.Control을 상속한다. 

     ```c#
     Button button = new Button();
     ```

2. 컨트롤의 프로퍼티에 값 지정

   ```c#
   button.Text = "Click Me!";
   button.Left = 100;
   button.Top = 50;
   ```

3. 컨트롤의 이벤트에 이벤트 처리기 등록

   - 컨트롤은 애플리케이션의 정보를 표시하는 기능도 하지만 입력을 받는 창구이기도 하다. 

   ```c#
   button.Click +=
       (object sender , EventArgs e) =>
   	{
       	MessageBox.Show("딸깍");
   	};
   ```

4. 폼에 컨트롤 추가

   - From 인스턴스를 생성하고, 이 인스턴스에 Controls 프로퍼티의 Add() 메소드를 호출하여 button객체를 Form에 올린다.

   ```c#
   MainApp form = new MainApp();
   form.Controls.Add(button);
   ```



```c#
using System;
using System.Windows.Forms;

namespace FormAndControl
{
    class MainApp :  Form
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "Click Me";
            button.Left = 100;
            button.Top = 50;

            button.Click +=
                (object sender, EventArgs e) =>
                {
                    MessageBox.Show("딸깍");
                };

            MainApp form = new MainApp();
            form.Text = "Form & Control";
            form.Height = 150;

            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}
```



----------

-------------

## 폼 디자이너를 이용한 Winform  UI 구성

도구상자( 건트롤 팔레트 : Control Pallete )와 폼디자이너를 사용해 UI를 구성하는 방법

1. 도구상자에서 사용할 컨트롤을 골라 마우스 커서를 위치시키고 왼쪽버튼을 클릭한다.
2. 마우스 커서를 그대로 폼 디자이너 위로 옮긴 뒤 다시 왼쪽 마우스 버튼을 클릭한다.
3. 폼 위에 올려진 컨드롤의 위치 및 크기, 프로퍼티를 수정한다.

### GroupBox, Label, ComboBox, CheckBox, TextBox

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControls
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);

        }
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0)
                return;
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked)
                style |= FontStyle.Bold;

            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }
        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

    }
}
```

### TrackBar, ProgressBar

```c#
private void tbDummy_Scroll(object sender, EventArgs e)
{
    pgDummy.Value = tbDummy.Value;
}
```



### Button, Form, Dialog

> Modal : 창을 띄우고 나면 창을 닫을 때 까지 프로그램의 다른 UI를 사용할 수 없다.
>
> Modaless : 창을 띄우고 난 뒤에도 프로그램의 다른 UI에 사용자가 접근할 수 있다.

```c#
private void btnModal_Click(object sender, EventArgs e)
{
    Form frm = new Form();
    frm.Text = "Modal Form";
    frm.Width = 300;
    frm.Height = 100;
    frm.BackColor = Color.Red;
    frm.ShowDialog();	//Modal창을 띄운다.
}
private void btnModaless_Click(object sender, EventArgs e)
{
    Form frm = new Form();
    frm.Text = "Modaless Form";
    frm.Width = 300;
    frm.Height = 300;
    frm.BackColor = Color.Blue;
    frm.Show();		//Modaless창을 띄운다.
}
private void btnMsgBox_Click(object sender, EventArgs e)
{
    MessageBox.Show(txtSampleText.Text,
                    "MessageBox Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
```

 

### TreeView, ListView

```c#

```

