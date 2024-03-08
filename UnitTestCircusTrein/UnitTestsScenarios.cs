using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CircusTreinEindproject;
using System.Diagnostics;

namespace UnitTestCircusTrein
{


    [TestClass]
    public class UnitTestsScenarios
    {
        SortingLogic sortingLogic = new SortingLogic();

        [TestMethod]
        public void TestScenario_1()
        {
            //Arrange
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));

            //Act
            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            //Assert
            Assert.AreEqual(2, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScenario_2()
        {
            //Arrange
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));

            //Act
            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            //Assert
            Assert.AreEqual(2, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScenario_3()
        {
            //Arrange
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));

            //Act
            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            //Assert
            Assert.AreEqual(4, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScenario_4()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));


            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            Assert.AreEqual(5, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScenario_5()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));


            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            Assert.AreEqual(2, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScenario_6()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));


            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            Assert.AreEqual(3, train.GetWagons().Count);
        }


        [TestMethod]
        public void TestScenario_7()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Small, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Carnivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Carnivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Carnivore));


            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Medium, CircusTreinEindproject.Enums.Diet.Herbivore));

            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));
            animals.Add(new Animal(CircusTreinEindproject.Enums.AnimalSizes.Large, CircusTreinEindproject.Enums.Diet.Herbivore));


            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            Assert.AreEqual(13, train.GetWagons().Count);
        }



        [TestMethod]
        public void TestScenario_8()
        {
            List<Animal> animals = new List<Animal>();
            Train train = new Train();


            train = sortingLogic.FirstSortThanDistributeAnimals(animals);

            Assert.AreEqual(0, train.GetWagons().Count);
        }
    }
}
