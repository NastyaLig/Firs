using System;
using System.Collections.Generic;

namespace Lab_3
{
    class Program
    {

        static void Main()//метод
        {
            Customer a = new Customer("Иванова", "Ольга", "Ивановна", 137, 19000);
            a.PrintInfo();
            a.AddToCard(1000);
            a.PrintInfo();
            a.MinusFromCard(2000);
            a.PrintInfo();
            Customer.TypeOfClass();
            Customer b = new Customer("Наумова", "Алиса", "Николаевеа", 654, 1000);
            Customer c = new Customer(a);
            Console.WriteLine("---------------------------------");
            if (a.Equals(b))
            {
                Console.WriteLine("Запись 1 = записи 2");
            }
            else
                Console.WriteLine("Запись 1 != записи 2");

            if (a.Equals(c))
            {
                Console.WriteLine("Запись 1 = записи 3");
            }
            else
                Console.WriteLine("Запись 1 != записи 3");
            Console.WriteLine("---------------------------------");

            Customer[] arrCust = new Customer[3];
            arrCust[0] = new Customer(a);
            arrCust[1] = new Customer(b);
            arrCust[2] = new Customer("Петров", "Иван", "Владиславович", 1111, 100000);

            foreach (Customer element in arrCust)//передача элементов по ссылке
            {
                element.PrintInfo();
            }
            Console.WriteLine("---------------------------------");

            int bufPointLow, bufPointCup;
            Console.WriteLine("Введите нижний диапазона");
            bufPointLow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхний диапазона");
            bufPointCup = Convert.ToInt32(Console.ReadLine());

            foreach (Customer element in arrCust)
            {
                if (element.CardNumber >= bufPointLow && element.CardNumber <= bufPointCup)
                    element.PrintInfo();
            }
            Console.WriteLine("---------------------------------");
            var User = new { Name = "Nastya", Age = 19 };//анонимный тип
            Console.WriteLine(User.Name + " " + User.Age);
        }
    }
}