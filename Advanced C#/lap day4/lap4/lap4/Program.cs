namespace lap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeriesConsumer consumer = new SeriesConsumer();
            odd odd = new odd();
            even even = new even();
            consumer.o1 = even;

            consumer.o1 = odd;
            consumer.PrintNextNumber();//0
            consumer.PrintNextNumber();//
            consumer.PrintNextNumber();
            consumer.PrintNextNumber();
            consumer.PrintNextNumber();//2
            Console.WriteLine("==========");
            fib f1 = new fib();
            consumer.o1 = f1;
            consumer.PrintNextNumber();//1
            consumer.PrintNextNumber();//1
            consumer.PrintNextNumber();//2
            consumer.PrintNextNumber();//3
            consumer.PrintNextNumber();//5
            consumer.PrintNextNumber();//8
        }
    }
}
