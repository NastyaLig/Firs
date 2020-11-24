using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_5
{
    partial class Program
    {
        public static void ParseFile(CollectionType<Plant> objColl)
        {
            using (StreamReader stream = new StreamReader(@"D:\Visual\3 sem\5-th Lab\Read.txt"))
            {
                while (stream.ReadLine() is string line)
                {
                    switch (line)
                    {
                        case "Rose":
                            objColl.Add(new Rose());
                            break;
                        case "Bush":
                            objColl.Add(new Bush());
                            break;
                        case "Gladiolus":
                            objColl.Add(new Gladiolus());
                            break;
                        case "Cactus":
                            objColl.Add(new Cactus());
                            break;
                    }
                }
            }
        }
    }

    partial class CollectionType<T>
    {
        public void WriteFile(CollectionType<Plant> objColl)
        {
            List<Plant> res = objColl.list;
            using (StreamWriter write = new StreamWriter(@"D:\Visual\3 sem\5-th Lab\Write.txt"))
            {
                foreach (Plant item in res)
                {
                    write.WriteLine(item);
                }
            }
        }
    }
}