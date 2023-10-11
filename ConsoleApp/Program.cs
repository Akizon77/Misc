namespace P
{
    class P
    {
        static unsafe void Main()
        {
            int a = 'a';
            int* p = &a;
            while (true)
            {
                Console.Write(*p);
                p++;
            }
        }
    }
}
