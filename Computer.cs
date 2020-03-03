using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Computers
{
   public class Computer
    {
        private List<string> components = new List<string>();
        public Computer()
        {

        }
        public void PreperPackage(string package)
        {
            components.Add(package);
        }
        public void PreperMBoard(string mBoard)
        {
            components.Add(mBoard);
        }
        public void PreperGraphicCard(string graphicCard)
        {
            components.Add(graphicCard);
        }
        public void PreperMemoryCards(string memoryCard)
        {
            components.Add(memoryCard);

        }
        public void PreperCore(string core)
        {
            components.Add(core);

        }
        //public void Test()
        //{

        //}
    }
}
