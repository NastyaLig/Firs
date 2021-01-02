using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();
            Reflector.ToFile(reflector.ToString());

            Console.WriteLine("Methods: ");
            foreach (var q in Reflector.GetMethods(reflector.ToString()))
                Console.WriteLine("\t" + q.Name);


            Console.WriteLine("Fields and properties: ");
            foreach (var q in Reflector.GetFieldsProps(reflector.ToString()))
                foreach (var qq in q)
                    Console.WriteLine("\t" + qq.Name);


            Console.WriteLine("Interfaces: ");
            foreach (var q in Reflector.GetInterface(reflector.ToString()))
                Console.WriteLine("\t" + q.Name);


            Console.WriteLine();
            TestClass main = new TestClass();
            Reflector.PrintMet(main.ToString(), typeof(int));
            Reflector.ToFile(main.ToString());
            Reflector.ExecuteMethod(main.ToString(), "Hi");
        }
    }
}