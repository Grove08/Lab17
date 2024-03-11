using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class BankAccount<T>
    {
        private T accountNum { get; set; }

        private int Summa { get; set; }

        private string Name { get; set; }


        public BankAccount(T num, int summa, string name)
        {
            accountNum = num;
            Name = name;
            Summa = summa;
        }

        public string GetInfo()
        {
            return $"{accountNum} {Summa} {Name}";
        }

        //public void Input()
        //{
        //    Console.WriteLine("Введите номер счета");
        //    accountNum = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        //    Console.WriteLine("Введите баланс");
        //    Summa = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Введите ФИО");
        //    Name = Console.ReadLine();

        //}

    }
}
