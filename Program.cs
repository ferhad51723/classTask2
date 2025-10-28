using Interfaces;
using System.Linq;
class Program
{
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Hav-hav");
        }

        public void Move()
        {
            Console.WriteLine("Dog runs");
        }
    }

    class Bird : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cik-cik");
        }

        public void Move()
        {
            Console.WriteLine("Bird flies");
        }
    }

    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car startted");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }
    }

    class Employee
    {
        public string Name { get; set; }

        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("error");
                    return;
                }
                if (!char.IsUpper(value[0]) || !value.All(char.IsLetter))
                {
                    Console.WriteLine("error");
                    return;
                }
                surname = value;
            }
        }

        public Employee(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
        }
    }

    class Department
    {
        public string name;
        private int EmployeeLimit;
        private int SalaryLimit;
        private Employee[] Employees = new Employee[10];
        private int salary;
        public int Salary 
        {
            get
            {
                return salary;
            }
            set
            {
                if(value < 250)
                {
                    Console.WriteLine("Salary 250 boyuk olmalidir");
                    return;
                }
                salary = value;
            }
        }
        private int employeeCount = 0;
        internal void AddEmployee(Employee employee)
        {
            Employees[employeeCount] = employee;
            employeeCount++;
        }

    }


    static void Main(string[] args)
    {
        
    }
}







