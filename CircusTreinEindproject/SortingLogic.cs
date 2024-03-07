using CircusTreinEindproject.Enums;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinEindproject
{
    internal class SortingLogic
    {
       public Train FirstSortThanDistributeAnimals(List<Animal> animalsToAdd)
        {
            Train trainASC = new Train();
            Train trainDESC = new Train();

            trainASC = Distribution(SortAnimalsToSizeAscending(animalsToAdd), trainASC);
            trainDESC = Distribution(SortAnimalsToSizeDescending(animalsToAdd), trainDESC);

            if(trainASC.GetWagons().Count < trainDESC.GetWagons().Count)
            {
                return trainASC;
            }
            else
            {
                return trainDESC;
            }
        }


        Train Distribution(List<Animal> animals, Train train)
        {
            foreach (Animal animal in animals)
            {
                train.DistributeAnimals(animal);
            }
            return train;
        }
        
        private List<Animal> SortAnimalsToSizeDescending(List<Animal> animals)
        {
            animals.Sort((a1, a2) => a2.size.CompareTo(a1.size));
            animals.Sort((b1, b2) => b2.diet.CompareTo(b1.diet));
            return animals;
        }

        private List<Animal> SortAnimalsToSizeAscending(List<Animal> animals)
        {
            animals.Sort((a2, a1) => a1.size.CompareTo(a2.size));
            animals.Sort((b2, b1) => b1.size.CompareTo(b2.size));
            return animals;
        }


    }
}
