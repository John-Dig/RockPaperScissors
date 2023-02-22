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
      string computerInput = Evaluate();
      string humanInput = "rock";
      string winner = "";
      if (computerInput == "scissors" && humanInput == "rock")
      {
        winner = "Human Wins";
      }
      if (computerInput == "rock" && humanInput == "paper")
      {
        winner = "Human Wins";
      }
      if (computerInput == "paper" && humanInput == "scissors")
      {
        winner = "Human Wins";
      }
      if (computerInput == humanInput)
      {
        winner = "Draw";
      }
      if (computerInput == "paper" && humanInput == "rock")
      {
        winner = "Computer Wins";
      }
      if (computerInput == "scissors" && humanInput == "paper")
      {
        winner = "Computer Wins";
      }
      if (computerInput == "rock" && humanInput == "scissors")
      {
        winner = "Computer Wins";
      }
      return winner;
    }
  }
}