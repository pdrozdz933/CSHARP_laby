using System;

namespace trojkat_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            trojkat t;
            t = new trojkat();
            t.A = 3;
            t.B = 2;
            t.C = 1;
            Console.WriteLine(t);
        }
    }
}
