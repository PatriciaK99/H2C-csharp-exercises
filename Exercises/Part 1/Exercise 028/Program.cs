using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
            string nummerinput = Console.ReadLine();
            int nummer = Convert.ToInt32(nummerinput);
            if (nummer >=18)
            {
            Console.WriteLine("You're an adult!");
            }
            else
            {
            Console.WriteLine("You're under age!");
            }

    }
  }
}
