using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("How many times");
         int input = Convert.ToInt32(Console.ReadLine());
            int count = 0;
      // Call your method here:
      
      while (input > count)
      {
          PrintPhrase();
             count ++;
      }
 
    }
      
        // Write your method here:
    public static void PrintPhrase() 
    {
            Console.WriteLine("In a hole in the ground there lived a method");
    }
  }
}
