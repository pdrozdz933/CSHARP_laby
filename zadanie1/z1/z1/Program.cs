using System;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    if (i != j)
                    {
                        n--;
                    }
                }
            }
            Console.Write(n);
        }
    }
}
