using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }

        string Family { get; }

        string Detachment { get; }

        string Class { get; }
    }

    public interface IComparer
    {
        int CompareTo(object animals);
    }
}
