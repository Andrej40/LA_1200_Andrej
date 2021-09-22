using System;

namespace Erstes_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 100);
            int x = 1;
            Console.WriteLine("I have thought of a number ranging from 1-100. Can you guess it?");
            bool correctguess = false;
            
            
            while (!correctguess)
            {
            
             x = x + 1;
                
                try
                {
                    int userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess < 1 || userGuess > 100)
                    {
                        throw new Exception();
                    }
                    else if (x > 9)
                    {
                        Console.WriteLine("Here's a tutorial on how to git gud: ");
                        Console.WriteLine("Let's assume the random number is 37.");
                        Console.WriteLine("Your first guess should always be the number that's roughly between the highest and lowest number possible.");
                        Console.WriteLine("So that's 50. Then you're told it's too big.");
                        Console.WriteLine("Now the lowest possible number is 1 and the highest is 49.");
                        Console.WriteLine("The number inbetween would be about 25.");
                        Console.WriteLine("Then you're told your guess is too low.");
                        Console.WriteLine("So now the lowest possible number is 26 and the highest is 49.");
                        Console.WriteLine("That is why you write 37 or 38.");
                        Console.WriteLine("If you write 37, you are successful.");
                        Console.WriteLine("If you write 38, you are once again told your number is too big.");
                        Console.WriteLine("The highest possible number is 37 and the lowest one is 26.");
                        Console.WriteLine("So you write 33.");
                        Console.WriteLine("The lowest possible number now is 33 and the highest 37.");
                        Console.WriteLine("Now you can just guess the second highest number because there are only 5 possible numbers left.");
                        Console.WriteLine("That's 36 and you're told to write a bigger number.");
                        Console.WriteLine("The only possible number is 37 and you are successful. In this case, it would've only taken you 6 tries.");
                        Console.WriteLine("I hope this helps. Now try again. Your attempts have been resetted to 1.");
                        x = 1;
                    }


                    else if (RandomNumber == userGuess)
                    {
                        x = x - 1;

                        Console.WriteLine("Good job! You took " + x + " attempts");
                        correctguess = true;
                    }

                    else if (RandomNumber < userGuess)
                    {
                        Console.WriteLine("Your guess is too high! Try again!");

                    }

                    else if (RandomNumber > userGuess)
                    {

                        Console.WriteLine("Your guess is too low! Try again!");

                    }

                    else
                    {
                        Console.WriteLine("Please write a number!");

                    }
                }
                catch
                {
                    Console.WriteLine("Please write a whole number ranging from 1 to 100!");
                    
                }

            }
            
        }
    }
}
