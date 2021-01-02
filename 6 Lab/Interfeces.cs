using System;
using System.Collections.Generic;
using System.Text;

namespace _6_lab
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