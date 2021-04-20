using System;

namespace próbny
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = Int32.Parse(a);

            if (n <= 3)
            {
                Console.WriteLine("error");
                return;
            }
            if (n % 2 == 0)
            {
                n--;
            }
            for (int i = 0; i < ((n+1)/2); i++) //numer wiersza
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j || n-i<=j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

        }   
    }

}
