using Circustreinchallenge.Classes;
using System;
using System.Collections.Generic;


namespace Circustreinchallenge
{
    
    class Program
    {

        public static IList<Animal> Animals { get; private set; }

        static void Main(string[] args)
        {


         Train CircusTrain = new Train();

            Animals = new List<Animal>() {
                new Animal(3, "Schildpad", 1, false),
                new Animal(3, "Schildpad", 2, false),
                new Animal(3, "Schildpad", 3, false),
                new Animal(5, "Paard", 4, false),
                new Animal(5, "Leeuw", 5, true),
                new Animal(5, "Beer", 6, true),
                new Animal(3, "Fred", 7, true),
                new Animal(3, "Pad", 8, false),
                new Animal(1, "Duif", 9, false),
                new Animal(1, "Pad", 10, false),
                new Animal(3, "Wolf", 11, true),
                new Animal(3, "Krokodil", 12, true),
                new Animal(5, "Tijger", 14, true)
            };


            CircusTrain.SortAnimals(Animals);

            Console.WriteLine(CircusTrain);
        }

    }
}
