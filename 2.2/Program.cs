using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть значення 1 сторони:");
            string sside1 = Console.ReadLine();
            double side1 = Convert.ToDouble(sside1);
            Console.WriteLine("Введiть значення 2 сторони:");
            string sside2 = Console.ReadLine();
            double side2 = Convert.ToDouble(sside2);
            Rectangle rect = new Rectangle(side1, side2);
            rect.AreaCalculator();
            rect.PerimeterCalculator();
            Console.WriteLine($"Площа прямокутника: {rect.AreaCalculator()};\nПериметр прямокутника:{ rect.PerimeterCalculator()} ;");
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        private double side1;
        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                side1 = value;
            }
        }
        private double side2;
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                side2 = value;
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }
        private double area;
        public double Area
        {
            get
            {
                return area;
            }

        }
        public double PerimeterCalculator()
        {
            double perimeter = 2 * (side1 + side2);
            return perimeter;
        }
        private double perimeter;
        public double Perimeter
        {
            get
            {
                return perimeter;
            }

        }
    }
}
