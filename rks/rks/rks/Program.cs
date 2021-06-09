using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace rks
{
    public static class rks
    {
        static void Main()
        {
            string se = Console.ReadLine();

            string sn = Console.ReadLine();

            int[] a = Array.ConvertAll<string, int>(se.Split(" "), int.Parse);

            int[] n = Array.ConvertAll<string, int>(sn.Split(" "), int.Parse);

            int Length = a[0];
            int Max = a[1];

            ArrayList output = new ArrayList();
            var d = new Dictionary<int, int>();

            for (int i = 0; i < Length; i++)
            {
                if (d.ContainsKey(n[i]) == false)
                {
                    d.Add(n[i], 1);
                }
                else
                {
                    int temp = d[n[i]];
                    d[n[i]] = temp + 1;
                }
            }
            var sd = from wartosc in d orderby wartosc.Value descending select wartosc;
            Dictionary<int, int>.ValueCollection values = d.Values;
            Dictionary<int, int>.KeyCollection keys = d.Keys;

            foreach (var element in sd)
            {
                int w = element.Key;
                int value = element.Value;
                for (int i = 0; i < value; i++)
                {
                    output.Add(w);
                    output.Add(" ");
                }
            }
            output.RemoveAt((output.Count) - 1);
            for (int i = 0; i < (Length * 2) - 1; i++)
            {
                Console.Write(output[i]);
            }
        }
    }
}
