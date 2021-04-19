using System;

namespace smpseq3
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
                bool found = false;
                for (int y = 0; y < qSplit.Length; y++)
                {
                    if (sSplit[x] == qSplit[y])
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.Write(sSplit[x] + " ");
                }
            }
        }

    }
}
