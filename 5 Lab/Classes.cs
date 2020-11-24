using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Printer
    {
        public void iAmPrinting(Plant someobj)
        {
            Console.WriteLine("Тип объекта = " + someobj.ToString());
        }
    }

    abstract class Plant
    {
        protected int numOfPlants = 0;
        public override string ToString() => "Plant";
        public Plant() { }
        public virtual void Pour(int litters)
        {
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

    class Flower : Plant
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
    }

    class Rose : Flower, IPaper
    {
        public override string ToString() => "Rose";
        public override void ToPlant() => Console.WriteLine("Вы посадили розу", numOfPlants += 1);
        public void Collect() => Console.WriteLine("Вы собрали букет роз");
        public void PackIn() => Console.WriteLine("Вы обернули букет в бумагу");
    }

    class Gladiolus : Flower, IPaper
    {
        public override string ToString() => "Gladiolus";
        public override void ToPlant() => Console.WriteLine("Вы посадили гладиолус", numOfPlants += 1);
        public void Collect() => Console.WriteLine("Вы собрали букет из гладиолусов");
        public void PackIn() => Console.WriteLine("Вы обернули букет в бумагу");
    }
    class Cactus : Flower, IPot
    {
        public override string ToString() => "Cactus";
        public override void ToPlant() => Console.WriteLine("Вы посадили кактус (abstract)", numOfPlants += 1);
        void IPot.ToPlant() => Console.WriteLine("Вы посадили кактус (interface)", numOfPlants += 1);
        public void Collect() => Console.WriteLine("Вы собрали кактус");
        public void PutInPot() => Console.WriteLine("Вы поместили кактус в горшок");
    }

}