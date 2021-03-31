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

            if(a==b)
            {
                Console.WriteLine("Brak wyników");
            }
            if(a<b)
            {
                for(int i =a-b; a+1<b-1; a++)
                {
                    Console.Write("{0}, ", a + 1);
                }
                Console.Write(a + 1);
            }
            if(a>b)
            {
                for(int i=b-a; a-1>b+1; b++)
                {
                    Console.Write("{0}, " b + 1);
                }
                Console.Write(b + 1);
            }
        }
    }
}
