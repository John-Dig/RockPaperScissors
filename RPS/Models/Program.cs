using System;
using System.Collections.Generic;
using RPS.Models;

namespace RPS
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Enter rock, paper, or scissors:");
      Game newGame = new Game();
      string PlayerChoice = Console.ReadLine();

      Console.WriteLine(newGame.Evaluate());
      Console.WriteLine(newGame.GameEvaluator());
    }
  }
}