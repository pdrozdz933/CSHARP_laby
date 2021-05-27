using System;
using System.Collections.Generic;

namespace listy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();

            animals.Add("kot");
            animals.Add("pies");
            animals.Add("krowa");
            animals.Add("lew");
            animals.Add("tygrys");
            animals.Add("mucha");
            
            foreach( var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

           if(animals.Contains("krowa"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine(animals.IndexOf("mucha"));

            animals.Reverse();
            Console.WriteLine(animals);


            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }


            animals.Sort();
            Console.WriteLine();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }






        }
    }
}
