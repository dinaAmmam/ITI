namespace lap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myStack<int> s1 = new myStack<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            s1.Push(5);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());



            //Console.WriteLine(s1.ToString());
        }
    }
}
