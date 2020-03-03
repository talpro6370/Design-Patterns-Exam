using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Control : IMonitor, IControl
    {
        private int totalGas = 40;
        private string location = "Haifa";
        public void RaiseSpeed()
        {
            if (totalGas>0)
            {
                totalGas -= 5;
            }
            Console.WriteLine("I drive so fast now!!");

        }

        public int ShowGasStatus()
        {
            return totalGas;
        }

        public string ShowLocation()
        {
            return location;
        }

        public void SlowDown()
        {
            Console.WriteLine("Slowly but sure..");
        }

        public void StartDrive()
        {
            Console.WriteLine("Have a good luck!");
        }

        public void TurnLeft()
        {
            location = "Netanya";
            Console.WriteLine("Turning left..");
        }

        public void TurnRight()
        {
            location = "Rishon";
            Console.WriteLine("Turning right..");
        }
    }
}
