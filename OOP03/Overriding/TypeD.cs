using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Overriding
{
    internal class TypeD : TypeC
    {
        #region Properties
        public int D { get; set; }
        #endregion

        #region Constractors
        public TypeD(int _A, int _B, int _C , int _D) : base(_A, _B , _C)
        {
            D = _D;
        }
        #endregion

        #region Methods
        public new void MyFunction01()
        {
            Console.WriteLine("I Am Child");
        }

        public virtual new void MyFunction02()
        {
            Console.WriteLine($"Type  D : {D}");
        }

        #endregion
    }
}
