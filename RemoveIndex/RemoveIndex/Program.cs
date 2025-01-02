using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Declare and initialize the array
            int[] array = { 1, 7, 5, 9, 3 }; // Example array
            Console.WriteLine("Original Array: " + string.Join(", ", array));

            // Step 2: Input the element to remove
            Console.Write("Enter the value to remove: ");
            if (!int.TryParse(Console.ReadLine(), out int X))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            // Step 3: Find the position of X in the array
            int index_del = -1; // -1 indicates that X is not found
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == X)
                {
                    index_del = i;
                    break;
                }
            }

            if (index_del == -1)
            {
                Console.WriteLine($"The value {X} is not in the array.");
            }
            else
            {
                // Step 4: Remove X by shifting elements to the left
                for (int i = index_del; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                // Reduce the size of the array logically (ignore the last element)
                int[] updatedArray = new int[array.Length - 1];
                Array.Copy(array, updatedArray, updatedArray.Length);

                // Step 5: Print the updated array
                Console.WriteLine("Updated Array: " + string.Join(", ", updatedArray));
            }

            Console.ReadKey();
        }
    }
}
