using System;

namespace Lab_5
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------Розы-------------");
            Rose rose = new Rose();
            rose.ToPlant();
            rose.GetPlants();
            rose.ToPlant();
            rose.ToPlant();
            rose.GetPlants();
            rose.Pour(3);
            if (rose is Plant)
            {
                Console.WriteLine($"{rose} is plant");
            }

            Console.WriteLine("-----------Кактусы-------------");
            Cactus cactus = new Cactus();
            IPot cactus_2 = cactus;
            cactus_2.ToPlant();
            cactus.ToPlant();
            cactus.GetPlants();
            cactus.Collect();
            cactus.PutInPot();

            Console.WriteLine("-----------Гладиолусы-------------");
            Gladiolus gladiolus = new Gladiolus();
            gladiolus.ToPlant();
            gladiolus.ToPlant();
            gladiolus.Pour(2);
            gladiolus.Collect();
            gladiolus.PackIn();

            Printer printer = new Printer();
            printer.iAmPrinting(cactus);

            CollectionType<string> obj1 = new CollectionType<string>();
            IGereric<string> a;
            obj1.Add("bye ");
            obj1.Add("adyos ");
            obj1.Add("sayonara ");
            a = obj1;
            a.Show();

            CollectionType<Plant> plnt = new CollectionType<Plant>();
            plnt.Add(new Rose());
            plnt.Add(new Gladiolus());
            plnt.Add(new Bush());
            plnt.Show();

            Console.WriteLine("\n");
            CollectionType<Plant> obj2 = new CollectionType<Plant>();
            ParseFile(obj2);
            obj2.Show();

            obj2.WriteFile(obj2);
        }
    }

}