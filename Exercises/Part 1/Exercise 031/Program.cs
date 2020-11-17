using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
            string nummerinput = Console.ReadLine();
            int nummer = Convert.ToInt32(nummerinput);
            if ((nummer % 2) == 0)
            {
            Console.WriteLine("It is even.");
            }
            else
            {
            Console.WriteLine("It is odd.");
            }
    }
  }
}
