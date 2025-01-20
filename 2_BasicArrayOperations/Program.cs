using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BasicArrayOperations
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many numbers do you want to process? ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            int i = 0;
            while (i < count)
            {
                Console.Write($"What is the in number {i + 1}? ");
                numbers[i] = int.Parse(Console.ReadLine());
                i++;
            }

            int sum = 0;
            int j = 0;
            while (j < count)
            {
                sum += numbers[j];
                j++;
            }

            int largest = numbers[0];
            int smallest = numbers[0];
            int k = 1;
            while (k < count)
            {
                if (numbers[k] > largest)
                {
                    largest = numbers[k];
                }
                if (numbers[k] < smallest)
                {
                    smallest = numbers[k];
                }
                k++;
            }
            Console.WriteLine($"The sum of array is {sum}");
            Console.WriteLine($"The largest number in the array is {largest}");
            Console.WriteLine($"The smallest number in the array is {smallest}");
            Console.ReadLine();
        }

    }
}
