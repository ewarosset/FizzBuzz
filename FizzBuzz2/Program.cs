using System;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 201; i++)
            {
                String str = "";
                
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                
                if (i % 13 == 0)
                {
                    str += "Fezz";
                }
                 
                if (i % 5 == 0)
                { 
                    str += "Buzz";
                }
                
                if (i % 7 == 0)
                {
                     str += "Bang";
                }
                
                if (i % 11 == 0 && i % 13 == 0)
                {
                    str += "Bong";
                }

                if (i % 11 == 0 && i % 13 != 0)
                {
                    str = "";
                    str += "Bong";
                }
                 
                if (str == "")
                {
                     str += i.ToString();
                }
                
                
                Console.WriteLine(str);
                 

            }
            
        }
    }
}


