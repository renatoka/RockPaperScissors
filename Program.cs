using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            /*We create an array so we can store
             * all three items for RPS. */
            string[] rps = { "Rock", "Paper", "Scissors" };

            int choice = random.Next(rps.Length);

            //Console.WriteLine(rps[choice]);

            Console.Write("Please enter your choice: ");
            string userGuess = Console.ReadLine();

            if (userGuess == rps[choice])
            {
                Console.WriteLine("Tie");

            }

            else if (userGuess == "Rock")
            {
                if (rps[choice] == "Paper")
                {
                    Console.WriteLine($"{rps[choice]} beats {userGuess}. You lost!");
                }

                else
                {
                    Console.WriteLine($"{userGuess} doesn't beat {rps[choice]}. You won!");
                }
            }

            else if (userGuess == "Paper")
            {
                if (rps[choice] == "Rock")
                {
                    Console.WriteLine($"{userGuess} beats {rps[choice]}. You won!");
                }

                else
                {
                    Console.WriteLine($"{rps[choice]} beats {userGuess}. You lost!");
                }
            }

            else if (userGuess == "Scissors")
            {
                if (rps[choice] == "Paper")
                {
                    Console.WriteLine($"{userGuess} beats {rps[choice]}. You won!");
                }

                else
                {
                    Console.WriteLine($"{rps[choice]} beats {userGuess}. You lost!");
                }
            }
        }
    }
}
