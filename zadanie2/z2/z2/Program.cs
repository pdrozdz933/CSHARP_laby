using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValues = Console.ReadLine();
            short[] valuesArray = Array.ConvertAll<string, short>(inputValues.Split(" "), short.Parse);

            short a = valuesArray[0];
            short b = valuesArray[1];

            if(a-b>10)
            {
                Console.Write($"{b + 1}, {b + 2}, {b + 3}, ..., {a - 2}, {a - 1}");
                while (b == a - 2) ;
                return;
            }
            else if(b-a>10)
            {
                Console.Write($"{a + 1}, {a + 2}, {a + 3}, ..., {b - 2}, {b - 1}");
                while (a == b - 2) ;
                return;
            }
            else if(a<b)
            {
                for(int i =a+1; i+1<=b; i++)
                {
                    if (i + 1 == b)
                    {
                        Console.Write("{0}", i);
                        break;
                    }
                    Console.Write("{0}, ", i);
                }
                
            }
            else if(a>b)
            {
                for(int i=b+1; a>=i+1; i++)
                {
                    if(i+1==a)
                    {
                        Console.Write("{0}", i);
                        break;
                    }
                Console.Write("{0}, ", i);
                }
                
            }
            else if(a==b)
            {
                Console.WriteLine("Brak wyników");
            }
        }
    }
}
