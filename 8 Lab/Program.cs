using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab8
{
    public interface ISet<T>
    {
        void AddToSet(T item);
        void DeleteFromSet(T item);
        void DisplaySet();
    }

    [Serializable]
    public class SetItem
    {
        private string data;
        public string Data { get; set; }

        public SetItem(string data)
        {
            this.data = data;
            Data = this.data;

            if (String.IsNullOrEmpty(data))
            {
                throw new Exception("Данные пусты");
            }
        }

        public override string ToString() => $"data: {this.data}";
    }

    public class NoItemInSetException : Exception
    {
        public NoItemInSetException() : base("Нет предметов") { }
    }

    [Serializable]
    public class Set<T> : List<T>, ISet<T>
        where T : SetItem
    {
        public void AddToSet(T item)
        {
            this.Add(item);
        }

        public void DeleteFromSet(T item)
        {
            if (!this.Contains(item))
            {
                throw new NoItemInSetException();
            }
            this.Remove(item);
        }

        public void DisplaySet()
        {
            foreach (T item in this)
            {
                Console.Write($"{item.ToString()}\t");
            }
            Console.WriteLine();
        }
    }

    static class SetSerializer
    {
        public static void Serialize<T>(T item, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, item);
            stream.Close();
            Console.WriteLine("Сериализация прошла успешно!");
        }

        public static object FromFile<T>(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            T newObject = (T)formatter.Deserialize(stream);

            stream.Close();

            Console.WriteLine("Десериализованно успешно!");

            return newObject;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var set = new Set<SetItem>();
            set.AddToSet(new SetItem("1"));
            set.AddToSet(new SetItem("2"));
            set.AddToSet(new SetItem("3"));
            try
            {
                set.Remove(new SetItem("1"));
            }
            catch (NoItemInSetException ex)
            {
                Console.WriteLine("Нет исключений в наборе элементов!");
            }
            finally
            {
                Console.WriteLine("Выполнено");
            }

            set.DisplaySet();

            SetSerializer.Serialize<Set<SetItem>>(set, "set_data.dat");
            var newSet = (Set<SetItem>)SetSerializer.FromFile<Set<SetItem>>("set_data.dat");
            newSet.DisplaySet();
        }
    }
}