namespace MethodOverloading
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));


            Console.WriteLine(Add(5, 7, true));


            Console.WriteLine(Add(-6, 3, true));
        }


        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal decimal1, decimal decimal2)
        {
            return decimal1 + decimal2;
        }

        public static string Add(int num1, int num2, bool WithDollars)
        {
            if (WithDollars && (num1 + num2 != 1))
            {
                return $"{num1 + num2} dollars";
            }
            else if (WithDollars && (num1 + num2) == 1)
            {
                return ($"{num1 + num2} dollar");
            }
            else
            {
                return $"{num1 + num2}";
            }

        }
    }
}

