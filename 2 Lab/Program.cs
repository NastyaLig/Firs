using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //инициализация примитивных типов данных
            bool f = false;
            bool t = true;
            Console.WriteLine("5+3=10: {0}", f);
            Console.WriteLine("5+3=8: {0}", t);
            byte a = 108;
            Console.WriteLine("Переменная типа byte = {0}\nНовая переменная byte:", a);//беззнаковое целое до 255
            a = Convert.ToByte(Console.ReadLine());
            sbyte s = -100;
            Console.WriteLine("Переменная типа sbyte = {0}\nНовая переменная sbyte:", s);//целое число от -128
            s = Convert.ToSByte(Console.ReadLine());
            char c = 'H';
            Console.WriteLine("Переменная типа char = {0}\nНовое значение char:", c);//один символ
            c = Convert.ToChar(Console.ReadLine());
            short b = -32767;
            Console.WriteLine("Переменная типа short = {0}\nНовое значение:", b);//целое число от -32768
            b = Convert.ToInt16(Console.ReadLine());
            ushort d = 'c';
            Console.WriteLine("Переменная типа ushort = {0}\nНовое значение:", d);//беззнаковое число от 0 до 65535
            d = Convert.ToUInt16(Console.ReadLine());
            int e = 163;
            Console.WriteLine("Переменная типа int = {0}\nНовое значение:", e);//целые числа в диапозоне от -2147483648 до 2147483647
            e = Convert.ToInt32(Console.ReadLine());
            uint g = 5236;
            Console.WriteLine("Переменная типа uint = {0}\nНовое значение:", g);//целые число без знака
            g = Convert.ToUInt32(Console.ReadLine());
            float h = 10.5f;
            Console.WriteLine("Переменная типа float = {0}\nНовое значение:", h);// числа с плавающей точкой
            h = (float)Convert.ToDouble(Console.ReadLine());
            long z = -3654;
            Console.WriteLine("Переменная типа long = {0}\n Новое значение:", z);//целое число
            z = Convert.ToInt64(Console.ReadLine());
            ulong k = 25364;
            Console.WriteLine("Переменная типа ulong = {0}\n Новое значение:", k);//беззнаковое целое число
            k = Convert.ToUInt64(Console.ReadLine());
            double x = 300.99;
            Console.WriteLine("Переменная типа double = {0}\n Новое значение:", x);// числа с плавающей точкой
            x = Convert.ToDouble(Console.ReadLine());
            decimal y = 4e4m;
            Console.WriteLine("Переменная типа decimal = {0}\n Новое значение:", y);
            y = Convert.ToDecimal(Console.ReadLine());
            //Приведения
            h = (float)x;//явное
            x = h;//неявное
            a = (byte)e;
            e = a;
            e = (int)z;
            z = e;
            k = (ulong)z;
            //Console.WriteLine("\t\nTask 1-c!");
            //Int32 y = 5;
            //Object o = y;
            //byte m = (byte)(int)o;

            //Console.WriteLine("\t\nTask 1-d!");
            //var v1 = 5;
            //Console.WriteLine($" неявно типизированная переменная: {v1.GetType()}");//

            //Console.WriteLine("\tЗадание e");
            //int? p = null;
            ////Nullable<int> p = 25;
            //Console.WriteLine($"Nullable: {p}");

            //Console.WriteLine("\t\nЗадание f");
            //var v2 = 5;
            //v2 = 6;

            //Пункт С
            Console.WriteLine();
            Object objA = e;
            Console.WriteLine("objA = {0} ({1})\ne = {2} ({3})", objA, objA.GetType(), e, e.GetType());
            e = (int)objA;
            Object objB = c;
            Console.WriteLine("objB = {0} ({1})\nc = {2} ({3})", objB, objB.GetType(), c, c.GetType());
            c = (char)objB;
            //D
            var varA = 5;
            var varB = 'P';
            var varC = "String";
            //Пункты E и F
            int? A = null;
            Nullable<int> B = 6;
            B = null;
            //int C = null;
            var varD = 'A';
            //varD = 5;


            //2 задание
            String str1 = "first string";
            String str2 = "second string";
            String str3 = "third string";
            str1 = String.Concat(str1, str2);//соединение
            Console.WriteLine(str1);
            str1 = String.Copy(str2);//копирование
            Console.WriteLine(str1);
            str1 = str1.Substring(3, 5);//извлечение подстроки
            Console.WriteLine(str1);
            String[] splitStr = str3.Split(' ');//разбивание строки на подстроки 
            foreach (String str in splitStr)
            {
                Console.WriteLine(str);
            }
            str3 = str3.Insert(5, " ____");//возвращение строки с указанной строкой 
            Console.WriteLine(str3);
            str3 = str3.Remove(5, 5);//возвращение строки с удалёнными симвалами
            Console.WriteLine(str3);
            //Интерполирование 
            String str0 = "строк";
            Console.WriteLine($"Интерполирование {str0}");
            String testString1 = " ";
            String testString2 = null;
            Console.WriteLine("' '   IsNullOrEmpty - " + String.IsNullOrEmpty(testString1));
            Console.WriteLine("null  IsNullOrEmpty - " + String.IsNullOrEmpty(testString2));
            Console.WriteLine("' '   IsNullOrWhiteSpace - " + String.IsNullOrWhiteSpace(testString1));
            Console.WriteLine("null  IsNullOrWhiteSpace - " + String.IsNullOrWhiteSpace(testString2));
            //D
            StringBuilder string1 = new StringBuilder("Строка на основе StringBuilder");
            string1.Remove(0, 3);//удаление
            string1.Remove(22, 5);
            Console.WriteLine(string1);
            string1.Insert(0, "TTT");//вставка
            string1.Insert(25, "SSS");
            Console.WriteLine(string1);

            //3 Задание
            Console.WriteLine("\nЗадание 3a\nдвумерный массив: \n");
            int[,] array1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{array1[i, j]} ");
                }
            }
            Console.WriteLine($"{array1[0, 0]} {array1[0, 1]} {array1[0, 2]} ");
            Console.WriteLine($"{array1[1, 0]} {array1[1, 1]} {array1[1, 2]} ");
            Console.WriteLine("\nЗадание 3b");
            Console.WriteLine($"Одномерный массив строк");
            String[] collection = new String[] { "first", "second", "third" };
            for (int i = 0; i < collection.Length; ++i)
            {
                Console.WriteLine(collection[i]);
            }
            Console.WriteLine($"Длинна массива: {collection.Length}");
            Console.WriteLine($"Введите номер элемента, который нужно поменять: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите новую строку: ");
            string line = Console.ReadLine();
            collection[number] = line;
            Console.WriteLine($"Новый массив строк");
            for (int i = 0; i < collection.Length; ++i)
            {
                Console.WriteLine(collection[i]);
            }
            Console.WriteLine("\nЗадание c");
            int[][] numbers = new int[3][];
            numbers[0] = new int[2] { 1, 2 };
            numbers[1] = new int[3] { 45, 34, 23 };
            numbers[2] = new int[4] { 25, 7, 9, 0 };
            foreach (int[] row in numbers)
            {
                foreach (int number2 in row)
                {
                    //int number3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{number2} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗадание d");
            var array2 = new object[4];
            for (int i = 0; i < array2.Length; ++i)
            {
                array2[i] = Console.ReadLine();
            }
            Console.WriteLine($"Итоговый массив массива:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.WriteLine($"Длинна массива: {array2.Length}");
            // 4 Задание
            Console.WriteLine("\nЗадание 4");
            (int, string, char, string, ulong) TupleA = (1, "aa", 'b', "cc", 23);
            Console.WriteLine(TupleA);
            Console.WriteLine(TupleA.Item1);
            Console.WriteLine(TupleA.Item3);
            Console.WriteLine(TupleA.Item4);
            var (first, _, _, fourth, fifth) = TupleA;
            //5 Задание
            Console.WriteLine("\nЗадание 5");
            int[] Arrai = { 5, 7, 9, 27 };
            Console.WriteLine(task5(Arrai, "nastya"));
            task5(Arrai, "abcd");
            Console.WriteLine("\nЗадание 6,2");
            task6_2();
            Console.WriteLine("\nЗадание 6,1");
            task6_1();

            (int, int, int, char) task5(int[] arrA, string strA)
            {
                int max, min, sum = 0;
                min = max = arrA[0];
                foreach (int i in arrA)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                foreach (int i in arrA)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                }
                foreach (int i in arrA)
                {
                    sum += i;
                }
                (int, int, int, char) TupleB = (min, max, sum, strA[0]);
                return TupleB;
            }
            void task6_1()
            {
                checked
                {
                    int Q = 2_147_483_647;
                    Q++;
                    Console.WriteLine(Q);
                }
            }
            void task6_2()
            {
                unchecked
                {
                    int Q = 2_147_483_647;
                    Q++;
                    Console.WriteLine(Q);
                }
            }

        }


    }
}
