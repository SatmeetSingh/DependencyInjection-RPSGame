using System;

namespace DependencyInjection.src
{
  public class ComputerPlayer:IPlayer
  {
      public Random ran = new Random();
      public Choice GetChoice(){
        Choice p2 = (Choice)ran.Next(1,3);
        return p2;
      }
  }
}