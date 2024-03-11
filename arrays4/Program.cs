using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] reversed = input.Reverse().ToArray();
            string reversedString = new string(reversed);

            Console.WriteLine($"Reversed string: {reversedString}");
        }
    }
}
