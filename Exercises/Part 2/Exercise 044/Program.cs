using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

            int nummer1 = Convert.ToInt32(Console.ReadLine());
            int nummer2 = Convert.ToInt32(Console.ReadLine());
            if (nummer1 > nummer2)
            {
            Console.WriteLine(nummer1 +" is grEater than "+ nummer2 + ".");
            }
            else if (nummer1 < nummer2)
            {
            Console.WriteLine(nummer1 +" is less than "+ nummer2 + ".");
            }
            else
            {
            Console.WriteLine(nummer1 + " is equal to " + nummer2 + ".");
            }
    }
  }
}
