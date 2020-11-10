using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
            string nummerinput = Console.ReadLine();
            int nummer = Convert.ToInt32(nummerinput);
            if (nummer >0)
            {
            Console.WriteLine("It is positive");
            }
            else
            {
            Console.WriteLine("It is not positive");
            }

    }
  }
}
