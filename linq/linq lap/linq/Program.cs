namespace linq
{
    public static class operations
    {
        public static int sum(this int num1 , int num2 ) => num1 + num2;
        public static int sub(this int num1, int num2) => num1 - num2;
        public static int mul(this int num1, int num2) => num1 * num2;
        public static int div(this int num1, int num2) => num1 / num2;




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int sum = a.sum(b);
            int mul = a.mul(b);

            Console.WriteLine(  $"sum:{ sum}");
            Console.WriteLine($"mul:{mul}");
        }
    }
}
