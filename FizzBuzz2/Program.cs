using System;
using System.Collections.Generic;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int loops = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= loops; i++)
            {
                String str = "";
                List<string> names = new List<string>();

                if (i % 3 == 0)
                {
                    str = "Fizz";
                    names.Add(str);
                }
                
                if (i % 13 == 0)
                {
                    str = "Fezz";
                    names.Add(str);
                }
                 
                if (i % 5 == 0)
                { 
                    str = "Buzz";
                    names.Add(str);
                }
                
                if (i % 7 == 0)
                {
                     str = "Bang";
                     names.Add(str);
                }
                
                if (i % 11 == 0 && i % 13 == 0)
                {
                    str = "Bong";
                    names.Add(str);
                }

                if (i % 11 == 0 && i % 13 != 0)
                {
                    str = "";
                    str += "Bong";
                    names.Clear();
                    names.Add(str);
                }
                 
                if (str == "")
                {
                     str += i.ToString();
                     names.Add(str);
                }

                if (i % 17 == 0)
                {
                    names.Reverse();
                    string reversedStr = string.Join("", names);
                    Console.WriteLine(reversedStr);

                }

                else
                {
                    string originalStr = string.Join("", names);
                    Console.WriteLine(originalStr);
                
                }

            }

        }
    }
}


