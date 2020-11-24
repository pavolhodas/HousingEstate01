using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
       

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
