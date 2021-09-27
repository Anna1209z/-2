using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            User exampler2 = new User();
            Console.WriteLine("Ввести логiн:");
            exampler2.Login = Console.ReadLine();
            Console.WriteLine("Ввести iм'я:");
            exampler2.Login = Console.ReadLine();
            Console.WriteLine("Ввести прiзвище:");
            exampler2.Surname = Console.ReadLine();
            Console.WriteLine("Ввести вік:");
            exampler2.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Данi користувача: {exampler2.Login},{exampler2.Name},{exampler2.Surname},{exampler2.Age}");
            exampler2.Date();
            Console.ReadLine();


        }
    }
    class User
    {
        private string login, name, surname;
        private int age;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public readonly DateTime date = new DateTime(2021, 09, 12);
        public void Date()
        {
            Console.WriteLine($"Date --- {date}");
        }




    }
}
