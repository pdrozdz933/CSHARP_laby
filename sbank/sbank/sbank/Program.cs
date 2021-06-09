using System;
using System.Collections.Generic;
using System.Text;

namespace bank
{
    public static class SBANK
    {
        public static void bank(int count, StringBuilder output)
        {
            string[] accountc = new string[count];
            string[] accountp = new string[count];
            for (int a = 0; a < count; a++)
            {
                accountc[a] = Console.ReadLine();
            }
            Console.ReadLine();

            for (int n = 30; n >= 0; n--)
            {
                if (n == 26 || n == 21 || n == 16 || n == 11 || n == 2)
                {
                   continue;
                }
                     
                int[] counting = new int['9' + 2];

                
                for (int a = 0; a < count; a++)
                {
                    ++counting[accountc[a][n] + 1];
                }

                
                for (int c = '0'; c <= '9'; c++)
                {
                    counting[c + 1] += counting[c];
                }

                
                for (int a = 0; a < count; a++)
                {
                    accountp[counting[accountc[a][n]]++] = accountc[a];
                }

                
                var t = accountp;
                accountp = accountc;
                accountc = t;
            }

            
            string account = accountc[0];
            int o = 1;
            for (int a = 1; a < count; a++)
            {
                if (accountc[a] == account)
                {
                    o++;
                }
                else 
                {
                    output.AppendLine($"{account} {o}");

                    account = accountc[a];
                    o = 1;
                }
            }
            output.AppendLine($"{account} {o}");
            output.AppendLine();
        }
    }


    public static class Program
    {
        private static void Main()
        {
            var output = new StringBuilder();
            int test = int.Parse(Console.ReadLine());
            while (test --> 0)
            {
                SBANK.bank(
                    count: int.Parse(Console.ReadLine()),
                    output: output);
            }

            Console.Write(output);
        }
    }
}