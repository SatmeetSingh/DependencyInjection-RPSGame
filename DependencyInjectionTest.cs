using DependencyInjection.src;
using NUnit.Framework;

namespace DependencyInjection
{
    public class RPSTest
    {
        [Test]
        public void RockBeatScissors(){
            GameManager gm = new GameManager(new ForcedPlayer(Choice.ROCK),new ForcedPlayer(Choice.SCISSORS));
            Assert.Equals(RoundResult.Player1Win ,gm.PlayGaround());
        }
    }

    public class ForcedPlayer :IPlayer
    {
        private Choice _choice;

        public ForcedPlayer(Choice choice){
            _choice = choice;
        }
            public Choice GetChoice(){
                return _choice; 
            }
    }
}