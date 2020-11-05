using System;

namespace exercise_21
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
            double svar = (intvärde1 + intvärde2) / 2.0;
            Console.WriteLine("The average is " + svar);



    }
  }
}
