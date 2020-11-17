using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
    while (true)
    {
         Console.WriteLine("Give a number:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number == 0)
            {
            break;
            }
            if (number >=1)
            {
            sum = sum+1;  
            }
    }
         Console.WriteLine("Total amount of numbers: " + sum);


    }
  }
}
