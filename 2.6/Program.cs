using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter money = new Converter(26.62, 29.61, 0.41, 4);
            Console.WriteLine("Курси валют: ");
            Console.WriteLine("Долар: {0}, \nЄвро: {1}, \nРубль: {2}, \nВведена сума: {3}", money.GetUsd(), money.GetEur(), money.GetRub(), money.GetHrn());
            money.MethodUsd();
            Console.WriteLine(money.MethodUsd());
            Console.ReadKey();
        }
    }
    class Converter
    {
        double hrn;
        public void SetHrn(double value)
        {
            hrn = value;
        }
        public double GetHrn()
        {
            return hrn;
        }
        double usd;
        public double GetUsd()
        {
            return usd;
        }
        double eur;
        public double GetEur()
        {
            return eur;
        }
        double rub;
        public double GetRub()
        {
            return rub;
        }
        public double nUsd;
        public void SetNUsd(double value)
        {
            nUsd = value;
        }
        public double MethodUsd()
        {
            return nUsd;
        }
        static double MethodUsd(double usd, double hrn, double nUsd)
        {
            usd = 26.62;
            nUsd = usd * hrn;
            return nUsd;
        }
        public Converter(double usd, double eur, double rub, double hrn)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            Console.Write("B:");
            this.hrn = Convert.ToDouble(Console.ReadLine());

        }
    }
}
