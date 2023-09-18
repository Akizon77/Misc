// 基础类型
// int float double bool char string void class

// 声明变量 
// 语法 ： 类型 名称标识;
// 名称不能和基础类型（关键字）一样


// 基础语法
// 代码结束用;  英文分号！
// Eg : Console.WriteLine();
// 代码块不需要;
// 代码块 => {}
// Eg 
// if( ) { Console.WriteLine(); }

/*
int x;
// 赋值运算 可以多次赋值 但值只能是最后一次的
x = 3;
Console.WriteLine(x);
// 四则运算
x = 5 + 6;
Console.WriteLine(x);

// 所有运算都会给出一个结果（返回值）
// 重要！ 赋值也会给一个结果，结果就是被赋值的那个
Console.WriteLine(17);
Console.WriteLine(x = 5 + 7);
Console.WriteLine(x);

*/

// 可以一次声明多个变量 用逗号隔开
//int x, y, z;
//可以在声明的同时赋值
//int a = 6;
/*
//var 自动推测类型
var a = 6;
var b = "abcdefg";
var c = 'c';
*/

// 难点 函数
//Console.WriteLine();
//Console 是类 绿色
//WriteLine 是方法（Function） 也叫函数 黄色
//()是参数列表
//; 结束
// int 也是类  C# 所有的都是类 类属于对象(object)



//int inputInt = int.Parse(Console.ReadLine());
//Console.WriteLine(inputInt * 100);

//string myString = Console.ReadLine();
//Console.WriteLine(myString.ToUpper());



// 命名规则（非必要，但是能极大提升可读性）
// 变量名称尽量使用英文
// 使用驼峰命名法 ： 第一个单纯的第一个字母小写，其他的大写
// Eg: my int  => myInt
// 变量之外的东西命名使用首字母大写
// Eg my string => MyString
// 必须要用中文时，在前面添加下划线 _
// Eg _我的变量
// 起名的艺术
/*
// 不能声明 void 类型变量

Console.WriteLine("输入一个数字：");
double rad = double.Parse(Console.ReadLine());
double result = rad * rad * 3.1415926;

// 格式化字符串 
// 在字符串开始输入$ 是 $"  不是 "$
// 变量用{}框起来
Console.WriteLine($"半径为{rad:.00}的圆的面积是{result:.00}");
*/



// if 语句
// 语法 if (条件) { 代码块 }
// 条件是一个结果为bool类型的表达式，也可以直接是bool
// Eg: if (true) { ... }
// if ( 5 >= 8) { ... }
// 注意 一定有 { ... }
bool myBool = false;
if (myBool)
{
    Console.WriteLine("A");
}

if (true)
{
    Console.WriteLine("B");
}

int num1 = 6, num2 = 7;
if (num1 > num2)
{
    Console.WriteLine("C");
}
// 如你所见 有 大于 (>) 小于 (<) 
// 那么当然也有 等于(==) 大于等于(>=) 不等于(!=)
// 特别注意等于与赋值的区别 一个是 == 一个是 = 
// == 给一个bool的结果 ，= 给赋值的结果

// if 还能跟else，组成 if else 语句
// 如果if判断为true 那么不会执行else里的代码
// 如果if判断为false 那么执行else里的代码
if (true)
{
    Console.WriteLine("IF ELSE TRUE");
}
else
{
    Console.WriteLine("IF ELSE FALSE");
}


int num3 = 6, num4 = 10;
if (num3 == num4)//注意 ==
{
    Console.WriteLine("EQUAL");
}
else
{
    Console.WriteLine("NOT EQUAL");
}

/* 题目：有一个函数 
 *   { x (x>1)
 * y={ 2x-1 (x<=10)
 *   { 3x+11 (x>10)
 * 输入x，将y的值输出
 */



// 此外 如果你有多个判断，可以使用嵌套
// 就是if里面套if
bool useWIFI = true;
bool isAdmin = true;
bool inWhiteList = true;

if (useWIFI)
{
    if (isAdmin)
    {
        if (inWhiteList)
        {
            Console.WriteLine("登录成功");
        }
        else
        {
            Console.WriteLine("你不在白名单");
        }
    }
    else
    {
        Console.WriteLine("非管理员账户");
    }
}
else
{
    Console.WriteLine("请使用WIFI");
}
// 但是不建议这么做 ... 因为嵌套多了眼睛会花
// VS会帮你自动对齐{}，
// 但是其他的IDE可能不会，那个时候就有你好受的了

// 接下来就轮到 条件表达式了
// && 和 || 和 !
// && 代表 和 需要两个都是true，结果才是true
// 例如 ture&&false 结果是false
// || 表示 或，只要其中一个是true，整个的结果就是true
// 例如 true || false 结果是 true
// !表示非 反转
// 例如 !true 结果是 false
if (isAdmin && inWhiteList && useWIFI)
{
    Console.WriteLine("登录成功");
}
// 如果if的方法体只有一句话，那么可以省略{}
// 重要 只有一句话的情况下才能省略！！！！
if (isAdmin && inWhiteList && useWIFI)
    Console.WriteLine("登录成功");


/* 题目：
 * 将上题改成嵌套的
 */

/* for 循环
 * 语法 for (起始代码;条件;每次循环结尾运行的代码) { ... }
 * Eg:
 */
for (int i = 0; i <= 10; i = i + 1)
{
    Console.WriteLine(i);
}
// 小知识点 i = i + 1 可以缩写成i++;
// 类似的 还有i++;
// 控制for循环可以使用 continue 和 break 
// continue 表示进入下一次循环
// break 表示跳出循环 直接结束循环
for (int i = 0; i < 20; i++)
{
    if (i == 15)
        continue;
    Console.WriteLine(i);
}
/* 题目：列出1000以内的所有质数
 *      质数：只能被1和它本身整除的数
 * 提示：取余数的运算符是%
 * Eg: 5 % 3 的结果是 2
 */
bool flag = true;
for (int i = 1; i <= 1000; i++)
{
    for (int n = 2; n < i; n++)
    {
        if (i % n == 0)
        {
            flag = false;
            break;//break 可以加也可以不加 
        }
    }
    if (flag)
        Console.WriteLine(i);
    flag = true;
}



bool isSingle(int n)
{
    for (int i = 2; i < n; i++)
        if (n % i == 0) 
            return false;
    return true;
}


