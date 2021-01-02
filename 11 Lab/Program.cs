using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main()
        {
            List<string> mouths = new List<string>{ "January", "February", "March", "April",
                "May", "June", "July", "August", "September", "October", "November", "December" };

            var m1 = mouths.Where(m => m.Length == 4);//длина строки 4 
            var m2 = mouths.Where(m => (mouths.IndexOf(m) + 1 >= 6 && mouths.IndexOf(m) + 1 <= 8)//летние месяцы
                                                     || mouths.IndexOf(m) + 1 >= 1 && mouths.IndexOf(m) + 1 <= 2//январь, февраль
                                                     || mouths.IndexOf(m) + 1 == 12);//декабрь
            var m3 = mouths.OrderBy(m => m);//алфавитный порядок
            var m4 = mouths.Where(m => m.Contains("u") && m.Length <= 4);//есть u и длина строки больше 4

            Print<string>(m1);
            Print<string>(m2);
            Print<string>(m3);
            Print<string>(m4);

            List<Customer> customers = new List<Customer>
            {
                new Customer("Иван", "Иванов", 123321456, 125),
                new Customer("Петр", "Птров", 321321987, 170),
                new Customer("Адрей", "Адреев", 456654123, 50),
                new Customer("Зенон", "Позняк", 765123543, 250),
                new Customer("Илья", "Ильин", 890234654, 300),
                new Customer("Елена", "Иванова", 725123098, 180),
                new Customer("Алиса", "Селезнева", 543198342, 150),
                new Customer("Алекс", "Алексеев", 124543912, 100),
            };
            var c1 = customers.Select(c => c.Surname).OrderBy(c => c).ToList();//алфавитный порядок
            var c2 = customers.Where(c => c.CardNumber > 400000000 && c.CardNumber < 800000000);//номер карты в заданном интервале
            var c3 = customers.Where(c => (c.CardNumber == customers.Max(n => n.CardNumber)));//самый большой номер карты
            var c4 = customers.OrderByDescending(c => c.CardBalance).Take(5);//5 первых покупателей с максималной суммой на карте

            Print<string>(c1);
            Print<Customer>(c2);
            Print<Customer>(c3);
            Print<Customer>(c4);

            var c5 = customers.Take(6).Skip(3).OrderBy(c => c.FirstName).Where(c => c.FirstName.Length > 4).Select(c => c.FirstName);
            Print < string > (c5);
            List<int> list1 = new List<int> { 4, 5, 6 };
            List<int> list2 = new List<int> { 4, 5, 6 };

            var list = list1.Join(list2, a => a, b => b, (a, b) => a + b);
            Print<int>(list);
        }

        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (T member in collection)
            {
                Console.Write(member.ToString() + " ");
            }
            Console.WriteLine();
        }
    }

    class Customer
    {
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length > 0)
                {
                    firstName = value;
                }
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length > 0)
                {
                    surname = value;
                }
            }
        }

        public int CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value > 0)
                {
                    cardNumber = value;
                }
            }
        }
        public int CardBalance
        {
            get { return cardBalance; }
            set
            {
                if (value > 0 && value < 100000)
                {
                    cardBalance = value;
                }
            }
        }

        private string firstName;
        private string surname;
        private int cardNumber;
        private int cardBalance;

        //кострукторы
        public Customer(string FirstName, string surname, int CardNumber, int cardBalance)
        {
            this.FirstName = FirstName;
            this.surname = surname;
            this.CardNumber = CardNumber;
            this.cardBalance = cardBalance;
        }

        //метод зачисления суммы на счет
        public void IncreaseBalance(int amout)
        {
            CardBalance += amout;
        }

        //метод списания суммы со счета
        public void DecreaseBalace(int amout)
        {
            if (CardBalance >= amout)
            {
                CardBalance -= amout;
            }
        }

        public static void Print(Customer customer)
        {
            Console.WriteLine($"Имя: {customer.FirstName}");
            Console.WriteLine($"Фамилия: {customer.Surname}");
            Console.WriteLine($"Номер карты: {customer.CardNumber}");
            Console.WriteLine($"Балланс: {customer.CardBalance}");
        }

        public override string ToString()
        {
            return $"Имя: {FirstName} Фамилия: {Surname} Номер карты: {CardNumber} Балланс: {CardBalance}";
        }
    }
}
