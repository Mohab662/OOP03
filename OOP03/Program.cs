using OOP03.Overriding;

namespace OOP03
{
    internal class Program
    {

        #region Polymorphism - Overloading
        public static int Sum(int x, int y)
        {
            return x * y;
        }
        public static int Sum(int x, int y, int z)
        {
            return x * y;
        }
        public static int Sum(int x, int y, int m, int z)
        {
            return x * y;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Overloading
            //int Result = Sum(1, 2);
            //Console.WriteLine(Result);
            #endregion


            #region Overriding

            //TypeA typeA = new TypeA(5);
            //typeA.A = 2;
            //typeA.MyFunction01();
            //typeA.MyFunction02();

            //TypeB typeB = new TypeB(6,4);
            //typeB.A = 4;
            //typeB.B = 1;
            //typeB.MyFunction01();
            //typeB.MyFunction02();

            #endregion


            #region Binding
            //Binding
            //reference from parent = object from child

            // TypeA RefBase = new TypeB(1, 2); // Binding

            //// RefBase.A = 3; // valid
            ////// RefBase.B = 4; // invalid

            //// RefBase.MyFunction01(); // new // I am base >> static binded method
            //// RefBase.MyFunction02(); // override // B = 2 >> daynamic binded method

            //RefBase = new TypeC(1, 2, 3);
            //TypeB typeB = (TypeB)RefBase; // Casting [UsSafe]

            #endregion


        }
    }
}
