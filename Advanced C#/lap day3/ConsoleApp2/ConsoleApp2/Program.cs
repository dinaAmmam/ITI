namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            complex com = new complex(10,5);
            complex c2 = new complex(10,2);
            complex c3 = com + c2;
            complex c4 = com * c3;
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(com.ToString());



            
        }
    }
}
