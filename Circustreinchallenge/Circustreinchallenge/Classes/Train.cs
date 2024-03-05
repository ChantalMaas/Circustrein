using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustreinchallenge.Classes
{
    class Train
    {
        public List<Wagon> Wagons { get; private set; } = new List<Wagon>();


        public void SortAnimals(IList <Animal> animals)
        {
            //foreach (Animal animal in animals)
            //{
            //    if (animal.Carnivore)
            //    {
            //        Wagon Wagon = new Wagon();
            //        Wagon.AnimalAdd(animal);
            //        Wagons.Add(Wagon);
            //    }
            //}
            //foreach (Animal animal in animals)
            //{
            //    if (!animal.Carnivore)
            //    {
            //        if (!SortHerbivore(animal))
            //        {
            //            Wagon Wagon = new Wagon();
            //            Wagon.AnimalAdd(animal);
            //            Wagons.Add(Wagon);
            //        }

            //    }
            //}

            var resultCarnivore = from animal in animals
                         where animal.Carnivore == true
                         select animal;

            foreach (var animal in resultCarnivore)
            {
                Wagon Wagon = new Wagon();
                Wagon.AnimalAdd(animal);
                Wagons.Add(Wagon);
            }

            var resultHerbivore = from animal in animals
                         where animal.Carnivore == false
                         select animal;

            foreach (var animal in resultHerbivore)
            {
                if (!SortHerbivore(animal))
                {
                    Wagon Wagon = new Wagon();
                    Wagon.AnimalAdd(animal);
                    Wagons.Add(Wagon);
                }
            }
        }

        public bool SortHerbivore(Animal animal)
        {
            foreach (Wagon wagon in Wagons)
            {
                if (wagon.AnimalAdd(animal))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            string trainString = "";
            foreach (Wagon Wagon in Wagons)
            {
                trainString += Wagon;
            }
            return trainString;
        }
    }
}
