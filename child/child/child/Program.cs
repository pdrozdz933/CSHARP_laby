using System;

namespace child
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
