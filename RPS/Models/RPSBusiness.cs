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

    

  }
}