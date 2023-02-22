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

  }

  //arrange
  //act
  //assert


}