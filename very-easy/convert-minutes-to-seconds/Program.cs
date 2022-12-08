// https://edabit.com/challenge/bizjGL4wyd8PwR4Ke
using System;

namespace ConvertMinutesToSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write to the console to ask for an int to be given.
            Console.Write("Input the amount of minutes: ");
            // Read the console input and convert it from a string -> int.
            int minutes = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum (60 seconds / minute).
            int sum = minutes * 60;
            // Output the sum to the console.
            Console.WriteLine($"The amount of seconds in {minutes} minutes is {sum} seconds");

            // End the procedure.
            return;
        }
    }
}
