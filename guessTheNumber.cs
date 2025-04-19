//here you can guess a number between 1-100
//the code will give you hint about whether you should guess a higher number or lower
//once guesses correctly, it will ask you whether you want to play the game again or not

using System;

public class Progranm
{
    static void Main(string[] args)
    {
        Random randowm = new Random();
        int guess;
        int guesses;
        int number;
        string yplay;
        
        while (true)
        {
            guess = 0;
            guesses = 1;
            number = randowm.Next(1, 100);
            while (guess != number)
            {
                Console.Write("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    break;
                }
                else if (guess < number)
                {
                    Console.WriteLine("your guess is wrong");
                    Console.WriteLine("guess high");
                }
                else if (guess > number)
                {
                    Console.WriteLine("your guess is wrong");
                    Console.WriteLine("guess low");
                }
                guesses++;
            }
            while (guess == number)
            {
                Console.WriteLine("Hurray! your guess is right\nand you took " + guesses + " guesses to answer right number");
                break;
            }
            Console.Write("Do you wanna play Again! Y/N:");
            yplay = Console.ReadLine();
            if (yplay == "y" || yplay == "Y")
            {
                continue;
            }
            else if (yplay == "N" || yplay == "n")
            {
                break;
            }
        }
    }
}
