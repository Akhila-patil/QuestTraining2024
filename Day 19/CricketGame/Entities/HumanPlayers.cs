using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame.Entities
{
    internal class HumanPlayers
    {
        private static readonly List<int> Options = new List<int> { 0, 1, 2, 3, 4, 6, -1 };
        public string Name { get; set;}
        public int Score { get; set; }
        public bool IsOut { get; set; }

        public HumanPlayers(string name="Human")
        {
            Name = name;
            Score = 0;
            IsOut = false;

        }

        public int PlayShot()
        {
            Console.WriteLine("Enter the Shot (0=dot,1=Single,2=Doubles,3=ThreeRun,4=Four,6=Six,-1=Out)");
            if(int.TryParse(Console.ReadLine(),out int shot) && Options.Contains(shot))
            {
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
            Console.WriteLine("Invalid shot");
            IsOut = true;
            return -1;
        }

    }
}
