using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
            int mostAge = 0;
           
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
                    
                    }
                
                }
                else
                {
                    Console.WriteLine("Age of the oldest: " + mostAge);
                    break;
                
                }
            }


    }
  }
}



