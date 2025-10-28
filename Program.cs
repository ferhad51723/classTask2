using Interfaces;
using System.Linq;
class Program
{
    abstract class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, string position, decimal baseSalary)
        {
            Name = name;
            Position = position;
            BaseSalary = baseSalary;
        }

        public abstract decimal CalculateSalary();
        public abstract void DisplayInfo();

        public virtual decimal GiveBonus(decimal amount)
        {
            return BaseSalary += amount;
            
        }
}

    class Developer : Employee,IWorkable,IReportable
    {
        public int ProjectCount { get; set; }

        public override decimal CalculateSalary()
        {
            return BaseSalary + (ProjectCount * 200);
;        }
        public Developer(string name, decimal baseSalary, int projectCount)
        : base(name, "Developer", baseSalary)
        {
            this.ProjectCount = projectCount;
        }

        public void Work()
        {
            Console.WriteLine();
        }

        public void GenerateReport(string str)
        {
            Console.WriteLine();
        }

        public void ShowReport()
        {
            Console.WriteLine();
        }

        public override void DisplayInfo()
        {
            
        }

    }

    class Manager : Employee, IWorkable, IReportable
    {
        public Manager(string name, decimal baseSalary, int teamSize)
        : base(name, "Manager", baseSalary)
        {
            this.TeamSize = teamSize;
        }

        public int TeamSize { get; set; }
        public override decimal CalculateSalary()
        {
            return BaseSalary + (TeamSize * 200);
            ;
        }

        public void Work()
        {
            Console.WriteLine();
        }

        public void GenerateReport(string str)
        {
            Console.WriteLine(str);
        }

        public void ShowReport()
        {
            Console.WriteLine();
        }

        public override void DisplayInfo()
        {

        }
    }

    class Intern : Employee, IWorkable, IReportable
    {

        public Intern(string name, decimal baseSalary)
        : base(name, "Intern", baseSalary)
        {
        }
        public override decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public void Work()
        {
            Console.WriteLine();
        }

        public void GenerateReport(string str)
        {
            Console.WriteLine(str);
        }

        public void ShowReport()
        {
            Console.WriteLine();
        }

        public override void DisplayInfo()
        {
            
        }
    }

    static void Main(string[] args)
    {
        Developer developer_1 = new Developer("Namiq",4600,3);
        Manager manager_1 = new Manager("Akif", 5750, 2);
        Intern inter_1 = new Intern("Ali", 800);

        developer_1.GenerateReport("Completed 3 new modules");
        developer_1.Work();
        developer_1.CalculateSalary();
        developer_1.GiveBonus(3);

        manager_1.GenerateReport("eam performance improved by 20%");
        manager_1.Work();
        manager_1.CalculateSalary();
        manager_1.GiveBonus(3);

        inter_1.GenerateReport("Learned basics of C#");
        inter_1.Work();
        inter_1.CalculateSalary();
        inter_1.GiveBonus(3);
    }
}








