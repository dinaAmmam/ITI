namespace day6
{
    internal class Program
    {
        static bool Cond1(string s)
        {
            return ( s.Length > 3 && s.Length<10 );
        }
        static void Main(string[] args)
        {
            List<string> list = ["Ahmed", "Aly", "mahmoud", "sarah", "tamer"];
            List<string> res=list.FindAll(Cond1);
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            res = list.FindAll(delegate (string s) { return s.StartsWith("s"); });
            Console.WriteLine("=========");
            foreach (string s in res)
                Console.WriteLine(s);
            res = list.FindAll(s => s.Contains("ah"));
            Console.WriteLine("=========");
            foreach(string s in res)
                Console.WriteLine(s);

        }
    }
}
