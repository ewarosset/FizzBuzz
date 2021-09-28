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
           
           Console.WriteLine("Implement Fizz? Y/N");
           string fizz = Console.ReadLine();
           
           Console.WriteLine("Implement Buzz? Y/N");
           string buzz = Console.ReadLine();
           
           Console.WriteLine("Implement Fezz? Y/N");
           string fezz = Console.ReadLine(); 
            
            
            // var fizzBuzzer = new FizzBuzzer();
            //
            // foreach (var value in fizzBuzzer)
            // {
            //     Console.WriteLine(value);
            // }
            
            for (int i = 1; i <= loops; i++)
            {
                String str = "";
                List<string> names = new List<string>();
            
                
                // TODO - Combine these two ifs, check if list is empty and remove strings
                if ((fizz == "Y") && (i % 3 == 0))
                    {
                        names.Add("Fizz");
                    }

                if ((fezz == "Y") && (i % 13 == 0))
                    {
                        names.Add("Fezz");
                    }


                if ((buzz == "Y") && (i % 5 == 0))
                    {
                        names.Add("Buzz");
                    } 
                
                
                if (i % 7 == 0)
                {
                    names.Add("Bang");
                }
                
                if (i % 11 == 0 && i % 13 == 0)
                {
                    names.Add("Bong");
                }
            
                if (i % 11 == 0 && i % 13 != 0)
                {
                    names.Clear();
                    names.Add("Bong");
                }
                 
                if (names.Count == 0)
                {
                     str += i.ToString();
                     names.Add(str);
                }
            
                if (i % 17 == 0)
                {
                    names.Reverse();
                }
            
                string originalStr = string.Join("", names);
                Console.WriteLine(originalStr);
            }

        }
    }
}


