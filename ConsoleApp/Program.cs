//命名空间 Namespace
using System.Runtime.InteropServices;

namespace Pro
{
    class Program //类
    {
        static void Main() //Main方法
        {
            //static 修饰符 不管他
            //Main 函数名称   开始运行的时候 ， 自己搜索Main去运行
            //string[] args 函数的参数
            //int 函数返回类型
            #region if表达式
            if (false)
            {
                bool b;
                b = true;

                if (b)
                {
                    Console.WriteLine("这里是IF");
                }
                else if (b)
                {
                    Console.WriteLine(" 这里是Else if");
                }
                else
                {
                    Console.WriteLine("这是ELSE");
                }
                //if 表达式 后面跟() 括号里是一个结果为bool类型的式子 判断条件
                //{ }花括号里面是if的
                //else ：最后的，如果if和else if 都无法
            }

            #endregion

            #region for表达式
            //Console.WriteLine(1 < 2);

            //for (int i = 0; i < 16; i += 2)
            //{
            //    Console.WriteLine(i);
            //    //暂停程序1000毫秒
            //    Thread.Sleep(1000);
            //    //for 表达式
            //    //后面跟括号
            //    //括号里有三个式子，分别是int i =0 、 i< 4 、 i++
            //    //第一个是 开始代码 就在在FOR运行之前执行的代码
            //    //第二个是 条件 i<4是一个式子，结果是true 或者false  和if一样
            //    //第三个 是 每次循环之后执行的代码
            //}
            //Console.WriteLine("END");
            #endregion
            int[] ints = {1,2,3};
            ints[2] = 5;
            //面向对象编程的高级封装
            List<int> list = new();
            //LIST 高级版数组
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine(list[4]);


            //List 自己有一个数组
            //int[5]
            //Add() 
            //超过了int[5]
            //重新创建一个int[10]，并且把int[5] 复制到int[10]
            


        }
        #region 函数返回类型
        //void 不返回 
        //int 返回int
        //string 返回 string
        //......
        string MyFunc()
        {
            return "";
        }
        #endregion


    }
    class MyList
    {
        int[] ints;
        void Add(int x)
        {
            ints[0] = x;
        }

    }

}