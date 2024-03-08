using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinEindproject
{
    public class Train
    {
        Wagon wagon = new Wagon();

        private List<Wagon> wagons;
        

        public Train()
        {
            wagons = new List<Wagon>();
        }


        public void DistributeAnimals(Animal animal)
        {
            FirstWagon();
            AddAnimalsToWagon(animal);
        }

        private void FirstWagon()
        {
            if (wagons.Count == 0)
            {

                wagons.Add(new Wagon());
            }
        }

        private void AddAnimalsToWagon(Animal animal)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i].TryAddingAnimal(animal))
                {
                    return;
                }
            }


            wagons.Add(new Wagon());
            wagons[wagons.Count - 1].TryAddingAnimal(animal);
        }


        public List<Wagon> GetWagons()
        {
            return wagons;
        }
    }
}