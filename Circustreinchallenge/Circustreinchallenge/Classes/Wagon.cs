using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustreinchallenge.Classes
{
    class Wagon
    {
        private int id;
        private int maxsize = 10;
        public IList<Animal> Animals { get; set; } = new List<Animal>();

        public int Id
        {
            get { return id; }
        }

        public int MaxSize
        {
            get { return maxsize; }
        }

        public Wagon()
        {
        }

        public Wagon(int maxSize, int id)
        {
            this.maxsize = maxSize;
            this.id = id;
        }

        public int CurrentSize (){

            int size = 0;
            foreach (Animal animal in this.Animals)
            {
                size = size + animal.Size;
            }
            return size;
        }

        public bool AnimalAdd(Animal animal)
        {
           if (CurrentSize() + animal.Size > MaxSize)
            {
                return false;
            }
            if (!AnimalCheck(animal))
            {
                return false;
            }

            Animals.Add(animal);
            return true;
        }
        private bool AnimalCheck(Animal animal)
        {
            foreach (Animal checkanimal in Animals)
            {
                if (!checkanimal.Carnivore) {
                    continue;
                }
                if(animal.Size <= checkanimal.Size)
                {
                    return false;
                }
            }  
            return true;
        }

        public override string ToString()
        {
            string wagonString = "";
            foreach (Animal Animal in Animals)
            {
                wagonString += Animal;
            }
            wagonString += "\r\n-------\r\n";
            return wagonString;
        }

    }
    
}
