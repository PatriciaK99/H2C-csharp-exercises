using System;

namespace exercise_59
{
  class Program
  {
        public static int Greatest(int number1, int number2, int number3) 
{
         // write your code here
         // do not print anything inside the method

         // there must be a return command at the end
         int answer = number2;
            return answer;
}

    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

   

  }
}
