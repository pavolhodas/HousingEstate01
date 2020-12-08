using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        private string name { get; }
        private string surname { get; }
        private int age { get; }
        public Person(string Name, string Surname, int Age)
        {
            name = Name;
            surname = Surname;
            age = Age;
        }
        public override string ToString()
        {
           return $"{name} {surname}, {age}";
        }
        public Person()
        {
        }
    }
}
