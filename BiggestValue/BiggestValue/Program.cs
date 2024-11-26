using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.Write("Enter a size: ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should NOT exceed 20!");
            } while(size > 20);

            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.Write("Enter Element " + (i+1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("Property List: ");
            for (int j  = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            Console.WriteLine();

            Console.WriteLine("The largest propertyu value in the list is " + max + ", at position " + index);
            Console.ReadKey();
        }
    }
}
