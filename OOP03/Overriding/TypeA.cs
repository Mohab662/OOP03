using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Overriding
{
    public class TypeA
    {
        #region Properties    
        public int A { get; set; } 

        #endregion

        #region Constractors
        public TypeA(int _a)
        {
            A = _a;
        } 
        #endregion

        #region Methods
        public void MyFunction01()
        {
            Console.WriteLine("I Am Base");
        }
        public virtual void MyFunction02()
        {
            Console.WriteLine($"Type : A : {A}");
        } 
        #endregion

    }
}
