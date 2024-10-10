// See https://aka.ms/new-console-template for more information
using DependencyInjection.src;

Console.WriteLine("Hello, World!");

GameManager game = new GameManager(new HumanPlayer(),new ComputerPlayer());

do{
   RoundResult result = game.PlayGaround();
   if (result == RoundResult.Player1Win){
      Console.WriteLine("Player 1 Wins");
   } else if (result == RoundResult.Player2Win){
      Console.WriteLine("Player 2 Wins");
   } else {
    Console.WriteLine("Draw");
   }

   Console.Write("Play Again Press Y: ");
}while(Console.ReadLine().ToUpper() == "Y");