using System;
using System.Collections.Generic;

namespace RPSRedux
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random cpuRandom = new Random();
            bool stillPlaying = true;

            List<string> GameChoice = new List<string>{"rock", "paper", "scissors"};

            string Shoot() {
                int choiceNum = cpuRandom.Next(GameChoice.Count);
                string cpuChoice = GameChoice[choiceNum];
                return cpuChoice;
            }  
            Console.WriteLine("---type out choice---");
            Console.WriteLine("rock, paper, scissors, or press 'e' to escape");
            while (stillPlaying) {

            var UserChoice = Console.ReadLine();
            if (UserChoice == "e") {
                stillPlaying = false;
            }
            var cpuChoice = Shoot();


            var result = cpuChoice == UserChoice ? "Tie  " + "CPU: " + cpuChoice : cpuChoice == "rock" && UserChoice == "scissors" || cpuChoice == "paper" && UserChoice == "rock" || cpuChoice == "scissors" && UserChoice == "paper" ? "You Lose  " + "CPU: " + cpuChoice : "You Win!!  " + "CPU: " + cpuChoice;

            System.Console.WriteLine(result);
            }
            System.Console.WriteLine("Thanks for Playing!");
            }
    }
}
