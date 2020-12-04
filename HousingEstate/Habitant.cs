using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Habitant : Person
    {
        public new string Name { get; }
        public new string Surname { get; }
        public new int Age { get; }

        public Habitant(string name, string surname, int age) : base(name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
       
        public string GetInfoAboutFlat(Flat flats)
        {
            return $"{flats.Tostring()}";
        }

    }
}
