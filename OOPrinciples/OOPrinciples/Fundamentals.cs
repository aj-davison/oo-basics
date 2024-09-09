using System;
using System.Collections;
using System.Text;

namespace Fundamentals
{
    internal class Fundamentals
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter fruit in space separated list and I will return a recipe for you");

            // Try it yourself

            #region forRecipeExample
            var ingredientsList = Console.ReadLine();
            string[]? ingredients = ingredientsList?.Split(' ');
            string recipe = "Peel (if needed) and chop up ";

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (i == ingredients.Length - 1) recipe += "and " + ingredients[i] + " ";
                else recipe += ingredients[i] + ", ";
            }

            recipe += "into bite size pieces. \n" + $"Add your favorite milk and the chopped ingredients to a blender\nBlend for 3 minutes until smooth. \n" +
                $"Enjoy with a reusable straw and your favorite mug :)";
            Console.WriteLine(recipe);
            #endregion forRecipeExample


            #region doWhileTryItOut 
            //Try it out: update this code and use a do while to create a guessing game that takes in colors and breaks the loop when 
            //the guesser guesses the favorite color.
            string myFavoriteColor = "blue";
            string guess = "";
            Console.Write("\n\n\n");
            Console.WriteLine("Welcome to my color guessing game! Guess a color to start!");

            do
            {
                guess = Console.ReadLine();
            } while (guess != myFavoriteColor);
            Console.WriteLine($"Yay! You guessed it my favorite color is {myFavoriteColor}!");
            #endregion doWhileTryItOut


            #region hashTable
            Hashtable studentGrades = new Hashtable();

            //Adding values
            studentGrades["Jenny"] = 95;
            studentGrades["Bilal"] = 97;
            studentGrades["Sunny"] = 65;

            //Accessing values by key
            Console.WriteLine("Jenny's grade is " + studentGrades["Jenny"]);
            Console.WriteLine("Bilal's grade is " + studentGrades["Bilal"]);
            Console.WriteLine("Sunny's grade is " + studentGrades["Sunny"]);

            //Checking if the key exists before writing the value to console.
            foreach (var kvp in studentGrades)
            {
                Console.WriteLine(kvp);
            }


            #endregion hashTable
        }
    }
}
