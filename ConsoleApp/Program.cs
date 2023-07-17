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
            var myClass1 = new MyClass2();
            var myClass2 = new MyClass2();
            var myClass3 = new MyClass2();
            myClass2.Show();
            //new 关键字：新建一个

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
    class MyClass2
    {
        //public(公共的) private(私有的) internal（内部的） 
        //Show() 是类的MyClass成员
         public void Show()
        {
            Console.WriteLine(x);
        }
         public void Change(int y)
        {
            x = y;
        }
        //int成员x
        private  int x = 5;

    }
}

