using System;


namespace Lab_3
{
    partial class Customer
    {
        public readonly int id;//только для чтения
        static int numberOfCustomers = 0;
        const int a = 43;
        //свойства
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        //поля
        public int CardNumber;
        private int balance;
        //свойство
        public int Balance
        {
            get//чтение
            {
                return balance;
            }
            set//изменение
            {
                if (value > -1000 && value < 100000000)
                    balance = value;
            }
        }
        //конструктор с параметрами
        public Customer( string surname = "",string name = "", string fathername = "", int cardnumber = 0, int balance = 0)
        {
            ++numberOfCustomers;
            Surname = surname;
            Name = name;
            FatherName = fathername;
            CardNumber = cardnumber;
            Balance = balance;
            id = this.GetHashCode();
        }
        //конструктор 
        public Customer(Customer a)
        {
            ++numberOfCustomers;
            Surname = a.Surname;
            Name = a.Name;
            FatherName = a.FatherName;
            CardNumber = a.CardNumber;
            Balance = a.Balance;
            id = this.GetHashCode();
        }
        //методы
        static Customer()
        {
            Console.WriteLine("Создана первая запись");
        }

        private Customer()
        {
            numberOfCustomers++;
            Console.WriteLine("Будущая запись");
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("ФИО: " + Surname + " " + Name + " " + FatherName);
            Console.WriteLine("Номер карты: " + CardNumber);
            Console.WriteLine("Баланс: " + balance + "$");
            Console.WriteLine("ID: " + id);
        }

        public static void TypeOfClass()
        {
            Type tp = Type.GetType("Lab_3.Customer");
            Console.WriteLine(tp.AssemblyQualifiedName);
        }
       
        public void AddToCard(int b)
        {
            Balance = Balance + b;
        }

        public void MinusFromCard(int b)
        {
            Balance = Balance - b;
        }
    }
}