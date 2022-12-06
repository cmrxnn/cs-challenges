// https://edabit.com/challenge/5ytLyHsZHfyDhBgXr
using System;

namespace HowManyVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a string, which we will then convert
            // into an array of characters which we can loop through.
            Console.Write("Enter a lower-case sentence or word: ");
            // Convert the console input from string -> char[].
            char[] letters = Console.ReadLine()!.ToCharArray();

            // Create an integer variable which stores the total amount
            // of times that a vowel appears in the char[].
            int totalVowels = 0;

            // Loop through the array of characters.
            for (int i = 0; i < letters.Length; i++)
            {
                // Create a 'switch' statement which will see whether
                // a letter is a vowel or not. If it is not a vowel, it
                // will not be counted towards the total.
                switch(letters[i])
                {
                    case 'a' or 'e' or 'i' or 'o' or 'u':
                        totalVowels++;
                        continue;
                    default:
                        continue;
                }
            }

            // Lastly, print the total to the console.
            Console.WriteLine($"The total amount of vowels in the given string was {totalVowels}");

            // Exit the procedure.
            return;
        }
    }
}
