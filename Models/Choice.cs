using System;
using System.Collections.Generic;

namespace CPU
{
  class Choice {
    private Random randomChoice = new Random();

    List<string> GameChoice = new List<string>(){"rock", "paper", "scissors"};
    public int Shoot(string YourChoice) {
      int choiceNum = randomChoice.Next(GameChoice.Count);
      string cpuChoice = GameChoice[choiceNum];
      cpuChoice == YourChoice ? System.Console.WriteLine("Tie  " + "CPU: " + cpuChoice) : (cpuChoice == "rock") && (YourChoice == "scissors") || (cpuChoice == "paper") && (YourChoice == "rock") || (cpuChoice == "scissors") && (YourChoice == "paper") ? System.Console.WriteLine("You Lose  " + "CPU: " + cpuChoice) : System.Console.WriteLine("You Win!!  " + "CPU: " + cpuChoice);
    }
  }
}
