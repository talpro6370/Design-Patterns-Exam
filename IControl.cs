using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IControl
    {
        void StartDrive();
        void RaiseSpeed();
        void SlowDown();
        void TurnRight();
        void TurnLeft();
        

    }
}
