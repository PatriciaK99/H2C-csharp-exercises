using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give the first number!");
            string insättning1 = Console.ReadLine();
            int intvärde1 = Convert.ToInt32(insättning1);
            Console.WriteLine("Give the second number!");
            string insättning2 = Console.ReadLine();
            int intvärde2 = Convert.ToInt32(insättning2);
            Console.WriteLine("Give the third number!");
            string insättning3 = Console.ReadLine();
            int intvärde3 = Convert.ToInt32(insättning3);
            int svar = intvärde1 + intvärde2 + intvärde3;
            Console.WriteLine("The sum is " + svar);

    }
  }
}
