using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesANewGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void CheckDraw_CheckIfThereIsADraw_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual("It's a draw", newGame.CheckDraw("Paper", "Paper"));
    }

    [TestMethod]

    public void CheckVictory_CheckIfThereIsADraw_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual("Player 1 wins!", newGame.CheckVictory("Rock", "Scissors"));
    }
  }
}