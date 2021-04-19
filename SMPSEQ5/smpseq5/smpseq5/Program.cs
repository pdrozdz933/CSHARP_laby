using System;

namespace smpseq5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string[] sSplit = b.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] qSplit = d.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int x = 0; x < sSplit.Length; x++)
            {
                if (x < qSplit.Length && sSplit[x] == qSplit[x])
                {
                    Console.Write($" {x + 1}" + " ");
                }

            }
        }
    }
}
