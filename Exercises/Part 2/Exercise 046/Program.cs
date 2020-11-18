using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = number;
    while (count <= 100)
    {
        Console.WriteLine(count);
                count++;
    }
    }
  }
}
