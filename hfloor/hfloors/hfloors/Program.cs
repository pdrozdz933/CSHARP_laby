
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace hfloors
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int b = 0; b < a; b++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int m = int.Parse(input[0]);
                int n = int.Parse(input[1]);
                char[][] r = new char[m][];
                for (int i = 0; i < m; i++)
                {
                    r[i] = new char[n];
                    r[i] = Console.ReadLine().ToCharArray();
                }
                int guest = 0;
                int room = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (r[i][j] == '-' || r[i][j] == '*')
                        {
                            room += 1;
                            Test(r, i, j, ref guest);
                        }
                    }
                }
                Console.WriteLine((1f * guest / room).ToString("F"));
            }
        }
        static void Test(char[][] q, int b, int c, ref int g)
        {
            if (q[b][c] == 'v' || q[b][c] == '#') return;
            if (q[b][c] == '*') g += 1;
            q[b][c] = 'v';
            Test(q, b + 1, c, ref g);
            Test(q, b - 1, c, ref g);
            Test(q, b, c + 1, ref g);
            Test(q, b, c - 1, ref g);
        }
    }
    
}
