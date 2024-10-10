using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Loop_pratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user;
            Console.WriteLine("Hello user, Welcome to Todd's Casino, you will start off with 3 points and for every game of heads and tails you win, you will gain one point, and every loss you will lose 1 point, you can walk away at anytime! Have fun! ");
            Console.WriteLine("Are you ready to play?");
            user = Console.ReadLine().ToLower();
            if (user == "Yes") ;
            {
                Console.WriteLine("Ok, heads or tails?");
            }
            
        }
    }
}
