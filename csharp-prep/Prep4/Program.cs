using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.\n");
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        int average = 0;
        int largest_number = 0;

        while (!(number == 0))
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int i in numbers)
        {
            sum += i;
        }
        int max = numbers[0];

        foreach (int i in numbers)
        {
            if (i > largest_number)
            {
                largest_number = i;
            }
        }

        int length = numbers.Count;
        average = sum/length;

        Console.Write("This is the total " + sum);
        Console.Write("\nThe average is: " + average);
        Console.Write("\nThe largest number is: " + largest_number);
    }
}