using System;
using System.Collections;
using System.Collections.Generic;


namespace TriviaLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Trivia Leaderboard");
            ArrayList sc = new ArrayList();
            sc.Add("4400");
            sc.Add("8900");
            sc.Add("1200");
            sc.Add("3700");
            sc.Add("7200");

            sc.Sort();

            
            foreach (string s in sc)
            { Console.WriteLine(s); }

            sc.Reverse();

            foreach (string s in sc)
            { Console.WriteLine(s); }

            sc.Add("2400");

            sc.Remove("4400");





        }
    }
}
