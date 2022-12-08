// https://edabit.com/challenge/2QvnWexKoLfcJkSsc
namespace ArrayOfMultiples
{
    internal class Program
    {
        // Define a public constant for the size of the array.
        public const int MAX_SIZE = 2;
        static void Main(string[] args)
        {
            // Ask for the 'first' integer, which will be used
            // to determine where the program should start.
            Console.Write("Enter an integer (1/2): ");
            int first = Convert.ToInt32(Console.ReadLine());

            // Ask for the 'second' integer, which will be used
            // to determine where the program should end.
            Console.Write("Enter an integer (2/2): ");
            int second = Convert.ToInt32(Console.ReadLine());

            // Now, let's multiple these values together to get the max value.
            int total = first * second;

            // Now, we can create a for loop and increment 'i' by the first input,
            // ensuring that we don't go over the max with the 'i <= total' part.
            Console.WriteLine("Multiples in the given bounds: ");
            for (int i = first; i <= total; i += first)
            {
                Console.Write($"{i}, ");
            }

            // End the procedure.
            return;
        }
    }
}
