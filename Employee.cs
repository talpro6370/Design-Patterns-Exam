using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_emp
{
    public class Employee
    {
        private int id { set; get; }
        private string name { set; get; }
        private int age { set; get; }
        private int salary { set; get; }

        public Employee()
        {

        }
        public Employee(int id , string name, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"id: {id}   name: {name}   age: {age}   salary: {salary}";
        }
    }
}
