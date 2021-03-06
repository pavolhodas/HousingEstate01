﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Habitant : Person
    {
        public Habitant(string name, string surname, int age) : base(name, surname, age)
        {
        }
        public string GetInfoAboutFlat(Habitant habitant, Flat flats)
        {
            return $"{habitant.ToString()}  -  {flats.Tostring()}";
        }
    }
}
