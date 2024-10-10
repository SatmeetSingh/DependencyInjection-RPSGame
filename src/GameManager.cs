using System;

// this gamemanger depends on 2 choices to be made
namespace DependencyInjection.src { 
    public class GameManager
    {
      private IPlayer _player1;
      private IPlayer _player2;

      public GameManager(IPlayer player1,IPlayer player2){
        _player1 = player1;
        _player2 = player2; 
      }

      public RoundResult PlayGaround(){
      // Player1 Choice
      /*
        ----choices
        HumanPlayer player1 = new HumanPlayer();
        Choice p1 = player1.GetChoice();
        ComputerPlayer player2 = new ComputerPlayer();
        Choice p2 = player2.GetChoice();
      */
        Choice p1 = _player1.GetChoice();
        Choice p2 = _player2.GetChoice();
        
        Console.WriteLine($"p1:{p1.ToString()}, p2:{p2.ToString()}"); 
       if (p1 == p2){
        return RoundResult.Draw;
       }

       if((p1 == Choice.ROCK && p2 == Choice.SCISSORS) 
       || (p1 == Choice.PAPER && p2 == Choice.ROCK) ||
       (p1 == Choice.SCISSORS && p2 == Choice.PAPER)
       ){
        return RoundResult.Player1Win;
       }
        return RoundResult.Player2Win;
      }
    }

  public enum Choice {
    ROCK,
    PAPER,
    SCISSORS
  }

  public enum RoundResult {
    Player1Win,
    Player2Win,
    Draw
  }
}