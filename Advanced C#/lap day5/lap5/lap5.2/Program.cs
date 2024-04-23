namespace lap5._2
{
    internal class Program
    {
        static void Swap<h1>(ref h1 x , ref h1 y)
        {
            h1 temp = x;
            x= y;
            y= temp;

        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap<int>(ref a, ref b);
            double d1 = 5.2, d2 = 10.3;
            Swap<double>(ref d1, ref d2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
