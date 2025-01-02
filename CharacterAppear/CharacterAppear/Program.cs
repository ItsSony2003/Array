using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterAppear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Declare a string and assign a value
            Console.Write("Enter your string: ");
            string inputString = Console.ReadLine();

            // Display the string to the user
            Console.WriteLine("String: " + inputString);

            // Step 2: Input a character to search for
            Console.Write("Enter a character to count: ");
            char character;
            if (!char.TryParse(Console.ReadLine(), out character))
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
                return;
            }

            // Normalize the input string and character to the same case
            inputString = inputString.ToLower();
            character = char.ToLower(character);

            // Step 3: Initialize the count variable
            int count = 0;

            // Step 4: Loop through the string to count occurrences
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == character)
                {
                    count++;
                }
            }

            // Step 5: Output the result
            Console.WriteLine($"The character '{character}' appears {count} time(s) in the string.");

            Console.ReadKey();
        }
    }
}
