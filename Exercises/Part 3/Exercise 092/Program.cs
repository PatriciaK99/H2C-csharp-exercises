using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
            int highest = 0;
            int longest = 0;
            string longestname = "";

            while (true)
            {
                string input = Console.ReadLine();
                if (input != "")
                {
                    string [] nameandage = input.Split(',');
                    int year = Convert.ToInt32(nameandage[1]);
                    int namesize = nameandage[0].Length;
                    int age = 2020 - (year);

                    if (age > highest) highest = age;

                    if (namesize > longest)
                    {
                        longest = namesize;
                        longestname = nameandage[0];
                    }

                
                }

                else
                {
                    Console.WriteLine("Longest name: " + longestname);
                    Console.WriteLine("Highest age: " + highest);
                
                }
            
            }

    }
  }
}



