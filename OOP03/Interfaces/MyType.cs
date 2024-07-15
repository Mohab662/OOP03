using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Interfaces
{
    internal class MyType : IMyType
    {
        #region Properties
        public int Age { get; set; } // Automatic Property 
        #endregion

        #region Methods
        public void MyFunc()
        {
            Console.WriteLine("Hello Mohab!");
        }
        public void MyTypeFunc()
        {
            Console.WriteLine("Hello");
        } 
        #endregion


    }
}
