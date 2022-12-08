// https://edabit.com/challenge/nkkKguC5TgWnBiMLA
using System;

namespace ConvertAgeToDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write to the console to ask for an int to be given.
            Console.Write("Enter your age in years: ");
            // Read the console input and convert it from a string -> int.
            int ageInYears = Convert.ToInt32(Console.ReadLine());

            // Calculate the amount of days by multiplying the age by 365.
            int ageInDays = ageInYears * 365;
            // Output the sum to the console.
            Console.WriteLine($"The total amount of days is {sum}");

            // End the procedure.
            return;
        }
    }
}