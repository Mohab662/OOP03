namespace OOP03
{
    internal class Program
    {

        #region Method Overloading
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
            #region Overloading Test
            int Result = Sum(1, 2);
            Console.WriteLine(Result); 
            #endregion


        }
    }
}
