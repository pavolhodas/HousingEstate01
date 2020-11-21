using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
       

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void Update()
        {
            Console.WriteLine(Name, Surname, Age);
        }
    }
}
