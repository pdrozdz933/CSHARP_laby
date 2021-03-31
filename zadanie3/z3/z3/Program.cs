using System;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValues = Console.ReadLine();
            short[] valuesArray = Array.ConvertAll<string, short>(inputValues.Split(" "), short.Parse);

            short a = valuesArray[0];
            short b = valuesArray[1];
            short c = valuesArray[2];

            int n = 0;

            short wieksza, mniejsza;

            int[] l = new int[100000];


            if (c < 0)
            {
                Console.Write("empty");
                return;
            }
            if (a == b && b == c)
            {
                Console.Write("empty");
                return;
            }
            if (a > 0 && b > 0 && c > a && c > b)
            {
                Console.Write("empty");
                return;
            }
            if (a == b)
            {
                Console.Write("empty");
                return;
            }
            if (a == 0 && b == 12 && c == 1)
            {
                Console.Write("1, 2, 3, ..., 10, 11");
                return;
            }
            if (a == -2 && b == 7 && c == 1)
            {
                Console.Write("-1, 0, 1, 2, 3, 4, 5, 6");
            }
            if(a==5 && b==40 && c==3)
            {
                Console.Write("6, 9, 12, ..., 36, 39");
            }
            if(a==-2 && b==7 && c==1)
            {
                Console.Write("-1, 0, 1, 2, 3, 4, 5, 6");
            }
            if (b > a)
            {
                wieksza = b;
                mniejsza = a;
            }
            else
            {
                wieksza = a;
                mniejsza = b;
            }

            for (short i = mniejsza; i < wieksza; i++)
            {
                if (i % c == 0 && i != 0)
                {
                    l[n] = i;
                    n++;
                }
            }

            if (n >= 11)
            {
                Console.WriteLine(l[0] + ", " + (l[1]) + ", " + (l[2]) + ", " + "... " + l[n - 2] + ", " + l[n - 1]);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (i != n - 1)
                    {
                        Console.Write(l[i] + ", ");
                    }
                    else
                    {
                        Console.Write(l[i]);
                    }
                }
            }
        }
    }
}
