// https://edabit.com/challenge/RzkLShpDgDqG3c45H
using System;

namespace ReturnTheNextNumberFromTheIntegerPassed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write to the console to ask for an int|double to be given.
            Console.Write("Please enter a number or decimal: ");
            // Read the console input and convert it from a string -> int.
            double input = Convert.ToDouble(Console.ReadLine());

            // Increment the input by 1.
            input++;

            // Output the new input to the console.
            Console.WriteLine($"Adding +1 to the input results in an output of {input}");

            // End the procedure.
            return;
        }
    }
}
