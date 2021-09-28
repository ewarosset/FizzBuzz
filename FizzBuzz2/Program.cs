using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i); 
                }     
                
            }
            
        }
    }
}


