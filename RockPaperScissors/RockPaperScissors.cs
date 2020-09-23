using System;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Console.WriteLine("Play Rock, Paper, Scissors against the computer");
      Console.WriteLine("Please choose Rock, Paper, or Scissors");
      string userChoice = Console.ReadLine();  //Make all options possible (ToLowerCase();)

      Random randomNumber = new Random();
      int computerChoiceInt = randomNumber.Next(4);
      string computerChoice = computerChoiceInt.ToString();

      // Console.WriteLine(computerChoice);
      // Console.WriteLine(userChoice);

      Game newGame = new Game();
      string result = newGame.PlayComputer(userChoice, computerChoice);
      Console.WriteLine(result);



      //SOLUTION 1 (IF THERE WERE TWO PLAYERS):

      // Console.WriteLine("Play Rock, Paper, Scissors");
      // Console.WriteLine("Enter PlayerOne Name: ");
      // string playerOneName = Console.ReadLine();
      // Console.WriteLine("Enter PlayerTwo Name: ");
      // string playerTwoName = Console.ReadLine();



      // Console.WriteLine("Enter your action player one");
      // string playerOneMove = Console.ReadLine();
      // Console.WriteLine("Enter your action player two");
      // string playerTwoMove = Console.ReadLine();

      // Game newGame = new Game();

      // string result = newGame.CheckMove(playerOneMove, playerTwoMove);
      // Console.WriteLine(result);
    }
  }
}