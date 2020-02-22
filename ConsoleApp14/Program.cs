using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10).ToArray();
            //DisplayResult(numbers, "Display all numbers");
            //var newNumbers = numbers[0..2];
            //DisplayResult(newNumbers, "Display copy of numbers");

            numbers = new int[] 
            {
                1, // start index - 0 && end index is ^5
                2, // start index - 1 && end index is ^4
                3, // start index - 2 && end index is ^3
                4, // start index - 3 && end index is ^2
                5  // start index - 4 && end index is ^1
            };

            //var number = numbers[^1];
            //Console.WriteLine(number);

            //var newNumbers = numbers[^2..];
            //DisplayResult(newNumbers, "Display copy of numbers");

            //var newNumbers = numbers[0..^0];
            //DisplayResult(newNumbers, "Display copy of numbers");

            //Index startNumber = 0;
            //Index endNumber = ^0;
            //Range queryRange = startNumber..endNumber;
            //var newNumbers = numbers[queryRange];

            //DisplayResult(newNumbers, "Display query numbers in variable");

            var newNumbers = numbers[0..^1];
            DisplayResult(newNumbers, "Display with excluded number");

        }

        private static void DisplayResult(IEnumerable<int> numbers, string messageToDisplay)
        {
            Console.WriteLine(messageToDisplay);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
