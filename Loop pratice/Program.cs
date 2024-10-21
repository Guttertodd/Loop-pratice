using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Loop_pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1, number2, number3, number4;
            //double average;
            //Console.WriteLine("This will be the average of four numbers in a loop...");
            //Console.WriteLine("What is your first number?");
            //while (!int.TryParse(Console.ReadLine(), out number1)) ;
            //Console.WriteLine("2nd number?");
            //while (!int.TryParse(Console.ReadLine(), out number2)) ;
            //Console.WriteLine("3rd number?");
            //while (!int.TryParse(Console.ReadLine(), out number3)) ;
            //Console.WriteLine("Final number?");
            //while (!int.TryParse(Console.ReadLine(), out number4)) ;
            //average = (number1 + number2 + number3 + number4) / 4;
            //while (average == number1 + number2 + number3 + number4) ;
            //{
            //    Console.WriteLine("The average of those four numbers is: " + average);
            //}

            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            bool done = false;
            Console.WriteLine("Guess a number between 1 and 100:");
           int.TryParse(Console.ReadLine(), out userGuess);
            while (!done)
            {





                if (numberToGuess == userGuess)
                {
                    done = true;
                    Console.WriteLine("Congrats! You guessed the right number!");

                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low, Try again");
                    int.TryParse(Console.ReadLine(), out userGuess);
                    Console.WriteLine();
                }
                else (numberToGuess < userGuess);
                {
                    Console.WriteLine("Too high, Try again");
                    int.TryParse(Console.ReadLine(), out userGuess);
                    Console.WriteLine();
                }
               

            }
                
                    

               
                    Console.WriteLine("Please enter a vaild number");
                
        }
    }
}

