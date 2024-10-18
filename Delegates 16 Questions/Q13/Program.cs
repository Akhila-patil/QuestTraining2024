using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    internal class Program
    {
        abstract class Appliance
        {
            public abstract void TurnOn();
        }

        class Fan : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Fan turned on !!!!");
            }
        }
        static void Main(string[] args)
        {
            Appliance fan = new Fan();
            fan.TurnOn();

        }
    }
}
