using System;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = n;
            if (x % 2 == 0)
            {
                x--;
                for (int i = 0; i < x / 2 + 0.5f; i++)
                {
                    for (int j = 0; j < (x - 1 * i); j++)
                    {
                        Console.Write("*");
                    }
                    if (i < x - 1)
                    {
                        Console.WriteLine();
                    }
                }

            }
            else
            {
                for (int i = 0; i < x / 2 + 0.5f; i++)
                {

                    for (int j = 0; j < (x - 1 * i); j++)
                    {
                        Console.Write("*");
                    }
                    if (i < x - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}
