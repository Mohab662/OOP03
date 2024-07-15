using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Overriding
{
    internal class TypeE : TypeD
    {
        #region Properties
        public int E { get; set; }
        #endregion

        #region Constractors
        public TypeE(int _A, int _B, int _C, int _D , int _E) : base(_A, _B, _C , _E)
        {
            E = _E;
        }
        #endregion

        #region Methods
        public new void MyFunction01()
        {
            Console.WriteLine("I Am Child");
        }

        public override void MyFunction02()
        {
            Console.WriteLine($"Type  E : {E}");
        }

        #endregion
    }
}
