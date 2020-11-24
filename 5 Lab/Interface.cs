using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public interface IGereric<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
    }
}