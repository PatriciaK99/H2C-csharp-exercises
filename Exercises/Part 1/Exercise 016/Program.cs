using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("How many days?");
            string insättning = Console.ReadLine();
            int intvärde = Convert.ToInt32(insättning);
            int svar = intvärde * (24*(60*60));
            Console.WriteLine(svar);


    }
  }
}
