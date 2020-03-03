using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Computers
{
    class OfficeComputerBuilder : ComputerBuilder
    {
        protected override void PreperGraphicCard()
        {
            computer.PreperGraphicCard("Low performance grapic card has been installed!");
        }

        protected override void PreperMBoard()
        {
            computer.PreperMBoard("Medium mother - board has been installed!");
        }

        protected override void PreperMemoryCards()
        {
            computer.PreperMemoryCards("8GB Ram + 256Gb Hdd installed!");
        }

        protected override void PreperPackage()
        {
            computer.PreperPackage("Regular package has been installed!");
        }
        protected override void PreperCore()
        {
            computer.PreperCore("I3 core has been installed!");
        }
    }
}
