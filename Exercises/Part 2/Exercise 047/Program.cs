using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Where to?");
           int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where from?");
           int start = Convert.ToInt32(Console.ReadLine());
           int count = start;
    while (count <= number)
    {
        Console.WriteLine(count);
                count++;
    }
      
    }
  }
}
