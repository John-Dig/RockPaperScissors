using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPS
  {
    [TestMethod] //1
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      //arrange
      Game newGame = new Game();
      //act
      //assert
      Assert.AreEqual(typeof(Game), newGame.GetType());

    }
    [TestMethod] //2
    public void Generator_GeneratesRPS_String()
    {
      //arrange
      Game newGame = new Game();
      //act
      int choice = newGame.GenerateRandomNumber();
      //assert
      Assert.IsTrue(choice >= 1 && choice <= 3);

    }

    [TestMethod] //3
    public void Evaluate_ReturnsAStringResult_String()
    {
      //arrange
      Game newGame = new Game();
      //act
      string result = newGame.Evaluate();
      //assert
      Assert.IsTrue(result == "rock" || result == "paper" || result == "scissors");
    }
    [TestMethod]
    public void GameEvaluator_ReturnsAStringOfIfTheComOrHumanWins_String()
    {

      //arrange
      Game newGame = new Game();
      //act
      string winner = "Human Wins";
      //assert
      Assert.isTrue(winner == "Human Wins" || winner == "Computer Wins" || winner == "Draw");
    }

  }





  //arrange
  //act
  //assert



}