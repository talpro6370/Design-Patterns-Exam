using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Computers
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        protected override void PreperGraphicCard()
        {
            computer.PreperGraphicCard("Best graphic card has been installed!");
        }

        protected override void PreperMBoard()
        {
            computer.PreperMBoard("Regular mother-board has been installed!");
        }

        protected override void PreperMemoryCards()
        {
            computer.PreperMemoryCards("64Gb Ram + 2T SSD installed!");
        }

        protected override void PreperPackage()
        {
            computer.PreperPackage("Gaming package has been installed!");
        }
        protected override void PreperCore()
        {
            computer.PreperCore("Intel new gen core has been installed!");
        }
    }
}
