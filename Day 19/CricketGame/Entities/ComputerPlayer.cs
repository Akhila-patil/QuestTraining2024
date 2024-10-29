using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame.Entities
{
    internal class ComputerPlayer
    {
        private static readonly Random random = new Random();
        private static readonly List<int> Options = new List<int> { 0,1,2,3,4,6,-1};

        private string Name { get; set; }
        private int Score { get; set; }
        private bool IsOut { get; set; }   
        
        public ComputerPlayer(string name = "Computer")
        {
            Name = name;
            Score = 0;
            IsOut = false;
        }

        public int  PlayShots()
        {
            int shot = Options[random.Next(Options.Count)];
            if (shot == -1)
            {
                IsOut = true;
            }
            else
            {
                Score += shot;
            }
            return shot;
        }


    }
}
