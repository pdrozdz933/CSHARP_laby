using System;

namespace wzorki
{
    class Program
    {
        private static string[] GetInput()
        {
            string input = Console.ReadLine();
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj typ figury oraz wymiary ");
            string[] inputSplit = GetInput();
            if (inputSplit[0] == "A" && inputSplit.Length == 3) //Prostokąt A
            {
                choiceA(inputSplit);
                Console.WriteLine("Figura A ^^");
            }
            
            else if (inputSplit[0] == "B" && inputSplit.Length == 2) //Litera z
            {
                choiceB(inputSplit);
                Console.WriteLine("Figura B ^^");
            }
            else
            {
                Console.WriteLine("Błędny wymiar");
            }
        }
        private static void choiceA(string[] inputSplit)
        {
            int n = Int32.Parse(inputSplit[1]);
            int m = Int32.Parse(inputSplit[2]);
            if (n % 2 == 0)
            {
                n++;
            }

            if (m % 2 == 0)
            {
                m++;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == m - 1 || j == n - 1 || i == (m - 1) / 2 || j == (n - 1) / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }

        }
        private static void choiceB(string[] inputSplit)
        {
            int n = int.Parse(inputSplit[1]);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }
        }
    }

}