using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Overriding
{
    internal class TypeB : TypeA
    {
        #region Properties
        public int B { get; set; } 

        #endregion

        #region Constractors
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        } 
        #endregion

        #region Methods
        public new void MyFunction01()
        {
            Console.WriteLine("I Am Child");
        }

        public override void MyFunction02()
        {
            Console.WriteLine($"Type  B : {B}");
        } 
        public void print()
        {
            Console.WriteLine("hello!");
        }
        #endregion

    }
}
