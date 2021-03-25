using System;

namespace laby3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj liczby");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a==b)
            {
                Console.WriteLine("nie ma");
            }
            else
    {
                    for(int i = 0; a<=b; a++)
                    {
                        Console.WriteLine($"{a}, ");
                    }
    }
            

        }

    }
    
}
