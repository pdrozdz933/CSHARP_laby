using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            string a = Console.ReadLine();
            int n = Int32.Parse(a);
            int x = n;
            if (x % 2 == 0)
            {
                x--;
                for (int i = 0; i < x / 2 + 1; i++)
                {
                    for (int j = 0; j < (x - 2 * i); j++)
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
                for (int i = 0; i < x / 2 + 1; i++)
                {

                    for (int j = 0; j < (x - 2 * i); j++)
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
