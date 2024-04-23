namespace lap4._2
{
    internal class Program
    {
        /*public static employee[] FillEmployees()
        {
            employee[] employees = new employee[3];
            //Console.WriteLine("receiving employee data : ");

            int _id;
            string _name;
            float _salery;
            Hiredate _hiredate;
            gender _gender;
            int _day;
            int _month;
            int _year;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"employee {i + 1} data:");
                Console.WriteLine("id =");
                _id = int.Parse(Console.ReadLine());
                Console.WriteLine($"name =");
                _name = Console.ReadLine();
                Console.WriteLine("salery =");
                _salery = float.Parse(Console.ReadLine());
                Console.WriteLine("day =");
                _day = int.Parse(Console.ReadLine());
                Console.WriteLine("month=");
                _month = int.Parse(Console.ReadLine());
                Console.WriteLine("year=");
                _year = int.Parse(Console.ReadLine());
                _hiredate = new Hiredate(_day,_month, _year);
                Console.WriteLine("gender (male/female) =");
                _gender = (gender)Enum.Parse(typeof(gender), Console.ReadLine(), true);
                employees[i] = new employee(_id,_salery, _gender, _name, _hiredate);

            }
            return employees;
        }*/




        static void Main(string[] args)
        {
            employee[] employees = new employee[3];
            int _id;
            string _name;
            float _salary;
            Hiredate _hiredate;
            gender _gender;
            int _day;
            int _month;
            int _year;

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"employee {i + 1} data:");

                try
                {
                    Console.WriteLine("id =");
                    _id = int.Parse(Console.ReadLine());

                    Console.WriteLine($"name =");
                    _name = Console.ReadLine();

                    if (int.TryParse(_name, out _))
                    {
                        throw new FormatException("Invalid input. Name cannot be an integer.");
                    }

                    Console.WriteLine("salary =");
                    _salary = float.Parse(Console.ReadLine());

                    Console.WriteLine("day =");
                    _day = int.Parse(Console.ReadLine());
                    Console.WriteLine("month=");
                    _month = int.Parse(Console.ReadLine());
                    Console.WriteLine("year=");
                    _year = int.Parse(Console.ReadLine());
                    _hiredate = new Hiredate(_day, _month, _year);

                    Console.WriteLine("Gender (male/female) =");
                    _gender = (gender)Enum.Parse(typeof(gender), Console.ReadLine(), true);

                    employees[i] = new employee(_id, _salary, _gender, _name, _hiredate);
                }

                catch (FormatException e)
                {
                    Console.WriteLine($"Error: {e.Message}. Please enter a valid input.");
                    i--;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"Error: {e.Message}. Please enter a valid input within the allowed range.");
                    i--;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Error: {e.Message}. Please enter a valid gender (male/female).");
                    i--;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"An unexpected error occurred: {e.Message}");
                    i--;
                }



            }
            Array.Sort(employees);
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
                Console.WriteLine("-------------");
            }











            //////////////////////////////////////////////
            /*employee[] employees = new employee[3];
            //Console.WriteLine("receiving employee data : ");

            int _id;
            string _name;
            float _salery;
            Hiredate _hiredate;
            gender _gender;
            int _day;
            int _month;
            int _year;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"employee {i + 1} data:");
                Console.WriteLine("id =");
                _id = int.Parse(Console.ReadLine());
                Console.WriteLine($"name =");
                _name = Console.ReadLine();
                Console.WriteLine("salery =");
                _salery = float.Parse(Console.ReadLine());
                Console.WriteLine("day =");
                _day = int.Parse(Console.ReadLine());
                Console.WriteLine("month=");
                _month = int.Parse(Console.ReadLine());
                Console.WriteLine("year=");
                _year = int.Parse(Console.ReadLine());
                _hiredate = new Hiredate(_day, _month, _year);
                Console.WriteLine("gender (male/female) =");
                _gender = (gender)Enum.Parse(typeof(gender), Console.ReadLine(), true);
                employees[i] = new employee(_id, _salery, _gender, _name, _hiredate);
                /*employee[] employees = new employee[5];

                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"employee {i + 1} data:");

                    int _id;
                    try
                    {
                        Console.WriteLine("id =");
                        _id = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input for id. Please enter a valid integer.");
                        i--; // Decrement i to re-enter data for the same employee
                        continue;
                    }

                    string _name;
                    try
                    {
                        Console.WriteLine($"name =");
                        _name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(_name))
                        {
                            throw new ArgumentException("Name cannot be empty or whitespace.");
                        }
                        if (int.TryParse(_name, out _))
                        {
                            throw new FormatException("Invalid input. Name cannot be an integer.");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        i--; // Decrement i to re-enter data for the same employee
                        continue;

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        i--; // Decrement i to re-enter data for the same employee
                        continue;
                    }

                    float _salary;
                    try
                    {
                        Console.WriteLine("salary =");
                        _salary = float.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input for salary. Please enter a valid float.");
                        i--; // Decrement i to re-enter data for the same employee
                        continue;
                    }

                    int _day, _month, _year;
                    try
                    {
                        Console.WriteLine("day =");
                        _day = int.Parse(Console.ReadLine());

                        Console.WriteLine("month=");
                        _month = int.Parse(Console.ReadLine());

                        Console.WriteLine("year=");
                        _year = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input for date. Please enter a valid integer.");
                        i--; // Decrement i to re-enter data for the same employee
                        continue;
                    }

                    Hiredate _hiredate = new Hiredate(_day, _month, _year);

                    Console.WriteLine("gender (male/female) =");
                    gender _gender;
                    try
                    {
                        _gender = (gender)Enum.Parse(typeof(gender), Console.ReadLine(), true);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Invalid input for gender. Please enter 'male' or 'female'.");
                        i--; // Decrement i to re-enter data for the same employee
                        continue;
                    }

                    //employees[i] = new employee(_id, _salary, _gender, _name, _hiredate);
                }*/


            //Console.WriteLine(FillEmployees());
            //Printemployees(FillEmployees());
            //Hiredate hd = new Hiredate(10, 2, 2010);
            //Hiredate hd2 = new Hiredate(2, 2, 2001);
            //Hiredate hd3 = new Hiredate(3, 2, 2003);
            //Hiredate hd4 = new Hiredate(4, 2, 2002);
            //Hiredate hd5 = new Hiredate(5, 2, 2000);
            //employee e1 = new employee(1, 500.0f, gender.male, "mohamed", hd);
            //employee e2 = new employee(2, 500.0f, gender.female, "dina", hd2);
            //employee e3 = new employee(3, 500.0f, gender.male, "mohamed", hd3);
            //employee e4 = new employee(0, 500.0f, gender.male, "mohamed", hd4);
            //employee e5 = new employee(10, 500.0f, gender.male, "omar", hd5);



            //  Hiredate[] hds = { hd, hd2, hd3, hd4, hd5 };
            // employee[] employees = { e1, e2, e3, e4, e5 };
            // Array.Sort(employees);

            //foreach (var item in employees)
            //{
            //Console.WriteLine(item.ToString());
            //}




        }
    }
    }


