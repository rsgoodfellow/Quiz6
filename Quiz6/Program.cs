using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    internal class Program
    {
        static int vote1 = 0;
        static int vote2 = 0;
        static string canidate1 = "";
        static string canidate2 = "";

        static void results()
        {
            int totalVote = vote1 + vote2;
            Console.WriteLine("Voting Result: ");
            Console.WriteLine(canidate1 + ": " + (totalVote / vote1));
            Console.WriteLine(canidate1 + ": " + (totalVote / vote2));
        }

        static void finalResults()
        {
            int totalVote = vote1 + vote2;
            Console.WriteLine("Final Result: ");
            Console.WriteLine(canidate1 + ": " + (totalVote / vote1));
            Console.WriteLine(canidate1 + ": " + (totalVote / vote2));
        }
        static void Main(string[] args)
        {
            int userInput = 9;

            Console.WriteLine("Input the name of canidate 1: ");
            canidate1 = Console.ReadLine();
            Console.WriteLine("Input the name of canidate 2: ");
            canidate2 = Console.ReadLine();

            while (userInput != 0)
            {
                Console.WriteLine($"Who do you want to vote for? (1 for {canidate1}, 2 for {canidate2}, 0 to exit)");
                userInput =  Convert.ToInt32(Console.ReadLine());
                results();
            }
            finalResults();

            Console.Read();
        }
    }
}
