// https://edabit.com/challenge/WLH46r3aARtXXYKF6
using System;

namespace MultiplyByLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask how long the user would like the array to be.
            Console.Write("How long would you like the array to be?: ");
            // Convert the console input from string -> int.
            int arraySize = Convert.ToInt32(Console.ReadLine());

            // Define an array of integers that we will use for calculations.
            // We can use the arraySize int here to define the array's size.
            int[] numbers = new int[arraySize];

            // Create a for loop, to ask for 5 integers and add them to the array.
            for (int i = 0; i < arraySize; i++)
            {
                // Ask the user to enter an integer, and display
                // the amount of inputs remaining.
                Console.Write($"Enter an integer ({i + 1}/{arraySize}): ");
                // Convert the console input from string -> int and add
                // it to our number array for later use.
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Create a for loop and multiply each number in the array
            // by the length of the array (arraySize|numbers.Length).
            for (int i = 0; i < arraySize; i++)
            {
                // Multiply the number by the length of the array.
                int sum = numbers[i] * arraySize;
                // Output the data to the console, including the array key and the sum.
                Console.WriteLine($"The output for array key {i} is {sum}");
            }

            // End the procedure.
            return;
        }
    }
}
