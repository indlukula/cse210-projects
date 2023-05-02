using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep3 World!");
       //declare variables
        int magicNumber;
        int guess;
        //string userMagicNumber;
        //string  userGuessNumber;

        // Requirement #1
        // Ask user for a magic number
        // Ask user to guess 

        // Console.WriteLine("Welcome to the guessing game!");
        //Console.Write("Please enter your magic number: ");
        //magicNumber = int.Parse(Console.ReadLine());

        //Console.Write("Make a guess: ");
        //guess = int.Parse(Console.ReadLine());

        //if (guess == magicNumber) {
        //    Console.WriteLine("Congratulations! You guessed the magic number!");
        //} else if (guess < magicNumber) {
         //   Console.WriteLine("Sorry, your guess is too low, Please try again.");
        //}else {
         //   Console.WriteLine("Sorry, your guess is too high. Please try again");
        //}

        //Core Requirement #2
        //Ask for the number
        // Use a loop if as long as the guess does not match the magic number

        //Console.Write("Please enter your the magic number: ");
        //userMagicNumber = Console.ReadLine();
        //magicNumber = int.Parse(userMagicNumber);

        // Ask user to guess
        //Console.Write("Make a guess: ");
        //userGuessNumber = Console.ReadLine();
        //guess = int.Parse(userGuessNumber);

        //while (guess != magicNumber)
        //{
        //    if (guess > magicNumber)
        //   {
        //       Console.WriteLine("Sorry, your guess is too high, Please try again");
        //       Console.Write("Make a guess: ");
        //      userGuessNumber = Console.ReadLine();
        //       guess = int.Parse(userGuessNumber);
        //  }
        //  else if (guess < magicNumber)
        //  {
        //      Console.WriteLine("Sorry, your guess is too low. Please try again");
        //      Console.Write("Make a guess: ");
        //      userGuessNumber = Console.ReadLine();
        //      guess = int.Parse(userGuessNumber);       
        //  }
        //}
        // Console.WriteLine("Congratulations! You guessed the magic number!");

         /*
          Core Requirement #3
          Instead of having the user to supply the magic number, generate a random number from 1 to 100
          */
          Random randomGenerator = new Random();
          magicNumber = randomGenerator.Next(1, 101);

          guess = -1;

          while (guess != magicNumber)
          {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Sorry, your guess is too low, Please try again");

            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Sorry, your guess is too high. Please try again");

            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
            }

          }

        
    }
}