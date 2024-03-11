using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of integers: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = array.Sum();
            double mean = array.Average();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Mean: {mean}");
        }
    }
}
