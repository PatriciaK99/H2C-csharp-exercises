using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
            string procent = Console.ReadLine();
            int procenttal = Convert.ToInt32(procent);
            if (procenttal <0)
            {
            Console.WriteLine("Impossible");
            }
            else if (procenttal <=49)
            {
            Console.WriteLine("Fail");
            }
            else if (procenttal <=59)
            {
            Console.WriteLine("Grade: 1");
            }
            else if (procenttal <=69)
            {
            Console.WriteLine("Grade: 2");
            }
            else if (procenttal <=79)
            {
            Console.WriteLine("Grade: 3");
            }
            else if (procenttal <=89)
            {
            Console.WriteLine("Grade: 4");
            }
            else if (procenttal <=100)
            {
            Console.WriteLine("Grade: 5");
            }
            else
            {
            Console.WriteLine("Outstanding!");
            }

    }
  }
}
