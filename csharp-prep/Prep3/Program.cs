using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int magic_number = int.Parse(input);
        int number = 0;

        while (!(number == magic_number))
        {
            Console.Write("What is your guess? ");
            string otherInput = Console.ReadLine();
            int guess_number = int.Parse(otherInput);

            if (guess_number < magic_number){
                Console.WriteLine("Higher");
            }
            else if (guess_number > magic_number){
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}