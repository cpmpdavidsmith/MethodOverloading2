namespace MethodOverloading
{
    public class Program
    {
        //-------------------------TEST AREA-------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 2));
            //Console.WriteLine(Add( 4.35, 2.65));
            //Console.WriteLine(Add(5, -4, true));
        }
        //----------------------METHOD OVERLOAD----------------------------------
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool currency)
        {
            int total = x + y;

            if ((total < 1 || total > 1) && true)
            {
                return $"{total} dollars";
            }
            else 
            {
                return $"{total} dollar";
            }
           
        }

    }
}
