using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Overriding
{
    internal class TypeC : TypeB
    {
        #region Properties
        public int C { get; set; } 
        #endregion

        #region Constractors
        public TypeC(int _A, int _B, int _C) : base(_A, _B)
        {
            C = _C;
        } 
        #endregion

        #region Methods
        public new void MyFunction01()
        {
            Console.WriteLine("I Am Child");
        }

        public override void MyFunction02()
        {
            Console.WriteLine($"Type  C : {C}");
        }
        
        #endregion

    }
}
