using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public string name { get; }
        public string surname { get; }
        public int age { get; }


        public Person(string Name, string Surname, int Age)
        {
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
        }
        public string ToString()
        {
           return $"{name}, {surname}, {age}";
        }
    }
}
