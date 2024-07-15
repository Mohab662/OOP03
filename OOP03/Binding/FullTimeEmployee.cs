using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    internal class FullTimeEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; } 
        #endregion

        #region Methods
        public new void MyFunction01()
        {
            Console.WriteLine("I am FullTime employee");
        }
        public override void MyFunction02()
        {
            Console.WriteLine($"Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}");
        } 
        #endregion
    }
}
