using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 101; i++)
            {
                String str = "";

                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                 
                if (i % 5 == 0)
                { 
                    str += "Buzz";
                }
                
                if (i % 7 == 0)
                {
                     str += "Bang";
                }
                 
                if (str == "")
                {
                     str += i.ToString();
                }
                 // str = fizzbuzz

                 Console.WriteLine(str);
                 

            }
            
        }
    }
}


