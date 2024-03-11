using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета");
            int numint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            int summa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите фИО");
            string name = Console.ReadLine();
            BankAccount<int> bankAccount1 = new BankAccount<int>(numint, summa, name);
            Console.WriteLine(bankAccount1.GetInfo());

            Console.WriteLine("Введите номер счета");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            summa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите фИО");
            name = Console.ReadLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>(numString, summa, name);
            Console.WriteLine(bankAccount2.GetInfo());

            //BankAccount<int> bankAccount1 = new BankAccount<int>();
            //bankAccount1.Input();
            //Console.WriteLine(bankAccount1.GetInfo());

            //BankAccount<string> bankAccount2 = new BankAccount<string>();
            //bankAccount2.Input();
            //Console.WriteLine(bankAccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
