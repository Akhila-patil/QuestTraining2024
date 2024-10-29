using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CricketGame.Entities;

namespace CricketGame
{
    internal class CricketGame
    {
        public class GameLogic
        {
            private HumanPlayers Hpalyer;
            private ComputerPlayer Cplayer;
            int totalBalls = 0;

            public GameLogic(int balls=6)
            {
                Hpalyer = new HumanPlayers();
                Cplayer = new ComputerPlayer();
                totalBalls = balls;

            }

            public void PlayInnings(dynamic player)
            {
                for(int i=0;i<=totalBalls&& !player.IsOut; i++)
                {
                    int shot = player.PlayShot();
                    Console.WriteLine($"{player.Name} scored: {(shot == -1 ? "Out" : shot.ToString())}");
                }
                Console.WriteLine($"{ player.Name} Score: {player.Score }");


            }
        }

    }
}
