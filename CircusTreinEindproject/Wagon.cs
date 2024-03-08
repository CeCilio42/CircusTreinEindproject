using CircusTreinEindproject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinEindproject
{
    public class Wagon
    {
        
        private int MaximumCap = 10;
        private List<Animal> animals;



        public Wagon()
        {
            animals = new List<Animal>();
        }


        public bool TryAddingAnimal(Animal animal)
        {
            if (animal.DoIEat(animals, animal) && DoesAnimalFit(animal))
            {
                animals.Add(animal);
                return true;
            }

            return false;
        }


        private bool DoesAnimalFit(Animal animal)
        {
            return animals.Sum(a => (int)a.size) + (int)animal.size <= MaximumCap;
        }

        
    }
}