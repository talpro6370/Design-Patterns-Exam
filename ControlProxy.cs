using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ControlProxy:IMonitor
    {
        public ControlProxy()
        {

        }
        public int ShowGasStatus()
        {
            IMonitor control = new Control();
            return control.ShowGasStatus();
        }
        public string ShowLocation()
        {
            IMonitor control = new Control();
            return control.ShowLocation();
        }
    }
}
