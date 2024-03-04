using CircusTreinEindproject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinEindproject
{
    internal class Wagon
    {
        private int MaximumCap = 10;
        private List<Animal> animals;

        public Wagon()
        {
            animals = new List<Animal>();
        }


        public void SortAnimals()
        {
            animals.Sort((a1, a2) => a2.size.CompareTo(a1.size));
            animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));
        }

        public bool TryAddingAnimal(Animal animal)
        {
            if (DoesAnimalBehave(animal) && DoesAnimalFit(animal))
            {
                AnimalToList(animal);
                return true;
            }

            return false;
        }

        public void AnimalToList(Animal animal)
        {
            animals.Add(animal);
        }

        private bool DoesAnimalFit(Animal animal)
        {
            return animals.Sum(a => (int)a.size) + (int)animal.size <= MaximumCap;
        }

        private bool DoesAnimalBehave(Animal animal)
        {
            foreach (var existingAnimal in animals)
            {
                bool isCarnivore = existingAnimal.diet == Diet.Carnivore;
                bool sizeCondition = isCarnivore ? (int)existingAnimal.size >= (int)animal.size : existingAnimal.size >= animal.size;

                if (isCarnivore && sizeCondition || animal.diet == Diet.Carnivore && !sizeCondition)
                {
                    return false;
                }
            }

            return true;
        }


        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}
