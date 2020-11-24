using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    public interface IPaper : IBouquet
    {
        void PackIn();
    }

    public interface IBouquet
    {
        void Collect();
    }

    public interface IPot : IBouquet
    {
        void PutInPot();
        void ToPlant();
    }
}