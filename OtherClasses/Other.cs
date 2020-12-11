using SafariPark.Abstraction;
using SafariPark.Enums;
using SafariPark.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.OtherClasses
{
    public class AnimalSections
    {
    }

    public class HerbivoresSections : AnimalSections
    {
    }

    public class PredatorySections : AnimalSections
    {
    }

    public class FelineSection : PredatorySections
    {
        public Feline[] Felines { get; set; }
    }

    public class СanineSection : PredatorySections
    {
        public Сanine[] Сanines { get; set; }
    }

    public class BearSection : PredatorySections
    {
        public Bear[] Bears { get; set; }
    }

    public class ArtiodactylAndEquidsSection : HerbivoresSections
    {
        public ArtiodactylAndEquids[] ArtiodactylAndEquids { get; set; }
    }

    public class ComfyComparer : IComparer
    {
        public int CompareTo(object anymal) { return 0; }

        public int Compare(object first, object second)
        {
            var x = first as Animals;
            var y = second as Animals;

            if (x.Name.Length < y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length > y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Animal : IComparable
    {
        public string Name { get; set; }

        public string Family { get; set; }

        public string Detachment { get; set; }

        public string Class { get; set; }

        public int CompareTo(object o)
        {
            Animal p = o as Animal;
            if (p != null)
                return Name.CompareTo(p.Name);
            else
                throw new Exception("it is impossible to compare two objects");
        }

        public string ToString()
        {
            return "Name: " + this.Name + "Femaly: " + this.Family + "Detachment: " + this.Detachment + "Class " + this.Class;
        }
    }
}
