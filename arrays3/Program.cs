using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] longestSequence = FindLongestIncreasingSequence(numbers);

            Console.WriteLine($"Longest increasing sequence: {string.Join(" ", longestSequence)}");
        }
        static int[] FindLongestIncreasingSequence(int[] numbers)
        {
            int maxLength = 0;
            int currentLength = 1;
            int endIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        endIndex = i;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return numbers.Skip(endIndex - maxLength + 1).Take(maxLength).ToArray();
        }
    }

}
