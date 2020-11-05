using System;

namespace exercise_20
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
            int svar = intvärde1 * intvärde2;
            Console.WriteLine(insättning1 + " * " + insättning2 + " = " + svar);

    }
  }
}
