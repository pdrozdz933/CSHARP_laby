using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace smpseq7
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string s = Console.ReadLine();
            int a = int.Parse(n);
            string[] SSplit = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] d = Array.ConvertAll<string, int>(SSplit, int.Parse);
            int b = 0;
            int z = 0; 
            for (int i = 0; i < a - 1; i++)
            {
                if (d[i] > d[i + 1])
                {
                    b++;
                }
                else if (b == 0)
                {
                    break;
                }
                else
                {
                    b++;
                    z++;
                    break;
                }
            }
            for (int k = 0 + b; k < a - 1; k++)
            {
                if (d[k] < d[k + 1])
                {
                    b++;
                }
                else
                {
                    b++;
                    break;
                }
            }
            if (b == a - 1 && z == 1)
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        }
    }
}