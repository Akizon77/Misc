//命名空间 Namespace

namespace Pro
{
    class Program //类
    {
        private static int _a = 0;
        public static int a
        {
            get { _a++; return _a; }
            set { _a = value; }
        }
        static void Main()
        {

            if (a == 1 && a == 2 && a == 3)
            {
                Console.WriteLine(true);
            }

        }


    }


}

