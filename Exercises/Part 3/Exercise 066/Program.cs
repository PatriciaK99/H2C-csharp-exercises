﻿using System;
using System.Collections.Generic;

namespace exercise_66
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
            int index =0;
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
             index = list.Count   
      }
      
      Console.WriteLine([index]);
    }
  }
}
