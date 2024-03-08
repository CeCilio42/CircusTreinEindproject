using CircusTreinEindproject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinEindproject
{
    public class Animal
    {

        public AnimalSizes size { get; set; }
        public Diet diet { get; set; }

        public Animal(AnimalSizes size, Diet diet) 
        {
            this.size = size;
            this.diet = diet;
        }


        public override string ToString()
        {
            return size.ToString() + " " + diet.ToString();
        }


        public bool DoIEat(List<Animal> animals, Animal animal)
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
