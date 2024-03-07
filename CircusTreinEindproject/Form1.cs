using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinEindproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Train train;
        SortingLogic sortLogic = new SortingLogic();

        List<Animal> animals = new List<Animal>();


        private void buttonS_H_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Enums.AnimalSizes.Small, Enums.Diet.Herbivore));
            UpdateList();
        }



        private void buttonM_H_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Enums.AnimalSizes.Medium, Enums.Diet.Herbivore));
            UpdateList();
        }

        private void buttonL_H_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Enums.AnimalSizes.Large, Enums.Diet.Herbivore));
            UpdateList();
        }

        private void buttonS_C_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Enums.AnimalSizes.Small, Enums.Diet.Carnivore));
            UpdateList();
        }

        private void buttonM_C_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Enums.AnimalSizes.Medium, Enums.Diet.Carnivore));
            UpdateList();
        }

        private void buttonL_C_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Enums.AnimalSizes.Large, Enums.Diet.Carnivore));
            UpdateList();
        }

        private void Distribute_Click(object sender, EventArgs e)
        {
            train = sortLogic.FirstSortThanDistributeAnimals(animals);
            ShowAnimalsAndWagonsInListBox();
        }

        private void ShowAnimalsAndWagonsInListBox()
        {
            List<Wagon> wagonList = train.GetWagons();
            listBoxWagons.Items.Clear();
            foreach (Wagon wagon in wagonList)
            {
                listBoxWagons.Items.Add(wagon);

            }

            labelWagonCount.Text = "Wagons: " + train.GetWagons().Count.ToString();

        }


        private void UpdateList()
        {
            listBoxAnimals.Items.Clear();
            foreach (Animal animal in animals)
            {
                listBoxAnimals.Items.Add(animal);
            }
        }

       
    }
}