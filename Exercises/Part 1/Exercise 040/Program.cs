using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
      int count = 0;
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
            else
            {
            count = count+1;
            sum = sum + number;
            }
           
    }
      Console.WriteLine("Total sum of numbers: " + sum);
      Console.WriteLine("Total amount of numbers: " + count);

    }
  }
}
