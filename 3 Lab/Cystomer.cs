using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    partial class Customer
    {
        public override bool Equals(object obj)//сравнение объектов на равенство
        {
            if (obj == null)
                return false;
            Customer b = obj as Customer;//перевод объекта к указанному типу
            if (b == null)
                return false;
            return  this.Surname == b.Surname && this.Name == b.Name && this.FatherName == b.FatherName &&
            this.balance == b.balance && this.CardNumber == b.CardNumber;
        }

        public override int GetHashCode()//числовое значение, которое будет соответствовать объекту
        {
            return (CardNumber * 2) / 3;
        }

        public override string ToString()//даём строковое значения объектам
        {
            return $" Surname: {Surname}, Name: {Name}, Fathername: {FatherName}"; ;
        }
    }
}