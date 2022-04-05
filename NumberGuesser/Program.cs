using System;

namespace NumberGuesser
{

// Main Class
    class Program
    {
        //Entry Point Method
        public static void Main(string[] args)
        {

            //Set app variables
            string appName = "Number Guesser!";
            string appAuthor = "Jordan McKenna";

            //Change Text Colour
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{appName} by {appAuthor}");

            Console.ResetColor();

            //User name

            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Hey {inputName}!, Have a go a guessing my favourite Pokemon!");

            // fave Pokemon
            string favPokemon = "Charizard";

            string guess = "";

            while(guess != favPokemon)
            {
                string input = Console.ReadLine();

                guess = (input);

                // match guess to fave Pokemon

                if(guess != favPokemon)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"That aint my favourite Pokemon, {inputName}. Try again!");

                    Console.ResetColor();

                }
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Rawrrrrr! Well done {inputName}, {favPokemon} is my favourite Pokemon");

            Console.ResetColor();
        }
    }
}
