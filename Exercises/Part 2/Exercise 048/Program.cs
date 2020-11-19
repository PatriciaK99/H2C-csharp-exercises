using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
           int number = 0;
            double sum = 0;
            int count = 0;
            int countdouble =0;
            int countodd = 0;
      while (number !=-1)
      {

      Console.WriteLine("Give numbers:");
            number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
                count = count+1;
                if ((number % 2) == 0)
                {
                countdouble = countdouble + 1;
                }
                else
                {
                countodd = countodd +1;
                }
      }
      Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + (sum + 1));
            Console.WriteLine("Numbers: " + (count-1));
            double average = (sum+1) / (count-1);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Even: " + countdouble);
            Console.WriteLine("Odd: " + (countodd -1));

            
 
    }
  }
}
