// https://edabit.com/challenge/J3WGSreYhc65cWyrc
using System;

namespace AbsoluteSum
{
    internal class Program
    {
        // Define a constant int for referencing the size of the integer array.
        public const int ARRAY_SIZE = 5;

        static void Main(string[] args)
        {
            // Define an array of integers that we will use for calculations.
            // We can use the ARRAY_SIZE const here to define the array's size.
            int[] numbers = new int[ARRAY_SIZE];

            // Create a for loop, to ask for 5 integers and add them to the array.
            for (int i = 0; i < numbers.Length; i++)
            {
                // Ask the user to enter an integer, and display
                // the amount of inputs remaining.
                Console.Write($"Enter an integer ({i + 1}/{ARRAY_SIZE}): ");
                // Convert the console input from string -> int and add
                // it to our number array for later use.
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Now that our array has been populated, we can loop back through the
            // array and add each part of the array to an overall total.
            int arraySum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                // Take the total, as well as the new number, and add them together.
                // If we just did 'arraySum = numbers[i]', the total would keep getting
                // overwritten.
                arraySum = arraySum + numbers[i];
            }

            // Lastly, print the total sum of all of the numbers to the console.
            Console.WriteLine($"The total of all of these numbers is {arraySum}");

            // End the procedure.
            return;
        }
    }
}
