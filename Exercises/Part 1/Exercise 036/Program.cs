﻿using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
    while (true)
    {
      Console.WriteLine("Give a number:");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number < 0)
            {
            Console.WriteLine("That is negative");
            }
            if (number == 0)
            {
            break;
            }
            if (number > 0)
            {
            Console.WriteLine(number*number);
            }
    }

    }
  }
}
