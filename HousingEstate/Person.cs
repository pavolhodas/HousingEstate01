using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private string Name { get; }
        private string Surname { get; }
        private int Age { get; }
       

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string ToString()
        {
           return $"{Name}, {Surname}, {Age}";
        }
    }
}
