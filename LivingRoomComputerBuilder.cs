using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Computers
{
    public class LivingRoomComputerBuilder : ComputerBuilder
    {
        protected override void PreperGraphicCard()
        {
            computer.PreperGraphicCard("Strong graphic card has been installed!");
        }

        protected override void PreperMBoard()
        {
            computer.PreperMBoard("Very thin Mother-Board has been installed!");
        }

        protected override void PreperMemoryCards()
        {
            computer.PreperMemoryCards("8Gb Ram + 500Gb Hdd installed!");
        }

        protected override void PreperPackage()
        {
            computer.PreperPackage("Very thin package has been installed!");
        }
        protected override void PreperCore()
        {
            computer.PreperCore("I5 core has been installed!");
        }
    }
}
