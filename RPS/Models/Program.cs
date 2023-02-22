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
      string human = Console.ReadLine();
      string computer = newGame.Evaluate();
      Console.WriteLine("Computer Choice:" + computer);
      Console.WriteLine("Human Choice: " + human);
      string result = newGame.GameEvaluator(computer, human);
      Console.WriteLine(result);
    }
  }
}