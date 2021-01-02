using System;

namespace Lab9
{
    class Program
    {
        delegate void DirectorDelegate(int amout);

        static void Main(string[] args)
        {

            Employee[] employes = new Employee[]//работники 
            {
                new Employee("Работник 1", 100, 0b00),
                new Employee("Работник 2", 100, 0b01),
                new Employee("Работник 3", 100, 0b01),
                new Employee("Работник 4", 100, 0b10),
                new Employee("Работник 5", 100, 0b10),
                new Employee("Работник 6", 100, 0b11),
            };
            Console.WriteLine("Начальные значения");
            Employee.PrintArray(employes);

            Console.WriteLine("Повышение на 30");
            Director.CallPromote(30);
            Employee.PrintArray(employes);//вывод списка работников с повышением на 30

            Console.WriteLine("Понижение на 50");
            Director.CallDemote(50);
            Employee.PrintArray(employes);//вывод списка работников с понижением на 50
            //2 задание
            Func<string, string> operations;
            operations = StringOperations.RemoveSpaces;
            operations += StringOperations.Uppercase;
            operations += StringOperations.RemoveExclamationMarks;
            operations += StringOperations.InsertStars;
            operations += StringOperations.Lowercase;

            string str = "very important string!!!";
            operations.Invoke(str);
        }

        static class Director
        {
            public static event DirectorDelegate Promote;
            public static event DirectorDelegate Demote;

            public static void CallPromote(int amout) => Promote.Invoke(amout);
            public static void CallDemote(int amout) => Demote.Invoke(amout);
        }

        class Employee
        {
            public string Name { get; private set; }
            public int Money { get; private set; }

            public Employee(string name, int money, byte eventsFlag)
            {
                Name = name;
                Money = money;

                if ((eventsFlag & 1) > 0)
                {
                    Director.Promote += Promote;//+30
                }
                if ((eventsFlag & 2) > 0)
                {
                    Director.Demote += Demote;//-50
                }
            }

            public override string ToString() => $"[{Name}] - зарплата:{Money} руб.";

            public static void PrintArray(Employee[] employees)
            {
                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp.ToString());
                }
            }

            private void Promote(int amount) => Money += amount;
            private void Demote(int amount) => Money -= amount;
        }
        //2 задание
        static class StringOperations
        {
            public static string RemoveSpaces(string str)//удаление пробелов из строки
            {
                str = str.Replace(" ", "_");//замена пробела на "_"
                Console.WriteLine(str);
                return str;
            }

            public static string Uppercase(string str)//Верхний регистр
            {
                str = str.ToUpper();
                Console.WriteLine(str);
                return str;
            }

            public static string RemoveExclamationMarks(string str)//замена символа
            {
                str = str.Replace("!", "");//замена "!" на ""
                Console.WriteLine(str);
                return str;
            }

            public static string InsertStars(string str)//добавление * в начало и конец строки
            {
                str = str.Insert(0, "*");//добавление в начало
                str = str.Insert(str.Length, "*");//добавление в конец
                Console.WriteLine(str);
                return str;
            }

            public static string Lowercase(string str)//нижний регистр
            {
                str = str.ToLower();
                Console.WriteLine(str);
                return str;
            }
        }
    }
}
