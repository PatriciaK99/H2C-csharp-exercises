﻿using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first string:");
            string firststring = Console.ReadLine();
            Console.WriteLine("Give the second string:");
            string secondstring = Console.ReadLine();
            if (firststring == secondstring)
            {
            Console.WriteLine("Echo");
            }
            else
            {
            Console.WriteLine("Nope");
            }



    }
  }
}
