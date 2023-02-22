using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    public string PlayerChoice;
    public string ComputerChoice;
    public Generator()
    {
      int randomNumber = randomNumber.Next(1, 4);
      return randomNumber;
    }
  }
}