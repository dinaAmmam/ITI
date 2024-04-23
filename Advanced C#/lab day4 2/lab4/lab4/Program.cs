namespace lab4
{
  /*  class oddSeries {
        int current = 1;
        public int update(){ 
            int x= current;
            current += 2;
            return x;
        }
    }

    class evenSeries {
        int current = 0;
        public int update()
        {
            int x = current;
            current += 2;
            return x;
        }
    }
    class FibonanciiSeries { 
        int current = 1;
        int pre = 0;
        public int update()
        {
           int x = pre + current;
            pre = current;
            current = x;
            
            
            return x;
        }
    }*/
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            //series
            /* oddSeries o1 = new oddSeries();
             Console.WriteLine(o1.update());
             Console.WriteLine(o1.update());
             Console.WriteLine(o1.update());*/

            /* evenSeries e1 = new evenSeries();
             Console.WriteLine(e1.update());
             Console.WriteLine(e1.update());
             Console.WriteLine(e1.update());*/

            /*FibonanciiSeries f1 = new FibonanciiSeries();
            Console.WriteLine(f1.update());
            Console.WriteLine(f1.update());
            Console.WriteLine(f1.update());
            Console.WriteLine(f1.update());
            Console.WriteLine(f1.update());
            Console.WriteLine(f1.update());*/

            //employee
            /*HireDate h = new HireDate(1 ,1, 2010);
            employee e = new employee(1, "Aly", 3000, gender.male, h);
            Console.WriteLine(e.ToString());*/
            // arr of emp
            employee[] emps = new employee[3];
            int id;
            string name;
            float salary;
            HireDate empDate;
            gender g;

            for (int i = 0; i < emps.Length; i++)
            {
                Console.WriteLine($"Employee Number = {i + 1} Data\n");
                Console.Write("Id = ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name = ");
                name = Console.ReadLine();
                Console.Write("Salary = ");
                salary = float.Parse(Console.ReadLine());
                Console.WriteLine("Gender");
                /* try { g = (gender)Enum.Parse(typeof(gender), Console.ReadLine()); }
                 catch (ArgumentException)
                 {
                     Console.WriteLine("Something went wrong.");
                 }*/
                g = (gender)Enum.Parse(typeof(gender), Console.ReadLine());  // not boxing?
                Console.WriteLine("Hire Date ");
                empDate = new HireDate();
                Console.Write("Day = ");
                empDate.Day = (int.Parse(Console.ReadLine()));
                Console.Write("Month = ");
                empDate.Month = (int.Parse(Console.ReadLine()));
                Console.Write("Year = ");
                empDate.Year = (int.Parse(Console.ReadLine()));
                emps[i] = new employee(id, name, salary, g,empDate);
                Console.WriteLine("----------------------------------");
            }
            Array.Sort(emps);
            for (int i = 0; i < emps.Length; i++)
            {
                Console.WriteLine(emps[i].ToString());
                Console.WriteLine("----------------------------------");
                
            }

        }
    }
}
