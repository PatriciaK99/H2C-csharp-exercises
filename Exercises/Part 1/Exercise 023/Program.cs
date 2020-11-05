using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToInt32(input1);
            Console.WriteLine("Give the second number!");
            string input2 = Console.ReadLine();
            double num2 = Convert.ToInt32(input2);
            double svar1 = num1 + num2;
            double svar2 = num1 - num2;
            double svar3 = num1 * num2;
            double svar4 = num1 / num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + svar1);
            Console.WriteLine(num1 + " - " + num2 + " = " + svar2);
            Console.WriteLine(num1 + " * " + num2 + " = " + svar3);
            Console.WriteLine(num1 + " / " + num2 + " = " + svar4);


    }
  }
}
