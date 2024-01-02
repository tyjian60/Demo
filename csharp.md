# C#筆記
## 1. C#是什麼
教學影片：[小山的 C# 教學-第1課-C# 是甚麼？](https://youtu.be/GDnI1_JyfwA?si=OiyRnDnBDVJKNdmL)


### C# 是由 Microsoft (微軟) 公司推出的程式語言

* C# 比較適合在 Windows 下面運行
### C# 是物件導向的程式語言
* 「物件導向」簡單來說就是「透過建立物件，並且讓這些物件互動，來達成你想完成的目標」
* 物件導向有三個原則「封裝(Encapsulation)」、「繼承(Inheritance)」、「多形(Polymorphism)」
### C# 必須要配合「.NET Framework」來運行
* C# 經過編譯之後，得到的是一種稱為「中間代碼」的東西，而不是組合語言的程式碼。
C# -> (compiler) -> IL(中間代碼) -> (.NET Framework) -> machine code

---

## 2. IDE 與 Hello World
教學影片：[小山的 C# 教學-第2課-IDE 跟 Hello World
](https://youtu.be/EFGi2KYO42w?si=2_4lg6pUlZo9cY7Y)


### 什麼是 IDE？
整合式開發環境 (IDE) 是協助程式設計師高效地開發軟體程式碼的軟體應用程式。它透過將軟體編輯、建置、測試和封裝等功能整合至易於使用的應用程式，以提高開發人員的生產力。正如作家使用文字編輯器，會計師使用試算表一樣，軟體開發人員使用 IDE 來提高工作效率。


### 安裝 Visual studio

* Visual studio 可以在你打某個程式碼的單字時，自動補齊剩下的程式碼
* 最好常常按「Ctrl + S」存檔，因為未來是不可預測的

### 撰寫第一個程式「Hello World」

```
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
```

想要測試程式，按下 IDE 上面的「綠色箭頭」就可以執行了

---

## 2.1 Visual studio Visual Studio Community
教學影片：[小山的 C# 教學-第2.1課-Visual Studio Community
](https://youtu.be/5eEi3A0ClYU?si=5U-Dh8__jFDxSfCK)

### Visual Studio 是微軟開發的 IDE
有多種版本，一般用戶下載 Community 版即可

#### Visual Studio Community 有些使用限制如下：

* 公益使用 (教學、學術、開放原始碼) 不受限制
* 商用目的在官方公布的公司規模 (2019 年的規定是 250 台電腦內，或營業額一百萬美金以內) 以下，使用不受限制

[Visual Studio Community 官方網站](https://visualstudio.microsoft.com/zh-hant/vs/community/)

---

## 3. 程式結構與進入點
教學影片：[小山的 C# 教學-第3課-程式結構與進入點
](https://youtu.be/B9YGbcXuGck?si=5qmyvBPtPj3Px05m)

```
using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
```

### 我們可以大致將 C# 程式碼分成兩塊，一塊是含有 using 的區塊，一塊是程式碼的主要部分
* using 部分主要是在呼叫內建的程式庫
* 主要區塊就是我們編寫程式邏輯的地方
* C# 裡面，用大括號包起來的程式碼算是一個「區塊」。這個區塊屬於括號上面的程式碼所有。

### Hello World 的這個程式由裡到外分成三層，namespace、class、method
 
* namespace 可以想成是自己的程式庫，所以在 namespace 內寫程式碼就是在編寫自己的程式庫
* class 一般負責 namespace 裡面一部分的工作
* method 是在 class 下，負責更細部事務的東西。它有一個明顯的特徵，通常 method 後面都會跟著一個小括號，像是：void Example(int num)
#### static void main(string[] args) 是特別的 method，所有的 C# 程式都會從這個 method 開始執行。 一般稱之為「進入點(Entry Point)」
 
#### Console.WriteLine 跟 Console.ReadKey 也都是 method。前者會在黑色視窗上顯示文字，後者會等待使用者輸入任意字元

> ### Entry Point
>每個程式都會有個獨一無二的「進入點」，也就是作為電腦一開始執行的 method。C\C++ 一般是使用「int main(void)」，win32 的程式是使用「int WINAPI WinMain(...)」，而 C# 就是這個「static void main(string[] args)」。基本上，這個名稱是規定好的，所以不可以隨便更改。如果改成別的名字，電腦就會不知道該從哪裡開始執行。
>### Console
>寫過 C\C++ 程式的人，我想大多數顯示出來的結果都是出現在這個黑色的視窗上對吧？其實我們現在所看到這些視窗、按鈕甚麼的，背後都是由大量的程式碼所建立出來的。而且事實上，這些圖形的畫面是非常耗費資源。早期的程式設計師寫程式，都是在我們看到那個黑底白字的畫面上跑的。而 Console 就是 Windows 下的黑底白字介面。大家可以在「附屬應用程式」>「命令提示字元」那邊開啟 Console 的畫面。
>### using System
>大家可以看到程式裡面出現了 Console.WriteLine 以及其他 method。那這些 method 到底都寫在哪裡呢？事實上，就是寫在那些名為「System」的程式庫裡。那些程式庫包含了大量可以讓我們寫C# 更方便的程式碼，以及我們之後會用到的「視窗」也都是寫在名為「System.Windows.Forms」的程式庫內。想要使用這些程式庫，就必須要在程式碼上面打上「using {程式庫名稱}」才行。不過剛開始不太需要注意，因為你的 IDE 都會自動地幫你打理好這些問題。

#### 每一行程式碼都必須要加上「;」(分號)，代表一行的結束

---

## 4. 視窗與按鈕
教學影片：[小山的 C# 教學-第4課-視窗與按鈕
](https://youtu.be/5txYdHXgX44?si=FyHWQI5cG3-1tRaw)



#### 選擇「檔案」>「新增專案」>「Windows Form 應用程式」就可以自動地建立視窗程式

* IDE 內的「屬性」視窗可以修改視窗的設定值
    Ex: Text 是「視窗標題」、BackColor 是「背景顏色」
#### 想要放入按鈕，只要找到旁邊的「工具箱」視窗，然後把按鈕拖出來就可以了
* 想要修改其他物件的屬性，只要點一下那個物件，再去看屬性視窗即可

#### 當我們按下按鈕後，程式會自動執行「private void button1_Click(...)」這個 method 裡面的程式碼

* 「MessageBox.Show()」可以用來顯示對話框，小括號內放的就是要顯示的文字

---

## 5. 變數
教學影片：[小山的 C# 教學-第5課-變數
](https://youtu.be/lAO0YRPONkU?si=dO6zFCzVh_GLwyxN)

### 「變數」主要是在扮演「儲存資料」的腳色

* 所有的變數在使用之前，都必須先宣告過一遍，目的在於讓電腦先知道變數的「型別」是甚麼
* 想要宣告多個變數，只需要在變數中間用「,」區隔即可
* 「int」代表「整數(Integer)」，例如：-2、10、800000、-9999

### 「=」不是「相等」，而是「指定」

* 在使用變數之前，務必先存入某個數值。如果沒有這樣做，電腦不會讓你編譯它
* 如果怕自己忘記設定數值，可以在宣告的時候順便指定數值，像是...
```
int number = 10;
```
* 一般來說，變數的值是可以一直修改的

---


## 6. 基本計算
教學影片：[小山的 C# 教學-第6課-基本計算
](https://youtu.be/UvhsKnLPpIc?si=DXKMTeHjljXo6Cuc)

### 「+ - * /」分別代表「加減乘除」的意思

* 在 C# 裡面計算數學就只要單純地將數學式列出來就可以了，但是算式務必要在等號的右側，左側則是儲存結果的變數
* 除法要是遇到無法整除的情形，它仍會計算到小數點後
#### 如果你試圖要將小數存入 int(整數) 變數裡面，C# 會自動省略小數點之後，只留下整數的部分存進變數裡面

注意像是這種程式碼
```
int a;
a = 30 / 8;
```
那最後 a 裡面只會存入 8 而已，因為 a 是整數變數

* 如果你單純只想算除法的「餘數」的話，可以使用「%」這個符號

### 簡化寫法

下面這個式子
```
number = number + 8;
可以簡化為
number += 8;
```
「- * / %」也有相同的寫法

#### 如果今天只需要做單純「遞增」或「遞減」的計算，可以使用
```
number++;
number--;
```
這種寫法，上面分別代表 number 加一、減一

注意：「++」只適用於「+1」的情況


---


## 7. 變數宣告意義與型別
教學影片：[小山的 C# 教學-第7課-變數宣告意義與型別
](https://youtu.be/k2kjfxbWUuM?si=-64A9uRtpRPpPhCz)

### 宣告變數
先告知電腦到底我們要給這個變數多少記憶體空間(從 type 判斷)以及它的名稱是甚麼

* 在 C# 裡面，每個 int 的變數可以分配到 32 bits(4 bytes) 的記憶體空間。也就是說，對於每個 int 的變數，電腦會存放 32 個 0 或 1 在記憶體裡面
* int 只能儲存有限大小的數字，而這個範圍是從 2^31 - 1 到 - 2^31，也就是 2,147,483,647 到 - 2,147,483,648 這之間的數字
#### 想要儲存小數可以使用 float 或 double，一般使用可以儲存數字範圍較大的 double

* C# 會預先將所有數字當成 double 來處理

#### bool 只能儲存「true」、「false」兩種資料，這種數值通常用來儲存判斷式的結果

### C# 支援下列內建資料型別：

![image](https://hackmd.io/_uploads/BkxCJghDp.png)


---


## 8. string 字串
教學影片：[小山的 C# 教學-第8課-string 簡介
](https://youtu.be/Ru7j2X3WH-4?si=Oi0N276ddljgBLKg)

### string 字串
存放一連串的文字的變數，存放越多文字，變數所需要的記憶體空間就會越大

### string 宣告
`string str = "我是小山";`

### string 字串相加
```
string str1 = "我是小山";
string str2 = " 哈哈";
string str3 = str1 + str2;
```

str3輸出為>我是小山 哈哈

### 自動轉換
```
string str1 = "我是小山";
string str2 = " 哈哈 ";
int number = 123;
string str3 = str1 + str2 + number;
```

str3輸出為>我是小山 哈哈 123


---


## 9. Label 與 點擊次數記錄程式
教學影片：[小山的 C# 教學-第9課-Label 與 點擊次數記錄程式
](https://youtu.be/j2HL_tZqqVQ?si=zkopSsbDeB0ael3c)
### 目標
* 記錄並顯示點擊次數
* 可重置點擊次數
### 點擊次數記錄程式：[MouseClick](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/MouseClick)
1. 新增點擊按鈕
2. 新增重置按鈕
3. 新增Label
4. 完成點擊事件的實作，Label顯示已點擊按鈕次數，重置按鈕重置次數

---

## 10. if else
教學影片：[小山的 C# 教學-第10課-if else](https://youtu.be/YH2ho92yJgc?si=hDwEhMtYqgG2QcVX)

### if else 語法

```
if (判斷式是否成立)
{ 
  // 判斷式成立,則執行if區塊
} 
else 
{
  // 判斷式不成立,則執行else區塊
}
```

### else if 語法

```
if (判斷式1)
{ 
  // 判斷式1成立,則執行此區塊
  // 判斷式1不成立,則向下檢查判斷式2
} 
else if (判斷式2)
{
  // 判斷式2成立,則執行此區塊
  // 判斷式2不成立,則向下檢查判斷式3
}
else if (判斷式3)
{
  // 判斷式3成立,則執行此區塊
  // 判斷式3不成立,則向下檢查判斷式4
}
else
{
  // 判斷式皆不成立,則執行此區塊
}
```


---


## 11. for 與 while 迴圈
教學影片：[小山的 C# 教學-第11課-for 與 while 迴圈
](https://youtu.be/leAJFvCEsm8?si=iQHiLTL_LJXEbAfH)

### while 迴圈語法

```
while(判斷式)
{
    // 判斷式成立,則執行此區塊,執行完檢查判斷式是否再次執行
    // 判斷式不成立,跳出迴圈
}
```


### for 迴圈語法

```
for(初始變數; 判斷式; 遞增式) 
{
    // 初始變數:開始時執行一次
    // 判斷式成立,則執行此區塊,執行完成後執行遞增式,並再次檢查判斷式是否再次執行
    // 遞增式:每次執行迴圈完,都會執行遞增式
}
```

### 範例：乘法表

```
string text = "";
text += "7 x 1 = " + 7 * 1 + "\r\n";
text += "7 x 2 = " + 7 * 2 + "\r\n";
text += "7 x 3 = " + 7 * 3 + "\r\n";
text += "7 x 4 = " + 7 * 4 + "\r\n";
text += "7 x 5 = " + 7 * 5 + "\r\n";
text += "7 x 6 = " + 7 * 6 + "\r\n";
text += "7 x 7 = " + 7 * 7 + "\r\n";
text += "7 x 8 = " + 7 * 8 + "\r\n";
text += "7 x 9 = " + 7 * 9 + "\r\n";
```
#### while
```
string text = "";
int i = 1;
while(i <= 9)
{
    text += "7 x " + i + " = " + 7 * i + "\r\n";
    i++;
}
```

#### for
```
string text = "";
for (int i = 1; i <= 9; i++)
{
    text += "7 x " + i + " = " + 7 * i + "\r\n"; 
}
```

---



## 12. 註解與Debug
教學影片：[小山的 C# 教學-第12課-註解與 Debug
](https://youtu.be/QZfHKxiRm-4?si=bRMS7Ov8D8M07RJG)

### 註解

* 「註解」就是在程式碼上面做筆記，它的會以兩個「/」作為開頭
* 你可以盡量打各式各樣的「註解」，而且「註解」不會對程式碼產生影響
* 以兩個「/」 作為開頭的是「單行式」註解，而「多行式」的註解是以「/*」作為開頭，「*/」作為結尾
* 「註解」 可以幫助你記憶程式碼的作用，對自己對別人都很有用

### Debug
* 「debug」中文叫做「除錯」 ，也就是「排除錯誤」的意思
* 常用的「debug」方法之一是檢查程式流程有沒有發生問題


### Debug模式
* 在檢查程式流程之前，必須要先設立「中斷點(Break Point)」，也就是一個程式執行的時候一個使程式暫停下來的位置。
* 想要進入「debug 模式」只需要按下我們常按的那個「綠色箭頭」即可
* 「debug 模式」中「黃色箭頭」代表程式「目前暫停的位置」
* 只要把滑鼠游標移到變數旁邊，就可以看到變數目前的數值為多少。看下面的區域變數欄位也可以監視變數的動態。

>### 不進入函式
>也許有人注意到，在「debug 模式」下。「不進入函式」的左邊有一個「逐步執行」的按鈕，這個按鈕似乎看起來更像是一步一步執行的意思？其實兩個都會一步一步的執行程式碼。他們唯一不同的地方在於，如果你接下來要執行的程式碼中有 method 存在，「逐步執行」就會帶領你進入到那個 method 的程式碼區塊中。而「不進入函式」則只會單純地執行、跳過它而已。大多數的情況下都不會想進入 method 中，所以一般比較常使用到「不進入函式」這個按鈕。


---


## 13. NumericUpDown
教學影片：[小山的 C# 教學-第13課-NumericUpDown
](https://youtu.be/5DsLLcpZ0uU?si=_UUkbxQzFf7pmR8J)

### NumericUpDown
* numericUpDown 是一種可以用來選擇數字的元件
* numericUpDown 的 Value 屬性儲存的值是屬於 decimal 型別的
* 想要將不同型別的值存入變數中必須經過轉換

`int row = (int)rowChooser.Value;`

>### decimal 型別
>這個型別在其他程式語言中比較少見。基本上，decimal 也是數字型別的一種。因此將它強制轉型成 int 型別或是 double 型別的變數都不會與預料的結果差別太多。這種型別的變數通常會拿來做金融或是財務上的計算，C# 有提供許多相關的支援。詳情可以看「相關資訊連結」。

### 強制轉型

```
int a;
decimal b = 10;

a = (int)b; 
```
 
>所謂強制轉型，簡單來說就是要求程式無論結果如何，都要想辦法把資料轉成另一種型別。當然如此強硬的轉換，往往得到的結果不如預期。因此一般來說，不同型別的變數是不能互相存取的。但是，如果你確定兩個型別都是類似性質的東西。你就可以使用強制轉型來進行轉換。像是數字之間的轉換就通常不會有問題。
>強制轉型在 C 語言中，時常拿來處理記憶體分配以及 pointer 參數傳遞的問題。在 C# 中則拿來處理數字轉換比較多。

---

## 14. 物件導向基礎 Class (上)
教學影片：[小山的 C# 教學-第14課-物件導向基礎 Class
](https://youtu.be/gpjAFBh3GJ4?si=RLS6KLfopJfMMYlz)

### 物件導向
就是要透過物件之間的互動來完成工作

### 想要建立物件就必須要先定義 class

#### class 主要分成「property 屬性」、「method 方法」兩個部分

* 「property 屬性」代表 class 的性質，「method 方法」代表 class 的行為與能力
* method 的格式為「public output型別 method名稱(input型別與名稱)」

```
class Student
{
    public int StudentID;
    public string Name;
    public int Grade;

    public string Say()
    {
        return "我叫 " + Name + " ，我是 " + Grade + " 年級的學生";
    }
}
```

### 想要存取物件，就必須使用 class 的變數

* 一開始宣告 class 的變數後不會產生任何物件，必須要用「new class()」才能夠產生物件
* 只要在變數後面加上小數點，就可以存取物件的 property 跟 method 了
例如：「s.StudentID」、「s.Say()」

```
Student s = new Student();
s.Name = "小山";
s.Grade = 3;
s.Say();
```

---

## 15. 物件導向基礎 Class (下)
教學影片：[小山的 C# 教學-第15課-Class 簡介(續)
](https://youtu.be/AOrVcd4vDIk?si=w6w5br14OnUHp2Pf)

### 沒有輸出值的 method
如果沒有輸出值的話，就要用 void 代替輸出值
* void 代表「沒有任何值」

```
class Student
{
    public int StudentID;
    public string Name;
    public int Grade;

    // 沒有輸出值的 method
    public void Upgrade()
    {
        Grade++;
    }
}
```

### 有輸出值的 method

```
class Student
{
    public int StudentID;
    public string Name;
    public int Grade;

    // 沒有輸出值的 method
    public void Upgrade()
    {
        Grade++;
    }
    
    // 沒有輸入值，有輸出值的 method
    public string Say()
    {
        return "我叫 " + Name + " ，我是 " + Grade + " 年級的學生";
    }
    
    // 有輸入值，有輸出值的 method
    public string Talk(int sgrade, string sname)
    {
        return Grade+"年級的"+Name+" 對 "+sgrade+"年級的"+sname+" 說你好";
    }
    
}
```

### 將資料包裝成物件可以幫助重複使用資料

```
public string Talk(Student s)
{
    return Grade+"年級的"+Name+" 對 "+s.Grade+"年級的"+s.Name+" 說你好"
}
```


將物件傳入其他物件的 method 中使用就是一種「物件互動」的方式


---

## 16. Value 與 Reference Type
教學影片：[小山的 C# 教學-第16課-Value 與 Reference Type
](https://youtu.be/bYuoXhDy6zA?si=3ofwb0lZz-sk9Lcn)


### C# 型別(Type) 依照存取方式不同一共分為三種
#### Value Type 實質型別
「int (整數)」就是一種 Value Type。它會先在記憶體中尋找一個空間，標記為變數名稱，然後將我們指定的數值存入。
#### Reference Type 參考型別
上一課建立的 Student Class 則是一種 Reference Type。宣告 Reference Type 的變數時，也會先在記憶體中尋找一個空間，標記為變數名稱，然後裡面則「存放物件的記憶體位置」」。
#### Pointer Type 指標型別
將記憶體位址存在變數中，pointer本身就是一個變數並且具有一個值。

* pointer可以重新指派、設為null、增加減少等等，而reference只能引用一個物件
* 可以取得pointer的位置，但reference不行
* 通常我們在函數參數和回傳類別會使用reference，使用pointer來實作資料結構和演算法
* 由於pointer佔有記憶體空間，因此需要分配及釋放空間

#### 語法
```
dataType *pointerName = &Variable; //Pointer 

ref dataType Variable; //Reference 

dataType *pointerName = malloc( sizeof (*pointerName)); 
//Memory allocation of the pointer, of whatever data type it is. 

free(pointerName); //Free the memory used by the pointer.
```


* 物件必須要透過「new Class名稱()」的方式建立，沒有指向任何物件的 reference(參考) 變數，則存放著「null」。
*  C# 變數裡的資料都是存放在記憶體(Memory)內的
* 物件都是存放在一個稱為「Heap(堆疊)」的特殊記憶體區塊

>#### Pointer 指標
>有學過 C/C++ 程式語言的人相信都不陌生，而對部分的人來說，指標則是他們學習 C/C++ 的噩夢之一。指標是一種「專門存放記憶體位置」的變數。因為記憶體操作是一種非常危險的行為，而導致程式時常會不明地中斷。當然，如果對指標的行為有高度地了解，並且對程式使用記憶體的行為非常了解的話，就不會遇到這些錯誤。
一般來說，純物件導向的程式語言為了要隱藏背後複雜的操作行為，是不會給予使用者使用指標。例如 JAVA 的型別就只有兩種，Primitive Type 與 Class Type。但是 C# 則保留了指標這個型別，個人猜想可能是為了要延續 C/C++ 指標所扮演的重要性才留下來的。

[內建型別資料表](http://msdn.microsoft.com/zh-tw/library/ya5y69ds.aspx) (除了 object 與 string 外，表中的型別都是 value type)

[實質型別的所有類型
](http://msdn.microsoft.com/zh-tw/library/s1ax56ch.aspx)


---

## 17. Constructor 建構子
教學影片：[小山的 C# 教學-第17課-Constructor 建構子
](https://youtu.be/XsrXEGsrfo8?si=RuWgVER3jn_7_JNu)

`Student s1 = new Student(10201, "小王");`



### 所謂「建構子」就是一種特殊的 method，它的特徵有兩個：
* 不需要設定 output 型別
* method 名稱與 class 名稱相同

### 如果想要讓某個屬性的值預先設定好，可以在建構子內就指定一個數值給它
如果建構子需要接受初始值，那必須要在建立物件時給予。

例如：
```
Student s = new Student(10201, "小山");
```

#### 為了因應不同的情況，可以在 class 內撰寫多個建構子。就算名稱相同，只要輸入值的數量與型別不同即可。這種作法稱為 Overloaded
* 如果沒有撰寫建構子，編譯器會自動幫 class 產生一個沒有引數的預設建構子。
* 如果自己有撰寫建構子，編譯器就不會自動幫 class 產生預設建構子。


>### Overloaded 多載
>並不是只有建構子才有 overloaded ，只要是 method 都有可能會有這樣的性質。如果今天有兩個 method，這兩個 method 的名稱相同，但是 signatures 不同，那就是 overloaded。
>
>那甚麼是 signature 呢？signatures 指的就是引數(輸入值)的種類、數目、排列與 method 名>稱，例如下面這兩個 method 他們的變數名稱雖然不同，但是因為種類相同，method 名稱也相同，所以 signatures 就算相同。
>Example 1:
>```
>void sleep(int time, string s) {....}
>void sleep(int sleepTime, string sound) {....}
>```
>
>而下面這兩個雖然引數數目相同，但是型別不同，所以 signatures 就不相同
Example 2:
>```
>void eat(int numberOfFood) {....}
>void eat(string foodName) {....}
>```
>因此我們只需要辨別 signatures ，就可以知道 method 是否有重複。重複的 method 是沒有意義的，因為這種情況下，程式無法得知你到底是要呼叫哪一個 method。如 Ex1 中，C# 會當作沒看到第二個 method，所以你永遠無法呼叫到它。那你又為何要這樣寫呢？
>
>另外一個常見問題是，引數與 method 名稱都相同，但是 output 型別不同算是重複嗎？
答案是，算！請看下面這個例子
Example 3:
>```
>int run() {...}
>void run() {...}
>```
>如果我今天呼叫 run() 的話，你可以辨別我是要呼叫哪一個 run() 嗎？相信你應該了解了吧？這就是為什麼這樣也算是重複的 method。


---


## 18. this 變數
教學影片：[小山的 C# 教學-第18課-this 變數
](https://youtu.be/ETmSz-MEkZw?si=MIyeorIHRu7pieti)

### this 變數
this是一個指向自己物件本身的 Reference Type 的變數
* this變數會跟隨物件建立的瞬間產生
* 每個物件都有this變數
#### 如果程式與到出現相同變數的情況，會自動選擇比較「近」的變數
「近」的意思是指 Scope 範圍較小但是在仍在範圍內的意思
* 若將「this.」記為「這個物件的」會比較好記


---

## 19. static 修飾字
教學影片：[小山的 C# 教學-第19課-static 修飾字
](https://youtu.be/RlT_ddlhq5o?si=nyKMV_P4UjYhhU1n)

### static 修飾字
使用了 static 修飾過的變數、method，不需要建立物件就可以直接透過 class 名稱使用

`public static int PassScore = 60;`
* static 修飾過的變數是所有同 class 的物件共用的
* static class 不可以用來建立物件

---

## 20. TextBox 與 借還錢程式(上)
教學影片：[小山的 C# 教學-第20課-TextBox 與 借還錢模擬小程式(上)
](https://youtu.be/FlEdRULznbM?si=f3A6leq7_3EBkrrW)
### 目標
* 記錄自己跟朋友的借還錢狀況
* 使用物件記錄資訊
### 借還錢程式：[BorrowAndRepay](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/BorrowAndRepay)
1. 設計介面
2. 新增lebel及button等元件
3. 設定屬性

---


## 21. TextBox 與 借還錢程式(下)
教學影片：[小山的 C# 教學-第21課-借還錢模擬小程式(下)
](https://youtu.be/w2vmllTvgTo?si=I_Uf-Wq4TH-u7fvE)
### 目標
* 有效地將資料保存起來
* 完成按鈕功能
### 借還錢程式：[BorrowAndRepay](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/BorrowAndRepay)
1. 建立Person物件
2. 實作借還錢method
3. 更新TextBox的值

---

## 22. Array 陣列

教學影片：[小山的 C# 教學-第22課-Array 陣列
](https://youtu.be/qagAWVD4-zM?si=OYv9MBh3LL7O7EcM)

### Array 陣列
陣列通常用來存放大量類型相同的資料，如 1000 個整數等等

### 宣告方法
陣列的宣告方法如下，例如要宣告可以存放 40 個整數的陣列，名為 intArray：
```
int[] intArray = new int[40];
```

或是如果預先知道要存入的數值，也可以用下面的方式宣告：
(假設要預先存入 92, 83, 100)
```
int[] intArray = new int[] {92, 83, 100};
```

### 資料存取

如果要存取陣列內的資料，則需要打「陣列名稱 [ 編號 ]」
例如要存取整數陣列 scores 編號 3 的資料：
```
scores[3] = 100; // 在編號 3 的位置存入 100
```

* 陣列的編號是從 0 開始算起，因此如果陣列大小為 40 ，則可以用的編號是 0 ~ 39
* 陣列一開始會將每個位置的資料填上預設值，預設值則跟每一格存放的資料型別有關。不同型別的預設值請參考「相關資訊連結」的「預設值表」
* 如果使用了範圍外的編號，只有在程式執行時才會發現錯誤。因此要特別注意

### 物件陣列
除了 int, double 這些基本型別，也可以建立物件陣列。只需要將型別名稱替換成 class 名稱即可，例如要宣告大小 20 的 Student class 的陣列可以寫：
```
Student[] students = new Student[20];
```
* 陣列的大小是固定的，在宣告的時候就要決定
* 陣列也是一種物件


---


## 23. Garbage Collection 垃圾回收

教學影片：[小山的 C# 教學-第23課-Garbage Collection 垃圾回收
](https://youtu.be/qQPDdIK2bhc?si=Yyyo9_tC4pUWF3j5)

### 記憶體空間
* 電腦的記憶體中有一塊空間稱為 Heap 來存放物件的本體
* 當我們執行以下的程式碼後，電腦就會在 Heap 建立物件
```
new Student(...);
```
* 當我們向下面宣告物件的變數時，只是產生一個用來記住物件地址的 Reference 而已
```
Student s;
```
### Garbage Collection 垃圾回收
* C# 的程式執行時，背後有一個垃圾車會默默地檢查 Heap ，並刪除不需要的物件
* 當一個物件沒有任何 reference 指向(儲存物件的地址)他的時候，就會被判定為不需要的物件



---

## 24. Public vs. Private 封裝性

教學影片：[小山的 C# 教學-第24課-封裝性 Public vs Private
](https://youtu.be/eE0OvsyTFEM?si=_4wIeNF6v-k6ZcHt)

### Public vs. Private 封裝性

* Public 會使 Property 與 Method 變成任何人皆可觀看、使用與修改
* Private 會使 Property 與 Method 變成只有自己皆可觀看、使用與修改
* 一旦 Property 或 Method 被設為 Private, 那就只有同一個 Class 大括號範圍內的東西才有權限使用


---



## 25. Private 的常見用途

教學影片：[小山的 C# 教學-第25課-Private 的常見用途
](https://youtu.be/Js8AmCoecIo?si=FZ3AuumdXYiKkTmb)

### private 在以下三種狀況能夠使用：

#### 有些 Property 想要隱藏起來，不想讓 class 外的東西能夠隨意存取

像是： Password 密碼
因此可以將 Password 直接設為 private
如果有比對密碼的需求，只需要簡單寫一個 public 的 method 來做比較的工作即可

#### 有些 Property 只想設成唯讀，就是只能看，不能夠修改

像是：Account 帳號
同樣先將 Account 設成 private
然後建立一個 public 的 method 叫做 getAcoount 來讓 class 外的東西取得 Account 的內容

#### 想要讓某些 Property 在設定上有所限制

像是：HP 血量，限制：HP 不可以為負數
首先先將 HP 設為 private
然後建立一個 public 的 method 像是本課所提的 hurt 來間接設定它
如果想要觀看 HP 的數值，只要像 (2) 一樣
建立 getHP 的 method 即可 


---


## 26. Get & Set存取器

教學影片：[小山的 C# 教學-第26課-Get & Set 存取器
](https://youtu.be/6PksSUFebeE?si=_ETbUVzNygDx_q4W)

### 語法
Get & Set 存取器的語法如下：
```
.........  // 宣告變數(通常是 public)
{
    get { .... } // 希望變數讀取時執行的程式碼
    set { .... } // 希望數值存入時執行的程式碼
}
```
### 範例
```
// HP自動呼叫
private int hp;
public int HP
{
    get{return hp;}
    set{
        if (value < 0)
            hp = 0;
        else
            hp = value;
    }
}
```
* 如果只使用 get 而去除 set 的話，該變數將會變為唯讀
* 使用 Get & Set 存取器時，並不一定要有對應的 private 變數
* Get & Set 存取器可以用來即時運算一些平常大家認為是變數的數值，像是 Money
```
public int Money
{
    get{ return count1 + count5 * 5 + count10 * 10; }
}
```


---


## 27. Encapsulation 封裝

教學影片：[小山的 C# 教學-第27課-所以到底甚麼是封裝性？
](https://youtu.be/4F1CkH0lPn4?si=T6nVfVr8CixRyA7S)

### Encapsulation 封裝
所謂的「封裝性」指的就是：「隱藏物件內部的實作細節，只留下讓外人操作的介面(方法)」

### 封裝性的好處有二：
* 保護物件內部的變數
* 隱藏實作細節，讓別人使用只需知道使用方法即可

### Tightly Encapsulated 緊密封裝
把物件內所有 Property 都設成 private，並只提供 public method 或 Get&Set 存取器來供外界操作變數


---


## 28.Inheritance 繼承 (上)

教學影片：[小山的 C# 教學-第28課-繼承性
](https://youtu.be/MdHXU139_fU?si=u-MYKoGU3KSEnDjH)

### Inheritance 繼承
物件可以透過繼承，獲得其他物件的屬性與行為

### 語法
#### 在 C# 之中，想要使用繼承
只需要在定義 class 時，於 class 名稱後面加上「:」(冒號) 與被繼承的 class 名稱即可

例如我想要讓 class A 繼承 class B，就要寫成
```
class A : B {
...
}
```
### 範例
```
namespace Demo
{
    class Monster : Creature
    {
        public int Attack()
        {
            return 10;
        }
        
        // ... More ...
    }
}
```


---



## 29. Inheritance 繼承(下)

教學影片：[小山的 C# 教學-第29課-繼承性(續)
](https://youtu.be/sRddjKhx9hk?si=dspZgbxpMoNbBRIc)

### Class 繼承
C# 之中，被繼承的 Class 被稱為「Base Class」(基底類別)，繼承的 Class 被稱為「Derived Class」(衍生類別)

### 好處
除了上一課提到，我們可以透過繼承把多個 Class 重複的程式碼寫在同一個 Class 以減少「Class 之間」的重複程式碼之外，我們也可以利用繼承減少「Class 內部」的重複程式碼

### 常見情況
如果我們想讓 Monster 可以攻擊不同的生物，像是村民或其他怪物，那可能需要為不同的生物撰寫不同版本的 Attack：
```
public void Attack(Villager villager) {
    ....
}

public void Attack(Monster monster) {
    ....
}
```
但是我們都知道 Villager 與 Monster 就繼承自 Creature，所以我們可以這樣寫：
```
public void Attack(Creature creature) {
    ....
}
```
這樣只要是 Creature 或是它的衍生類別，都可以被傳入 Attack 處理
這樣就可以大大減少 Class 內部的重複程式碼
## 30. Random 亂數

教學影片：[小山的 C# 教學-第30課-亂數 Random
](https://youtu.be/pXQa9LhwaxM?si=21ZSlWYIUmp4nOQY)

### 產生亂數
* 想要產生亂數的話，可以使用 C# 內建的 Random 物件
* 建立出一個 Random 物件之後，就等同於有了一個亂數產生器

### Random Class
Random Class 的主要功能就是產生亂數，主要的 method 就是 Next( )，Next( ) 有三種版本：

#### int Next( )
沒有參數的版本
產生的亂數介於 0 到整數最大值之間 (0~2147483647)
#### int Next(int maxValue)
參數為上限
產生的亂數介於 0 到 maxValue 之間 (不含 maxValue)
#### int Next(int minValue, int maxValue)
參數為下限與上限
產生的亂數介於 minValue 與 maxValue 之間 (含 minValue 但不含 maxValue)


---



## 31. Override 覆寫

教學影片：[小山的 C# 教學-第31課-Override 覆寫
](https://youtu.be/SH4bkCD3Ii4?si=vzqr_CJJdYyT7DFE)
### Override
Override 指的是「改寫、覆寫」，主要是用來讓繼承的 class 改寫掉從 base class 繼承到的行為。

### 使用方法
想要使用 Override，首先必須要先在繼承的 class 中定義一個名稱與參數皆相同的method，然後在原本的 method 前加上「virtual」關鍵字，而新的 method 前加上「override」關鍵字。

### 使用時機
基本上在撰寫物件導向的程式時，為了要讓許多物件有相同的動作，通常會寫一個 class 包含該動作，並讓其他 class 繼承它。就像是這次課程中介紹的 move 或 attack。可是偏偏會有一些狀況會需要讓某些物件的行為與預設的不同，而當你需要這種修改時，就會用到 override。

另外，Override 也常用於多型性中，主要是因為它可以讓許多具有相同 method 的物件具有不同行為，這部分會在之後的課程中提及。


---


## 32. Method Hiding

教學影片：[小山的 C# 教學-第32課-Override vs Method Hiding
](https://youtu.be/E2JszJ4czyo?si=Gm_wL-bBqdWHMdTI)

### Method Hiding
當繼承的類別之中有著與基底類別 (父類別) 名稱和參數相同的 method，但沒有加上 override 的字樣，就會觸發 method hiding (方法遮蔽) 的機制。

### Override vs. Method Hiding
 Method hiding (方法遮蔽) 指的是繼承的類別將原本基底類別的 method 隱藏起來了，但是與 override 不同，新的 method 會與舊的 method 共存，而且都可以被呼叫得到。

### 呼叫
如果想要呼叫到被隱藏起來的 method，就必須要用該 method 所屬的 class 變數來呼叫。舉例來說 class B 裡面的 say() 遮蔽了 class A 的 say()，如果想要呼叫到 class B 物件之中原本 A 版本的 say() 的話，就要用 A 型別的變數去存取 B 的物件。就像下面這段程式碼：

```
A a = new B(); // B 的物件，但用 A 的變數存取
a.say();
```
* 為了防止跟 override 混淆，想要使用方法遮蔽時可以在 method 前面加上「new」來加以區分。
```
public new string saySomething()
{
    return "something";
}
```
* 沒有override -> 根據object型別呼叫
![image](https://hackmd.io/_uploads/Byz4_9cvT.png)



---

## 33. Protected

教學影片：[小山的 C# 教學-第33課-Protected
](https://youtu.be/P7zOcuftpZw?si=-BffmTSrz-4Mi6_u)

### Protected 
protected 與 public 和 private 相同，都是用來進行權限控管的關鍵字，套用 protected 的資源不可以直接從外界存取 (類似 private)，但是可以從繼承的 class 之中存取

### 開放程度
pubilc > protected > private



---

## 34. Base 關鍵字

教學影片：[小山的 C# 教學-第34課-Base 關鍵字
](https://youtu.be/1eAGN-NPBXE?si=SHa3qFkx1xSApQO1)

### Base
透過 this 關鍵字可以直接存取所屬物件的屬性與方法，常用於 method 的參數名稱與屬性名稱重複的時候。base 關鍵字也是類似原理，只是 base 存取的對象是基底類別 (base class)

### 常用情況
* 當衍生類別中出現了名稱相同的屬性，若想存取基底類別中的屬性而非衍生類別的屬性，就可以使用 base 來存取
* 當衍生類別 override 了一個基底類別的 method，若想存取原版 (原本在基底類別內的版本) 的 method，就可以用 base
* 想要呼叫基底類別的建構子 (constructor) 時，可以在自己的建構子後加上 base 來呼叫


---

## 35. Abstract Class & Abstract Method

教學影片：[小山的 C# 教學-第35課-Abstract Class & Abstract Method
](https://youtu.be/i1Mnyu39ns4?si=gs-CRWy54HBeWJQC)

### Abstract Method
C# 中的 method 主要分成兩個部分，宣告與內容。Abstract method 則是一種只有宣告，而沒有實作內容的一種特殊 method。
* Abstract method 主要的目標是預先宣告 method，但是把實作的工作交給繼承的類別來做。
* 透過使用 abstract method，就可以讓衍生類別具有共同行為，但是實際的做法則由各個類別自訂。

### Abstract Class
4. Abstract method 必須放在 abstract class 中，abstract class 是一種不能實體化 (不能被 new) 的 class。原因就在於 abstract method 並沒有定義內容，因此若被實體化出來，就無法執行任何動作。



---


## 36. Constant 常數

教學影片：[小山的 C# 教學-第36課-Constant 常數
](https://youtu.be/8tNAQcBnlqM?si=npTSNFggvqigTX8n)


### Constant 常數
C# 中有兩種宣告常數的方式，分別是「const」與「readonly」，分別都是加在變數型別前面，通常表示不會被改變的值
* 「const」的常數不能同時是 static

### const vs. readonly
* 「readonly」不能在 method 中使用
* 若在自行撰寫的函式庫內使用到的話，要注意「const」的常數會在編譯時期將所有使用到的地方替換為實際的數值，「readonly」則是在實際執行期間才會去查找。

### 範例
```
public const double PI = 3.14;
public static readonly double PI = 3.14;
```

---

## 37. switch 與 enum

教學影片：[小山的 C# 教學-第37課-switch 與 enum
](https://youtu.be/NJMog_sfKCQ?si=gwPykdaChIj_zAOx)

### switch
switch 可以判斷某個變數的值為何，並根據值的內容來做出對應的反應。其語法如下
```
switch (變數) {
   case 第一種值:
      第一種狀況要做的事情
       break;
   case 第二種值:
      第二種狀況要做的事情
       break;

   // 很多 case

   default:
      若上面狀況都不符合的話，要做的事情
      break;
}
```
### 範例
```
public void Move(int direction)
{
    switch (direction)
    {
        case Direction.UP:
            Y += 1;
            break;
        case Direction.DOWN:
            Y -= 1;
            break;
        case Direction.LEFT:
            X -= 1;
            break;
        case Direction.RIGHT:
            X += 1;
            break;
        default:
            // Error
            break;
    }
}
```
### enum
enum 可以用來創造新的型別，並且可以被放入數個定義的數值。其語法如下：
```
euum 型別名稱 {
    第一個值, 第二個值, 第三個值
    // 可以放入很多個值
}
```
### 範例
```
enum Direction
{
    UP, DOWN, LEFT, RIGHT
}
```

---

## 38. Multidimensional Arrarys 多維陣列

教學影片：[小山的 C# 教學-第38課-Multidimensional Arrarys 多維陣列
](https://youtu.be/V6j_nZTfhkg?si=0EV-NSZGg_z9y6Ag)

### Multidimensional Arrarys 多維陣列
多維陣列中的元素需要超過一個以上的索引 (編號) 才能指出元素的位置。需要兩個索引的陣列稱為二維陣列，需要三個的稱為三維陣列，以此類推。

### 宣告
以下是一維、二維、三維陣列的宣告與建立方式，以整數陣列為例：
```
// 宣告並建立一個長度為 2 的一維陣列
int[] A = new int[2];
// 宣告並建立一個 2 x 3 的二維陣列
int[,] B = new int[2,3];
// 宣告並建立一個 2 x 3 x 4 的三維陣列
int[,,] C = new int[2,3,4];
```

### 使用
以下是一維、二維、三維陣列的使用方式，接續上一個例子：
```
// 將 A 中位置為 1 的值改成 10
A[1] = 10;
// 將 B 中位置為 (1, 0) 的值改成 42
B[1, 0] = 42;
// 將 C 中位置為 (0, 2, 1) 的值改成 25
C[0, 2, 1] = 25;
```


---

## 39. PictureBox

教學影片：[小山的 C# 教學-第39課-PictureBox
](https://youtu.be/elqJdoXNP_Q?si=31ugoEqmibdEUeob)

### PictureBox
PictureBox 是一種用來顯示圖片的視窗元件

### 修改
藉由修改 PictureBox 的屬性 Image，就可以更換 PictureBox 所展示的圖片
### 屬性
PictureBox 的 SizeMode 屬性控制了如何顯示圖片，例如 StretchImage 模式可以將圖片拉伸到跟 PictureBox 相同大小
### 載入
Properties.Resources 可以預先幫我們載入各種資源，圖片就是其中之一。一旦設定好後，就可以直接藉由程式碼呼叫到預先載入的資源。
* Properties -> Resources.resx 加入資源
* `catBox.Image = Properties.Resources.cat;`

---


## 40. 五子棋小遊戲(一) - 棋盤與棋子

教學影片：[小山的 C# 教學-第 40 課 - 五子棋小遊戲 (一) - 棋盤與棋子
](https://youtu.be/kL1KG-bitG4?si=6JjKNDJj0FWWl5Pj)

### 目標
* 寫出五子棋小遊戲
* 黑白輪流下子
* 棋子要放在交叉點上
* 滑鼠在交叉點上時顯示手的游標圖案
* 檢查玩家是否有連出五個子的直線
### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)
1. 下載[素材](https://github.com/slmt-tutorial-channel/c-sharp-class-materials/raw/master/class-31-40/class-40/gomoku.zip)
2. 開啟專案
3. 先執行一次確認專案建立成功
4. 把素材匯入專案
5. 修改視窗名稱
6. 將視窗背景修改為棋盤圖片，並調整大小
7. 建立一個 PictureBox 來顯示棋子
8. 先執行一次確認專案建立成功
9. 先執行一次確認專案建立成功


---


## 41. 五子棋小遊戲(二) - 動態建立棋子
教學影片：[小山的 C# 教學-第 41 課 - 五子棋小遊戲 (二) - 動態建立棋子
](https://youtu.be/_0ZC7TJUBCQ?si=0oFKUvxDyCoNIkeE)

### 目標
* 動態加入黑白棋
* 建立出一個 Piece class 來代表棋子
* 讓 Piece class 繼承 PictureBox 以獲得它的能力
* 黑棋跟白棋也要分別建立出 class 並繼承 Piece
### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)
1. 建立一個 Piece class
1. 讓 Piece class 繼承 PictureBox
1. 幫 Piece class 撰寫 constructor 並用 x, y 座標當作參數
1. 在 Piece 的 constructor 中設定背景色、位置(利用獲得的 x, y 座標) 與大小
1. 建立出 BlackPiece (黑棋) 與 WhitePiece (白棋) 的 class，並繼承 Piece
1. 幫 BlackPiece 和 WhitePiece 建立 constructor，同樣以 x, y 當作參數
1. 在 BlackPiece 和 WhitePiece 建立 constructor 中設定兩者的圖片
1. 嘗試在 Form 中用程式碼建立出黑白棋的物件
1. 將 Piece 設定為 abstract class 來避免被實體化


---

## 42. 五子棋小遊戲(三) - 用滑鼠建立棋子
教學影片：[小山的 C# 教學-第42課-五子棋小遊戲(三)-用滑鼠建立棋子
](https://youtu.be/2VzO76N74ao?si=gK0ig-7k7ZzdkT20)
### 目標
* 滑鼠點擊觸發建立棋子
* 視窗可以接受所謂的事件，也就是發生在這個視窗上的一些預先定義好的刺激
* 接受到事件之後，視窗可以對事件做出反應，預設的情況是甚麼都不做
* 此次利用 MouseDown 事件來接受滑鼠點按的刺激
* 棋子顯示的位置需要另外調整
### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)
1. 在 Visual Studio 的事件視窗中對 MouseDown 點兩下建立處理 MouseDown 事件的 method
1. 取出 MouseEventArgs 的參數 e 之中的 X, Y 來取得滑鼠點按的座標
1. 將滑鼠座標傳入並建立一個 BlackPiece
1. 建立一個名為 IMAGE_WIDTH 的常數，代表圖片的寬度
1. 將 Piece 中的 Size 改為用 IMAGE_WIDTH 表示
1. 將 Piece 中的 Location 改為 x - IMAGE_WIDTH 與 y - IMAGE_WIDTH

---

## 43. 五子棋小遊戲(四) - 判斷交差點的位置
教學影片：[小山的 C# 教學-第43課-五子棋小遊戲(四)-判斷交差點的位置
](https://youtu.be/apQrPURLYZU?si=DAR1-kktSw_Daq5B)
### 目標
* 判斷點按的位置是否為交叉點上或附近，並改變游標圖案提示使用者。
* 將棋盤的交叉點用二為座標表示。越往右，X 座標越高；越往下，Y 座標越高。
* 建議將預計完成的主要目標用註解寫進 method 裡面，再開始撰寫程式碼。
* 計算一個位置 X 靠近哪個點的方法如下 (Offset 代表棋盤到邊界的距離，Distance 代表相鄰兩點的距離，R 代表多靠近一個點會被判斷在「附近」)：
    1. 首先計算 (X - Offset) ÷ Distance 取得商數與餘數，商數代表左邊的點的編號，餘數代表與左邊的點的距離。
    2. 判斷餘數是否小於等於 R，是的話代表 X 靠近左邊的點，回傳商數。
    3. 判斷餘數是否大於等於 Distance - R，是的話代表靠近右邊的點，回傳商數+1。
### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)
1. 新增一個名為 Board 的 class 用來負責關於棋盤的操作，以下操作都在 Board 內進行。
1. 新增一個 public method，CanBePlaced(int x, int y)，回傳 bool。
1. 新增一個 private method，FindTheClosetNode(int x, int y)，回傳 Point。
1. 新增一個 private method，FindTheClosetNode(int pos)，回傳 int。
1. 新增三個常數，int OFFSET = 75, int NODE_RADIUS = 10, int NODE_DISTANCE = 75。
1. 在第 4 步驟新增的 method 中實作「製作重點」第 4 點中的演算法。
1. 新增一個常數 Point NO_SUCH_NODE = new Point(-1, -1)，代表沒有找到符合的交叉點。
1. 在第 3 步驟新增的 method 中分別計算最靠近 x, y 的交叉點。
1. 實作第 2 步驟新增的 method。
1. 利用剛剛寫好的 method 找到最近的交叉點
1. 沒有的話回傳 false，有的話回傳 true
1. 在 Form1 中新增一個事件 MouseMove 的 method。
1. 在 Form 1 新增一個 Board 物件。
1. 在第 10 步新增的 method 中，藉由呼叫 board.CanBePlaced(x, y) 來判斷是否可以放棋子。
1. 如果可以的話，將游標設為手。
1. 如果不行的話，將游標設為預設圖案。
1. 解決游標在邊界也會變成手的問題。
1. 在 FindTheClosetNode 增加一個判斷，檢查座標是否在 (Offset - R) 之外。如果是的話就直接回傳 -1。

---

## 44. 五子棋小遊戲(五) - 正確放置棋子
教學影片：[小山的 C# 教學-第44課-五子棋小遊戲(五)-正確放置棋子
](https://youtu.be/yzljXSB6Urw?si=P8V8GkuB-pxtGxp5)
### 目標
* 本課目標：讓棋子正確無誤地顯示在交叉點上
* 注意若直接用滑鼠點按的座標來建立棋子，則棋子可能會有點歪歪的
* 為了正確判斷是否同一個位置有放過棋子，棋盤必須要記錄之前放置的棋子
* 若程式碼出現重複的模式，那就代表可能有可以寫得更簡潔的地方

### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)

1. 新增一個 enum，並命名為 PieceType，裡面包含 BLACK 與 WHITE 兩種數值
1. 在 Board 內新增一個 public method，PlaceAPiece(int x, int y, PieceType type)，回傳 Piece
1. 將 CanBePlaced 的內容複製到 PlaceAPiece 裡面
1. 在 Board 內建立一個 9x9 的二維陣列 pieces
1. 修改 PlaceAPiece 的內容
1. 將 return false 改成 return null
1. 加入利用 pieces 來判斷是否在某個交叉點上已經有放置棋子了
1. 若已經被放棋子了，就回傳 null
1. 根據輸入的 PieceType 建立一顆對應顏色棋子
1. 把該棋子放在 pieces 中對應的位置
1. 回傳剛才新增的棋子
1. 在處理視窗滑鼠按下事件的 method 中 (影片中是「Form1_MouseDown」) 新增以下內容
1. 呼叫 board.PlaceAPiece(...) 並根據 isBlack 給予對應的 PieceType
1. 若回傳的棋子不是 null，就把棋子放進 this.Controls，並把 isBlack 的值反過來
1. 因為剛剛寫的 MouseDown 內有重複的模式，所以這邊稍微優化一下
1. 把 Form1 的 bool isBlack 改成 PieceType nextPieceType，預設是 PieceType.BLACK
1. 只留下 MouseDown 中上半部的程式碼
1. 改成把 nextPieceType 傳進 board.PlaceAPiece
1. 把倒反 isBlack 的程式碼改成倒反 nextPieceType
1. 在 Board 內加入一個 private method，convertToFormPosition(Point nodeId) 回傳 Point
1. 實作把 NodeId 轉換成視窗座標的功能
1. 把 convertToFormPosition 加入 PlaceAPiece 中，讓他建立棋子時使用的是交叉點的座標

---

## 45. 五子棋小遊戲(六) - 重構與最後準備
教學影片：[小山的 C# 教學-第45課-五子棋小遊戲(六)-重構與最後準備
](https://youtu.be/hZx9p9EgI5g?si=ygGj-DVOu7WXAzr2)

### 目標
* Board 內的邊界判斷 Bug 其實是因為沒有在 Board 內限定棋盤交叉點數目造成的
* 增加一個 class Game 來處理遊戲相關邏輯，使得程式碼更有結構性
* 讓 Board 能夠回答在某個給定座標點上放置的棋子是甚麼顏色

### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)
1. 解決邊界 Bug
    1. 在 Board 內新增一個常數 NODE_COUNT = 9
    1. 在 findTheClosetNode(int x, int y) 內，判斷 findTheClosetNode(int pos) 傳回的數字是不是介於 0 到 NODE_COUNT - 1 之間。若不是就回傳 NO_MATCH_NODE。
1. 新增一個遊戲管理 class Game
    1. 把 Form1 中 board 跟 nextPieceType 兩個變數移到 Game 裡面
    1. 在 Form1 內新增一個 Game 的變數 game
    1. 新增一個 public method，CanBePlaced(int x, int y)，內容就是呼叫 board.CanBePlaced(x, y)
    1. 新增一個 public method，PlaceAPiece(int x, int y)
        1. 把 Form1 內 MouseDown 的程式碼貼到這裡
        1. 把 e.x 與 e.y 改成 x 跟 y
        1. 把 Controls.Add 的程式碼刪除
        1. 讓此 method 把棋子往外 return
    1. (選擇性) 把 nextPieceType 都改成 currentPlayer
1. 修改 Form1 的程式碼
    1. 把原本呼叫 board 的地方都改成 game
    1. 把 MouseDown 內處理 nextPieceType 的程式碼刪除
1. 讓 Piece 回傳自己的 PieceType (顏色)
    1. 在 Piece 內新增一個 public abstract method，GetPieceType()，回傳 PieceType
    1. 在 BlackPiece 內實作 GetPieceType，回傳 PieceType.BLACK
    1. 在 WhitePiece 內實作 GetPieceType，回傳 PieceType.WHITE
1. 在 PieceType 內新增一個常數，NONE
1. 在 Board 內新增一個 public method，GetPieceType(int nodeIdX, int nodeIdY)，回傳 PieceType
    1. 檢查 pieces[nodeIdX, nodeIdY] 是否為 null，是的話就回傳 PieceType.NONE
    1. 不是的話回傳 pieces[nodeIdX, nodeIdY].GetPieceType()


---

## 46. 五子棋小遊戲(七) - 勝利判斷及重開一局
教學影片：[小山的 C# 教學-第46課-五子棋小遊戲(七)-簡單勝利判斷
](https://youtu.be/LSg15Q54TeI?si=GgC3F7FXfTTyrJ5f)

### 目標
* 檢查勝利的方式 - 檢查最後下的那顆棋子的八個方向的正反方向是否有五顆棋子連成一直線
* 判斷獲勝後，顯示獲勝者並禁止繼續下棋
* 新增重開一局功能
* 在測試程式時，若發生錯誤，可以把滑鼠移到變數上。此時就會顯示該變數的值為多少。
* 注意在 if 內有多個條件時，若程式發現只要檢查前面的條件就足夠，後面的條件就不會被執行。

### 五子棋小遊戲：[gomoku](https://github.com/tyjain/Demo/tree/bf6a3607e1e2bb0ed92a2947a0bc57a9c9703d97/gomoku)
1. 在 Board 內新增一個 private Point 變數，lastPlacedNote，一開始設為 NO_MATCH_NODE
    1. 新增一個 public get 存取器 LastPlacedNote，用來取得 lastPlacedNote
    1. 在 Board 內的 PlaceAPiece 把最後下子的位置存在 lastPlacedNote
1. 在 Game 內新增一個 private PieceType 變數 winner，一開始設為 PieceType.NONE
    1. 新增一個 public get 存取器 Winner，用來取得 winner
1. 在 Game.PlaceAPiece 內的交換選手前，加入 CheckWinner。代表在交換前會先檢查勝利者。
1. 實作 Game 的 CheckWinner() (先檢查一個方向)
    1. 先用兩個變數 centerX 跟 centerY 儲存 board.LastPlacedNote 的 X 跟 Y 座標
    1. 加入一個 while 迴圈檢查五顆座標連續的棋子是否顏色相同。檢查棋盤上某個位置的顏色可以用 board.GetPieceType(x, y)。
        1. 記得在呼叫 board.GetPieceType(x, y) 前，先檢查座標是否有超出棋盤邊界
        1. 若發現有一顆顏色不同就提早跳出 (break)
    1. 檢查是否看到五顆棋子，若沒看到代表沒有勝利者
1. 在 Form1_MouseDown 內檢查 game.Winner。
    1. 若為 PieceType.BLACK，就用 MessageBox 印出「黑色獲勝」。白色也用類似方式處理。
    2. 檢查是否有人獲勝，獲勝後禁止下棋
1. 在 Game.CheckWinner 內增加兩個 for 迴圈檢查八個方向，並檢查正反方向是否有總和五個的相同棋子
2. 新增重開一局按鈕產生新的Game物件，並重新配置介面


---

## 47. Polymorphism 多型性

教學影片：[小山的 C# 教學-第47課-多型性 (Polymorphism)
](https://youtu.be/8nHg_XzFyUs?si=-eCPLH4ORjv6BESf)
### Polymorphism 多型性
多型的概念指的是「利用統一的介面存取物件，提高使用物件彈性」

### 好處
多型的好處在於可以降低對介面的依賴程度，增加維護程式的彈性
* 不需要知道有哪些衍生類別
* 不需要處理每個衍生類別
* 可以隨意增加刪減衍生類別

### 繼承 vs. 多型
繼承主要在強調「減少重複的實作」，多型則在強調「透過統一的介面 (基底類別) 操作，降低對實作的依賴」

### 常見情況
```
// 使用基底類別method
Creature c = new Player("小山貓");
c.injured(10);
```

```
// 不需要overloading
class Monster
{
    public void attack(Creature c)
    {
        c.injured(10);
    }
}

Monster m = new Monster();
m.attack(p);
m.attack(v);
```


---

## 48. Interface 介面

教學影片：[小山的 C# 教學-第48課-介面 (Interface)
](https://youtu.be/ODrhZ1v63-s?si=0i9bvEE6SRdfF_qK)

### Interface 介面
* interface 的撰寫跟 class 類似，只是其中只能包含沒有實作的 method
* interface 具有類似契約的效果，規定實作的 class 必須要完成要求的 method
* class 雖然只能繼承一個 base class，但是可以實作多個 interface
* 實作 interface 的 method 時，不可以是 static，同時必須要是 public
* 命名 interface 習慣以大寫 I 開頭，方便跟繼承作區別

### 範例
```
interface IAttackable
{
    void attack(Creature target);
}

class Player : Creature, IAttackable
{
    public void attack(Creature target)
    {
        target.injured(30);
    }
}
```

![image](https://hackmd.io/_uploads/SyLpen5Dp.png)


---

## 49. List 串列

教學影片：[小山的 C# 教學 - 第 49 課 - 串列 (List)
](https://youtu.be/2Cm8KxEutjI?si=Rptv-_TftM2yny8g)

### List 串列
List<T> 是類似陣列 (Array) 的資料結構，但是長度可以隨存放的物件數量調整
List<T> 使用泛型 (Generics) 語法來指定存放物件的型別，必須在建立 List<T> 物件時把 T 換成要儲存的型別
    
### List vs. Array
#### 陣列不太好用，因為：
陣列長度是固定的，且要預先設定
陣列建立後沒用的空間就浪費掉了

### 本課介紹的 List<T> method：
* 加入物件 x ：list.Add(x)
* 取得 pos 位置的物件：list[pos]
* 刪除 pos 位置的物件：list.RemoveAt(pos)
* 取得現在有幾個物件：list.Count
* 刪除物件 x ：list.Remove(x)
* 檢查是否存在物件 x ：list.Contains(x)
* 排序裡面的物件：list.Sort()

### 範例
    
```
List<int> list = new List<int>();
list.Add(123);
list.Add(235);
list.Add(644);

list.Sort();
```
[MSDN - List <T> 類別](https://docs.microsoft.com/zh-tw/dotnet/api/system.collections.generic.list-1?view=netcore-3.1)
    

---    
    
## 50. Generics 泛型 的初步介紹

教學影片：[小山的 C# 教學 - 第 50 課 - 泛型 (Generics) 的初步介紹
](https://youtu.be/Lo6dorKB0tk?si=MEpEzNaBEBk-Nj7p)

### Generics 泛型
泛型可以想成是「暫時替代型別的 placeholder」，讓程式設計師可以暫時不用決定某些型別要放甚麼

### 限制型別
泛型限制了泛型符號的位置只能用同一個型別，而不能同時代表多個型別 (例如本課的 Building的 P 不能同時代表 Worker 及 Resident)
```
// 限制Building為同一類別
class Building<P>
{
    List<P> people = new List<p>();
        
    public void Add(P person)
    {
        people.Add(person);   
    }
}    

Building<Worker> b = new Building<Worker>();
b.Add(new Worker("小山貓"));
```
* 所有的 class 都有個共通的基底類別 (base class)，就是 Object，而每個 class 因為都繼承自 Object，因此都有 ToString 這個 method

>### 所有 class 共通的基底類別 Object
>C# 預設讓每一個 class 都會自動繼承 Object。 換句話說，C# 中所有類別都是 Object 這個 class 的衍生類別。 這是為了要確保每一個 C# 中的物件都有一些共通的 method。 像是 Equals(Object)、ToString()、GetHashCode() 等等。 這也是為什麼本課中，在一開始實作 Building 時只要宣告輸入 Object，就可以將 Worker 跟 Resident 餵進去。 同時也是為什麼必須要 override ToString()，因為 Object 本來就有個 ToString() method。
    
[MSDN - 介紹泛型 (Generics)](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/generics/)
    
[MSDN - Object 類別](https://docs.microsoft.com/zh-tw/dotnet/api/system.object?view=netcore-3.1)
    
---