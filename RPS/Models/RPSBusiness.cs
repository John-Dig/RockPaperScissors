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
        return result;
      }
      if (num == 2)
      {
        result = "paper";
        return result;
      }
      if (num == 3)
      {
        result = "scissors";
        return result;
      }
      return result;
    }
  }
}