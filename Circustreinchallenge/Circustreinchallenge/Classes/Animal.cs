using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustreinchallenge.Classes
{
    public class Animal
    {
        private int size;
        private string species;
        private int id;
        private bool carnivore;

        public int Size
        {
            get { return size; }
        }
        public string Spieces
        {
            get { return species; }
        }

        public int Id
        {
            get { return id; }
        }
        public bool Carnivore
        {
            get { return carnivore; }
        }

        public Animal(int size, string species, int id, bool carnivore)
        {
            this.size = size;
            this.species = species;
            this.id = id;
            this.carnivore = carnivore;
        }


        public override string ToString()
        {
            return $"{ size } {species} { id} {carnivore}\r\n";
        }
    }
}
