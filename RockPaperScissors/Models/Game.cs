namespace RockPaperScissors.Models
{
  public class Game
  {
    public string PlayComputer(string userChoice, string computerChoice)
    {
      if (computerChoice == "1")
      {
        if (userChoice == "Rock")
        {
          return "The computer chose rock, it is a tie.";
        }
        else if (userChoice == "Paper")
        {
          return "The computer chose paper, it is a tie.";
        }
        else if (userChoice == "Scissors")
        {
          return "The computer chose scissors, it is a tie.";
        }
        else
        {
          return "error";
        }
      }
      else if (computerChoice == "2")
      {
        if (userChoice == "Rock")
        {
          return "The computer chose paper, sorry you lose. Paper beats rock.";
        }
        else if (userChoice == "Paper")
        {
          return "The computer chose scissors, sorry you lose. Scissors beat paper.";
        }
        else if (userChoice == "Scissors")
        {
          return "The computer chose rock, sorry you lose. Rock beats scissors";
        }
        else
        {
          return "error";
        }
      }
      else if (computerChoice == "3")
      {
        if (userChoice == "Rock")
        {
          return "The computer chose scissors, you win. Rock beats scissors.";
        }
        else if (userChoice == "Paper")
        {
          return "The computer chose rock, you win. Paper beats rock.";
        }
        else if (userChoice == "Scissors")
        {
          return "The computer chose paper, you win. Scissors beat paper.";
        }
        else
        {
          return "error";
        }
      }
      return "error";
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
