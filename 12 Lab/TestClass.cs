using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class TestClass : ICloneable
    {
        public int num;
        public string str;
        public void Hi(string str, int num)
        {
            Console.WriteLine($"num: {num}, string: {str}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}