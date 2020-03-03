using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Computers
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer GetComputer()
        {
            if (computer == null)
                throw new ComputerNotReadyException("Computer is not ready...");

            return computer;
        }

        public void BuildComputer()
        {
            this.computer = new Computer();
            PreperPackage();
            PreperMBoard();
            PreperCore();
            PreperGraphicCard();
            PreperMemoryCards();
            
        }
        protected abstract void PreperPackage();
        protected abstract void PreperMBoard();
        protected abstract void PreperGraphicCard();
        protected abstract void PreperMemoryCards();
        protected abstract void PreperCore();
    }
}
