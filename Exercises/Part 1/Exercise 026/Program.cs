using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your age:");
            string nummerinput = Console.ReadLine();
            int nummer = Convert.ToInt32(nummerinput);
            if (nummer <1900)
            {
            Console.WriteLine("You're old");
            }

    }
  }
}
