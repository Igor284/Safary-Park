using SafariPark.Interfaces;
using SafariPark.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Abstraction
{
    public abstract class Animals : IAnimal
    {
        private readonly string view;
        private readonly string genus;
        private readonly string family;
        private readonly string detachment;
        private readonly string _class;

        protected Animals(string genus, string family, string detachment, string _class)
        {
            this.genus = genus;
            this.family = family;
            this.detachment = detachment;
            this._class = _class;
        }

        public string Name { get; set; }

        public string Family => this.family;

        public string Detachment => this.detachment;

        public string Class => this._class;

        public int CompareTo(object animals)
        {
            var s = animals as Animals;
            return s != null ? this.Name.CompareTo(s.Name) : throw new Exception("Eror404");
        }
    }

    public abstract class Mammals : AnimalSections
    {
        public string Class = "Mammals";
    }

    public abstract class Birds : AnimalSections
    {
        public string Class = "Birds";
    }

}
