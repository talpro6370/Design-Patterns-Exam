using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_emp
{
    public class Dbase
    {
        public struct employeesStructure:ICloneable
        {
            public List<Employee> employees { get; set; }

            public employeesStructure(List<Employee> emp)
            {
                this.employees = emp;
            }

            public object Clone()
            {
                return (employeesStructure)this.MemberwiseClone();
            }
            //public override string ToString()
            //{
            //    return $"{employees}";
            //}
        }
        

       
    }
}
