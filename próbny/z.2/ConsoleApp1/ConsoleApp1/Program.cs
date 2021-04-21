using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static double TriangleArea(int a, int b, int c, int precision = 2)
        {

    

            

           
                   if(a>0 || b>0 || c>0 || precision<2 || precision >8)
                   {
                        Console.WriteLine("Wrong arguments");
                        throw new ArgumentOutOfRangeException();
                            
                   }
                   
           
                   if(a+b<c || a+c<b || b+c<a)
                   {
                     Console.WriteLine("object not exists");
                     throw new ArgumentException();
                   }
                            
                
                    double p = ((a + b + c) / 2);
                    double pole = (double)(p*((p-a)*(p-b)*(p-c)));
                    return Math.Round(pole, precision);

            
            
                
                
            
            
      
               
            
           
        }
    }
}
