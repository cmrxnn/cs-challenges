// https://edabit.com/challenge/L2fwjYi9YixY8kJfK
using System;

namespace CircuitPowerCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write to the console to ask for a double to be given.
            Console.Write("Enter a number (1/2): ");
            // Read the console input and convert it from a string -> double.
            double first = Convert.ToDouble(Console.ReadLine());

            // Write to the console to ask for a double to be given.
            Console.Write("Enter a number (2/2): ");
            // Read the console input and convert it from a string -> double.
            double second = Convert.ToDouble(Console.ReadLine());

            // Calculate the sum of both inputs.
            double sum = first * second;
            // Output the sum to the console.
            Console.WriteLine($"The total power is {sum}");

            // End the procedure.
            return;
        }
    }
}