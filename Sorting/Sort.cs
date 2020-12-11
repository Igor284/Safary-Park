using SafariPark.Enums;
using SafariPark.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Sorting
{
    class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal p1, Animal p2)
        {
            if (p1.Name.Length > p2.Name.Length)
                return 1;
            else if (p1.Name.Length < p2.Name.Length)
                return -1;
            else
                return 0;
        }

        class Program
        {
            static Animal Search(Animal[] animals, string name)
            {
                foreach (Animal p in animals)
                {
                    if (p.Name.Equals(name))
                        return p;
                }

                return null;
            }

            static void Main(string[] args)
            {
                Animal Jaguar = new Animal { Name = "Artur", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Cheetah = new Animal { Name = "Vasya", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Cougar = new Animal { Name = "Alex", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Leopard = new Animal { Name = "Murka", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Panther = new Animal { Name = "Felix", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Lynx = new Animal { Name = "Petya", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Tiguer = new Animal { Name = "King", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Lion = new Animal { Name = "Puking", Class = "Mammals", Detachment = "Predator", Family = "Feline" };
                Animal Fox = new Animal { Name = "Alisa", Class = "Mammals", Detachment = "Predator", Family = "Сanine" };
                Animal Dog = new Animal { Name = "Rex", Class = "Mammals", Detachment = "Predator", Family = "Сanine", };
                Animal Wolf = new Animal { Name = "Akela", Class = "Mammals", Detachment = "Predator", Family = "Сanine" };
                Animal BrowBear = new Animal { Name = "Shrek", Class = "Mammals", Detachment = "Predator", Family = "Bear" };
                Animal HimalayaBear = new Animal { Name = "Vladislav", Class = "Mammals", Detachment = "Predator", Family = "Bear" };
                Animal Giraffe = new Animal { Name = "Melman", Class = "Mammals", Detachment = "Herbivores", Family = "Artiodactyl" };
                Animal Zebras = new Animal { Name = "Marty", Class = "Mammals", Detachment = "Herbivores", Family = "Equids" };

                Animal[] animals = new Animal[] { Jaguar, Cheetah, Cougar, Leopard, Panther, Lynx, Tiguer, Lion, Fox, Dog, Wolf, BrowBear, HimalayaBear, Giraffe, Zebras };
                Array.Sort(animals);
                string name = Convert.ToString(Console.ReadLine());

                int nomberOfAnimalInAnimalsArray = 0;

                for (int i = 0; i < animals.Length; i++)
                {
                    nomberOfAnimalInAnimalsArray = i;
                    if (name == animals[i].Name)
                    {
                        break;
                    }
                }

                Console.WriteLine("xyu = " + nomberOfAnimalInAnimalsArray);

                var AnimalSection1 = Enum.GetNames(typeof(Feline)).Length;
                var AnimalSection2 = Enum.GetNames(typeof(Сanine)).Length;
                var AnimalSection3 = Enum.GetNames(typeof(Bear)).Length;
                var AnimalSection4 = Enum.GetNames(typeof(ArtiodactylAndEquids)).Length;

                Console.WriteLine("Animal Section #1 : " + AnimalSection1 + " Felines\n" + "Animal Section #2 : " + AnimalSection2 + " Сanines\n" +
                    "Animal Section #3 : " + AnimalSection3 + " Bears\n" + "Animal Section #4 : " + AnimalSection4 + " Artiodactyls And Equids");

                foreach (Animal item in animals)
                {
                    Console.WriteLine("Name: " + item.Name + " , " + "Class: " + item.Class + " , " + "Detachment: " + item.Detachment + " , " + "Family: " + item.Family);
                }
            }
        }
    }
}
