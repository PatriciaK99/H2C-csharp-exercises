using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
            string nummerinput1 = Console.ReadLine();
            int nummer1 = Convert.ToInt32(nummerinput1);
            Console.WriteLine("Give the second number!");
            string nummerinput2 = Console.ReadLine();
            int nummer2 = Convert.ToInt32(nummerinput2);
            if (nummer1 > nummer2)
            {
            Console.WriteLine("The larger number is " + nummer1);
            }
            else if (nummer1 < nummer2)
            {
            Console.WriteLine("The larger number is " + nummer2);
            }
            else if (nummer1 == nummer2)
            {
            Console.WriteLine("They are equal!");
            }

    }
  }
}
