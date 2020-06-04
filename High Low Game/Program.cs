using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace High_Low_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int answer;
            int attempts = 0;
            string Dif;
            Random rnd = new Random();

            List<int> Difficulty = new List<int>();
            Difficulty.Add(10);
            Difficulty.Add(25);
            Difficulty.Add(50);
            Difficulty.Add(100);


            Console.WriteLine("Welcome to the High Low Game!");
            Console.WriteLine("What difficulty would you like to play on (Easy, Medium, Hard, Very Hard):");

            Dif = Console.ReadLine();
            if (Dif == "Easy")
            {
                answer = rnd.Next(Difficulty[0]);
                Console.WriteLine("Your Range is 1 - 10");
            }
            else if (Dif == "Medium")
            {
                answer = rnd.Next(Difficulty[1]);
                Console.WriteLine("Your Range is 1 - 25");
            }
            else if (Dif == "Hard")
            {
                answer = rnd.Next(Difficulty[2]);
                Console.WriteLine("Your Range is 1 - 50");
            }
            else if (Dif == "Very Hard")
            {
                answer = rnd.Next(Difficulty[3]);
                Console.WriteLine("Your Range is 1 - 100");
            }
            else
            {
                Console.WriteLine("Your input was Undetermined");
                Console.WriteLine("Your Range is 1 - 20");
                answer = rnd.Next(20);
            }


            

            Console.WriteLine("Input your Guess:");

            while (guess != answer)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < answer)
                {
                    Console.WriteLine("Your Guess is Lower Then the Answer");
                    
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Your Guess is Higher Then the Answer");
                    
                }
                else
                {
                    Console.WriteLine("The Answer was: " + answer);
                    Console.WriteLine("You got it in " + attempts + " attempts!");
                    break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
