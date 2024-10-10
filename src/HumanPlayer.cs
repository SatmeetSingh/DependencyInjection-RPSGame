using System;

namespace DependencyInjection.src
{
  public class HumanPlayer :IPlayer 
  {
     public Choice GetChoice(){
        Choice p1;
        do {
           Console.Write("Enter Choice: (R)ock ,(P)aper ,(S)cissors :");
           string input = Console.ReadLine().ToUpper();
           if(input == "R"){
            p1 = Choice.ROCK;
            break;
           } else if (input == "P"){
            p1 = Choice.PAPER; 
            break;
           } else if( input == "S"){
            p1 = Choice.SCISSORS;
            break;
           } else {
            Console.WriteLine("Invalid string ");
           }
        } while(true);

        return p1;
     }
  }
}
