﻿using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.WriteLine("Your speed:");
      string nummerinput = Console.ReadLine();
            int speed = Convert.ToInt32(nummerinput);
            if (speed >120)
            {
            Console.WriteLine("Speeding!");
            }
      
    }
  }
}
