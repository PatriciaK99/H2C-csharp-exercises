using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            Console.WriteLine("Give the second number!");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);
            Console.WriteLine("Give the third number!");
            string input3 = Console.ReadLine();
            int num3 = Convert.ToInt32(input3);
            double svar = (num1 + num2 + num3) / 3.0;
            Console.WriteLine("The average is " + svar);

    }
  }
}
