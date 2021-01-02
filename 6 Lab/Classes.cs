//using _6_lab.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _6_lab
{
    abstract class Plant
    {
        protected int numOfPlants = 0;
        public string color { get; set; }
        public int price { get; set; }
        public override string ToString() => "Plant";
        public Plant() { }
        public virtual void Pour(int litters)
        {
        //    if (litters < 0)
        //        throw new PlantException("Вы не можене полить растение < 0  литрами воды", litters);
        //    Debug.Assert(litters < 50);
           Console.WriteLine($"Вы полили растение {litters} литрами воды");
        }
        public abstract void ToPlant();
        public void GetPlants() => Console.WriteLine($"Всего {numOfPlants} растеный вида {ToString()}");
    }

    sealed class Bush : Plant
    {
        public override string ToString() => "Bush";
        public override void ToPlant() => Console.WriteLine("Вы посадили куст", numOfPlants += 1);

    }

    partial class Flower : Plant, IComparable
    {
        public override string ToString() => "Flower";
        public override void ToPlant() => Console.WriteLine("Вы посадили цветок", numOfPlants += 1);
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            Flower other = (Flower)obj;
            return (numOfPlants == other.numOfPlants);
        }

        public override int GetHashCode()
        {
            return DateTime.Now.Millisecond;
        }
        public Flower(int Price, string Color)
        {
        //    if (Price < 0)
        //        throw new FlowerException("Стоимость не может быть < 0", Price);
          price = Price;
           color = Color;
        }
        public int CompareTo(object obj)
        {
            Flower flower = (Flower)obj;
            if (price > flower.price) return 1;
            if (price < flower.price) return -1;
            return 0;
        }
    }

    class Rose : Plant, IPaper
    {
        public override string ToString() => "Rose";
        public override void ToPlant() => Console.WriteLine("Вы посадили розу", numOfPlants += 1);
        public void Collect() => Console.WriteLine("Вы собрали букет роз");
        public void PackIn() => Console.WriteLine("Вы обернули букет в бумагу");
    }

    class Gladiolus : Plant, IPaper
    {
        public override string ToString() => "Gladiolus";
        public override void ToPlant() => Console.WriteLine("Вы посадили гладиолус", numOfPlants += 1);
        public void Collect() => Console.WriteLine("Вы собрали букет из гладиолусов");
        public void PackIn() => Console.WriteLine("Вы обернули букет в бумагу");
    }
    class Cactus : Plant, IPot
    {
        public override string ToString() => "Cactus";
        public override void ToPlant() => Console.WriteLine("Вы посадили кактус (abstract)", numOfPlants += 1);
        void IPot.ToPlant() => Console.WriteLine("Вы посадили кактус (interface)", numOfPlants += 1);
        public void Collect() => Console.WriteLine("Вы собрали кактус");
        public void PutInPot() => Console.WriteLine("Вы поместили кактус в горшок");
    }
}
