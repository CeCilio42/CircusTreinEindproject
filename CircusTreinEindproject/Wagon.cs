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


        

        public void SortAnimalsToSizeDescending()
        {
            animals.Sort((a1, a2) => a2.size.CompareTo(a1.size));
            animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));
        }

        public void SortAnimalsToSizeAscending()
        {
            animals.Sort((a2, a1) => a1.size.CompareTo(a2.size));
            animals.Sort((b2, b1) => b1.size.CompareTo(b2.size));
        }


        public bool TryAddingAnimal(Animal animal)
        {
            if (DoesAnimalEat(animal) && DoesAnimalFit(animal))
            {
                PutAnimalInList(animal);
                return true;
            }

            return false;
        }

        public void PutAnimalInList(Animal animal)
        {
            animals.Add(animal);
        }        

        private bool DoesAnimalFit(Animal animal)
        {
            return animals.Sum(a => (int)a.size) + (int)animal.size <= MaximumCap;
        }

        public int GetAnimalsSumBySize()
        {
            return animals.Sum(a => (int)a.size);
        }

        private bool DoesAnimalEat(Animal animal)
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
