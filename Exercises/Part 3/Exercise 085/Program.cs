using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)

            //put username and password in array, compare to userinput, loop
    {
    Console.WriteLine("Enter username: ");
            string inputusername = Console.ReadLine();

            if (inputusername == "alex")
            {
            Console.WriteLine("Enter password: ");
            }

            string inputpassword = Console.ReadLine();
            if (inputpassword == "sunshine")
            {
                Console.WriteLine("You have successfully logged in!");
            }

            else
            {
                Console.WriteLine("Incorrect username or password!");
            }

            if (inputusername == "emma")
            {
            Console.WriteLine("Enter password: ");
            }
            string inputpassword1 = Console.ReadLine();
            if (inputpassword1 == "haskell")
            {
                Console.WriteLine("You have successfully logged in!");
            }

            else
            {
                Console.WriteLine("Incorrect username or password!");
            }
    }
  }
}

