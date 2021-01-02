using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace _6_lab.Controller
{
    class PriceComp : IComparable<Flower>
    {
        public int Compare(Flower x, Flower y)
        {
            if (x.price > y.price)
            {
                return 1;
            }
            else if (x.price < y.price)
            {
                return -1;
            }

            return 0;
        }

        public int CompareTo([AllowNull] Flower other)
        {
            throw new NotImplementedException();
        }
    }
    class Bouquete
    {
        public List<Flower> Flwrs;

        public Bouquete()
        {
            Flwrs = new List<Flower>();
        }
        public void Delete(int index)
        {
            Flwrs.RemoveAt(index);
        }
        public void Add(Flower item)
        {
            Flwrs.Add(item);
        }

        public int GetPrice()
        {
            int res = 0;
            foreach (Flower item in Flwrs)
            {
                res += item.price;
            }
            return res;
        }
    }

    class BouqContr
    {
        public static void FS(Bouquete b)
        {
            b.Flwrs.Sort();
        }

        public static void FindByColor(Bouquete b, string color)
        {
            foreach (Flower item in b.Flwrs)
            {
                if (item.color == color)
                {
                    Console.WriteLine($"Цветок с цветом {color} был найден. ");
                }
            }
        }

        public static void ParseFile(Bouquete bq1)
        {
            bool not_initialized = true;
            using (StreamReader stream = new StreamReader(@"D:/Visual/3 sem/6 lab/6_lab.txt"))
            {
                while (stream.ReadLine() is string line)
                {
                    switch (line)
                    {
                        case "#Flower" when not_initialized:
                            Flower fl = new Flower(int.Parse(stream.ReadLine()), stream.ReadLine());
                            bq1.Add(fl);
                            break;
                    }
                }
            }
        }
    }
}