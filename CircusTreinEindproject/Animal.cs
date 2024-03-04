using CircusTreinEindproject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinEindproject
{
    internal class Animal
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

    }
}
