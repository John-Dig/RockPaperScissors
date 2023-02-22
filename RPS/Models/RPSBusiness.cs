using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    // public string computer { get; set; }
    // public string human { get; set; }

    public int GenerateRandomNumber()
    {
      Random random = new Random();

      int randomNumber = random.Next(1, 4);
      return randomNumber;
    }

    public string Evaluate()
    {
      int num = GenerateRandomNumber();
      string result = "";
      if (num == 1)
      {
        result = "rock";
      }
      if (num == 2)
      {
        result = "paper";
      }
      if (num == 3)
      {
        result = "scissors";
      }
      return result;
    }

    public string GameEvaluator(string computer, string human)
    {
      string ComputerChoice = Evaluate();
      Console.WriteLine(computer);
      Console.WriteLine(human);
      string winner = "";

      if (computer.Equals("scissors") && human.Equals("rock"))
      {
        winner = "Human Wins";
      }
       else if (computer.Equals("rock") && human.Equals("paper"))
      {
        winner = "Human Wins";
      }
      else if (computer.Equals("paper") && human.Equals("scissors"))
      {
        winner = "Human Wins";
      }
      else if (computer.Equals(human))
      {
        winner = "Draw";
      }
      else if (computer.Equals("paper") && human.Equals("rock"))
      {
        winner = "Computer Wins";
      }
      else if (computer.Equals("scissors") && human.Equals("paper"))
      {
        winner = "Computer Wins";
      }
      else if (computer.Equals("rock") && human.Equals("scissors"))
      {
        winner = "Computer Wins";
      }
      else
      {
        winner = "Whaaaaaat!";
      }
      return winner;
    }
  }
}