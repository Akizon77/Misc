//命名空间 Namespace

namespace Pro
{
    class Program //类
    {
        static void Main() //Main方法
        {
            int a;
            MyClass.Show();
            MyClass.Change(10);
            MyClass.Show();
        }
    }
    //封装了两个成员
     static class MyClass
    {
        //public(公共的) private(私有的) internal（内部的） 
        //Show() 是类的MyClass成员
        static public void Show()
        {
            Console.WriteLine(x);
        }
        static public void Change(int y)
        {
            x = y;
        }
        //int成员x
        private static int x = 5;

    }
}

