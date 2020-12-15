using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
            int mostAge = 0;
            string nameOfoldest = "";
            while (true)
            {
            
                string input = Console.ReadLine();
                if (input != "")
                {
                    string[] nameAndage = input.Split(',');

                    int age = Convert.ToInt32(nameAndage[1]);
                    if (mostAge < age)
                    {
                        mostAge = age;
                        nameOfoldest = nameAndage[0];
                    
                    }
                
                }
                else
                {
                    Console.WriteLine("Name of the oldest: " + nameOfoldest);
                    break;
                
                }
            }
    }
  }
}



