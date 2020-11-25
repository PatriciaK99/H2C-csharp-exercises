using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
            int amount = 0;
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
                amount = list.Count;
      }
      Console.WriteLine(amount);
    }
  }
}
