using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Петров", "Володимир", "директор", 7);
            Employee employee2 = new Employee("Кобец", "Степан", "зам директора", 11);
            Employee employee3 = new Employee("Гумпер", "Свiтлана", "вчитель", 2);
            employee1.MethodInfo();
            employee2.MethodInfo();
            employee3.MethodInfo();
            Console.ReadKey();
        }
    }
    class Employee
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public Employee(string surname, string name, string position, int exp)
        {
            this.SurName = surname;
            this.Name = name;
            this.Position = position;
            this.Experience = exp;
        }
        public void Method()
        {
            int salary = 0;
            if (Position == "директор")
            {
                salary += 20000;
            }
            else if (Position == "зам директора")
            {
                salary += 18000;
            }
            else if (Position == "вчитель")
            {
                salary += 12000;
            }
            Console.WriteLine($"Зарплатня= {salary}");
        }
        public void MethodInfo()
        {
            Console.WriteLine($"{SurName}, {Name}, {Position},{Experience}");
            Method();

        }
    }
}
