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


        public bool TryAddingAnimal(Animal animal)
        {
            if (DoesAnimalEat(animal) && DoesAnimalFit(animal))
            {
                PutAnimalInList(animal);
                return true;
            }

            return false;
        }

        private void PutAnimalInList(Animal animal)
        {
            animals.Add(animal);
        }

        private bool DoesAnimalFit(Animal animal)
        {
            return animals.Sum(a => (int)a.size) + (int)animal.size <= MaximumCap;
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
    }
}