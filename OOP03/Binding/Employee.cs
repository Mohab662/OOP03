using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Binding
{
    internal class Employee // container
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; } 
        #endregion

        #region Methods
        public void MyFunction01()
        {
            Console.WriteLine("I am employee");
        }
        public virtual void MyFunction02()
        {
            Console.WriteLine($"Id : {Id} , Name : {Name} , Age : {Age}");
        } 
        #endregion
    }
}
