using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(2500, "Покупець", "Провайдер");
            invoice.Article = "0203030";
            invoice.Quantity = 5;
            invoice.Info();
            Console.ReadKey();
        }
    }
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }
        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public double Method1(double nds) // С ндс 
        {
            double result1 = account * (1 - nds / 100.0);
            result1 *= quantity;
            return result1;
        }
        public double Method2() // Без ндс 
        {
            double result2 = account * quantity;
            return result2;
        }
        public void Info()
        {
            Console.WriteLine($"Клiєнт - {customer},Провайдер - {provider}, Сума - {account}, Артикул - {article}");
            Console.WriteLine($"Сума с ндс - {Method1(0.2)}, Сума без ндс - {Method2()}");
        }
    }
}
