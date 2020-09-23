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

    public void CheckMove_CheckIfThereIsAVictoryForPlayerOne_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual("Player One Wins!", newGame.CheckMove("Scissors", "Paper"));
    }

    [TestMethod]

    public void CheckMove_CheckIfThereIsALossForPlayerOne_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual("Player Two Wins!", newGame.CheckMove("Paper", "Scissors"));
    }

    // [TestMethod]
    // public void CheckMove_CheckIfThereIsALossForPlayerOne_Game()
    // {
    //   string description = "Player Two Wins!";
    //   Game newGame = new Game(description);

    //   string result = check

    // }
  }
}