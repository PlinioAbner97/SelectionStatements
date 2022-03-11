using System;

namespace SelectionExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int favoriteNumber = 497;

             Console.WriteLine("Guess the favorite number, Hint: below 500");
             int userGuess = int.Parse(Console.ReadLine());

             if (userGuess < favoriteNumber)
             {
             Console.WriteLine("Too Low!!!");
             }
             else if (userGuess > favoriteNumber)
             {
            Console.WriteLine("Too High!!!");
             }
            else if (userGuess == favoriteNumber)
             {
            Console.WriteLine("You were correct here is a cookie");
             }
             else
             {
            Console.WriteLine("Nevermind");
             }

            
            
        }
    }
}
