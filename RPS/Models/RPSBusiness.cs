using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    public string PlayerChoice;
    public string ComputerChoice;

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

    public string GameEvaluator()
    {
      string ComputerChoice = Evaluate();
      
      string winner = "";
      Console.WriteLine(ComputerChoice);
      Console.WriteLine(PlayerChoice);
      if (ComputerChoice == "scissors" && PlayerChoice == "rock")
      {
        winner = "Human Wins";
      }
      if (ComputerChoice == "rock" && PlayerChoice == "paper")
      {
        winner = "Human Wins";
      }
      if (ComputerChoice == "paper" && PlayerChoice == "scissors")
      {
        winner = "Human Wins";
      }
      if (ComputerChoice == PlayerChoice)
      {
        winner = "Draw";
      }
      if (ComputerChoice == "paper" && PlayerChoice == "rock")
      {
        winner = "Computer Wins";
      }
      if (ComputerChoice == "scissors" && PlayerChoice == "paper")
      {
        winner = "Computer Wins";
      }
      if (ComputerChoice == "rock" && PlayerChoice == "scissors")
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