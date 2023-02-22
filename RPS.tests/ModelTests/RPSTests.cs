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
      int choice = newGame.Generator();
      //assert
      Assert.IsTrue(choice >= 1 && choice <= 3);

    }

  }

  //arrange
  //act
  //assert


}