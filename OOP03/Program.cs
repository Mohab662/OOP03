using OOP03.Binding;
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

        public static void ProcessEmp(Employee employee)
        {
            if (employee!=null)
            {
                employee.MyFunction01();
                employee.MyFunction02();
            }
        }

        //public static void ProcessEmp(FullTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.MyFunction01();
        //        employee.MyFunction02();
        //    }
        //}
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


            #region When U Need Binding
            //Employee fullTime = new FullTimeEmployee()
            //{
            //    Name = "mohab",
            //    Salary = 5000,
            //    Age = 21,
            //    Id = 123
            //}; // Binding
            //Employee partTime = new PartTimeEmployee()
            //{
            //    Name = "mohab",
            //    HourRate = 12,
            //    Age = 21,
            //    Id = 123
            //}; // Binding

            //Employee employee = new Employee(); // ref [parent] => object [parent]
            //FullTimeEmployee employee1 = new FullTimeEmployee(); // ref child => object [child]
            //PartTimeEmployee employee2 = new PartTimeEmployee(); // ref child => object [child]
            //Employee employee3 = new FullTimeEmployee(); // ref [parent] => object [child] Binding
            //Employee employee4 = new PartTimeEmployee(); // ref [parent] => object [child] Binding

            //ProcessEmp(employee1);
            //ProcessEmp(employee2);
            //ProcessEmp(employee3);
            //ProcessEmp(employee4);
            //ProcessEmp(partTime);
            //ProcessEmp(fullTime);
            ////fullTime.Name = "mohab";
            ////fullTime.Salary = 5000;
            ////fullTime.Age = 21;
            ////fullTime.Id = 123; 
            #endregion


            #region Practice On Binding
            ////////////// TypeA reference ////////////////
            //TypeA typeA = new TypeC(1, 3, 5);
            //typeA.A = 5; // valid
            //typeA.B; // invalid
            //typeA.C; // invalid

            //typeA.MyFunction01(); // I am base [static binding]
            //typeA.MyFunction02(); // [daynamic binding] C=3

            ////////////// TypeB reference ////////////////
            //TypeB typeB = new TypeC(1, 3, 5);
            //typeB.A = 5; // valid
            //typeB.B; // invalid
            //typeB.C; // invalid

            //typeB.MyFunction01(); // I am base [static binding]
            //typeB.MyFunction02(); // [daynamic binding] B=3

            TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            TypeC typeC = new TypeE(1, 2, 3, 4, 5);

            // indirect parent

            typeA.MyFunction02(); // bta3t E [daynamic binding]
            typeB.MyFunction02(); // bta3t E [daynamic binding]
            typeC.MyFunction02(); // bta3t E [daynamic binding]

            TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            typeD.MyFunction02(); // bta3t E [daynamic binding]

            #endregion


        }
    }
}
