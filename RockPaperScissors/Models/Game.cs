namespace RockPaperScissors.Models
{
  public class Game
  {
    public string CheckDraw(string playerOneMove, string playerTwoMove)
    {
      if (playerOneMove == playerTwoMove)
      {
        return "It's a draw";
      }
      else
      {
        return "error";
      }
    }
  }

}
