using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Part 1
            //Ask user for starting number (lowest number)
            //Ask user for ending number (highest number)
            //Ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
            //Numbers must be stored in an array
            //Array must be populated using a loop
            //If the user enters a number that is outside of the range set, prompt the user to give you a valid number. 
            //...Do this until the user enters a valid number.

            Console.WriteLine("Welcome to the Lucky Lottery Game!!!");
            Console.WriteLine("You can win UP TO $1,000,000 in this game!!!");
            Console.WriteLine("In order to begin, please select a starting number. This will be the lowest number in the range.");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Next, please select an ending number. This will be the highest number in the range (make it a big one).");
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, please make the first of 6 guesses for the lucky numbers.");
            int userGuessOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, please make the second of 6 guesses for the lucky numbers.");
            int userGuessTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Please make the third of 6 guesses for the lucky numbers.");
            int userGuessThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, your fourth guess for the lucky numbers, please.");
            int userGuessFour = int.Parse(Console.ReadLine());
            Console.WriteLine("And your fifth guess for the lucky numbers, please.");
            int userGuessFive = int.Parse(Console.ReadLine());
            Console.WriteLine("And your sixth, and final guess for the lucky numbers, please.");
            int userGuessSix = int.Parse(Console.ReadLine());
            int[] userGuesses = { userGuessOne, userGuessTwo, userGuessThree, userGuessFour, userGuessFive, userGuessSix };

            Console.WriteLine("Your chosen guesses are " + userGuessOne + ", " + userGuessTwo + ", " + userGuessThree + ", " + userGuessFour + ", " + userGuessFive + ", and " + userGuessSix);







            //Part 2
            //The program should randomly generate 6 numbers using a loop
            //The randomly generated numbers should be stored in an array
            //Numbers should be displayed to the console as such and using a loop (Numbers below are for example only. 
            //...Format must be exact):
            //Lucky Number: 12
            //Lucky Number: 47
            //Lucky Number: 28
            //Lucky Number: 3
            //Lucky Number: 19
            //Lucky Number: 35

            Random luckyNumbers = new Random();
            int luckyOne = luckyNumbers.Next(startNumber, endNumber);
            Console.WriteLine("Lucky Number: " + luckyOne);
            int luckyTwo = luckyNumbers.Next(startNumber, endNumber);
            Console.WriteLine("Lucky Number: " + luckyTwo);
            int luckyThree = luckyNumbers.Next(startNumber, endNumber);
            Console.WriteLine("Lucky Number: " + luckyThree);
            int luckyFour = luckyNumbers.Next(startNumber, endNumber);
            Console.WriteLine("Lucky Number: " + luckyFour);
            int luckyFive = luckyNumbers.Next(startNumber, endNumber);
            Console.WriteLine("Lucky Number: " + luckyFive);
            int luckySix = luckyNumbers.Next(startNumber, endNumber);
            Console.WriteLine("Lucky Number: " + luckySix);

            int[] luckyNumbersArray = { luckyOne, luckyTwo, luckyThree, luckyFour, luckyFive, luckySix };



            //Part 3
            //Hard - code a value for the jackpot amount and let the user know what the jackpot amount is 
            //...at some point you decide in the program.
            //The program should count the number of correctly guessed numbers and output to the console to notify the user.
            //...Example: You guessed 3 numbers correctly!
            //The program should calculate the user's winnings based on the number of numbers guessed correctly.
            //The user's winnings should be output to the console. Example: You won $256, 877.23!

            double jackpot = 1000000;
            Console.WriteLine("The jackpot is $" + jackpot + "!!!");








            //Part 4
            //Ask the user if the user would like to play again.
            //If the user says yes, then the program should run again from the beginning.
            //If the user says no, then the program should say "Thanks for playing!"(Must be exact statement).



        }
    }
}
