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

    public string CheckMove(string playerOneMove, string playerTwoMove)
    {
      if (playerOneMove == "Rock")
      {
        if (playerTwoMove == "Scissors")
        {
          return "Player One Wins!";
        }
        else if (playerTwoMove == "Paper")
        {
          return "Player Two Wins!";
        }
        else if (playerTwoMove == "Rock")
        {
          return "It's a draw!";
        }
        else
        {
          return "error";
        }
      }
      else if (playerOneMove == "Scissors")
      {
        if (playerTwoMove == "Rock")
        {
          return "Player Two Wins!";
        }
        else if (playerTwoMove == "Paper")
        {
          return "Player One Wins!";
        }
        else if (playerTwoMove == "Scissors")
        {
          return "It's a draw!";
        }
        else
        {
          return "error";
        }
      }
      else if (playerOneMove == "Paper")
      {
        if (playerTwoMove == "Rock")
        {
          return "Player One Wins!";
        }
        else if (playerTwoMove == "Scissors")
        {
          return "Player Two Wins!";
        }
        else if (playerTwoMove == "Paper")
        {
          return "It's a draw!";
        }
        else
        {
          return "error";
        }
      }
      return "error";
    }
  }
}
