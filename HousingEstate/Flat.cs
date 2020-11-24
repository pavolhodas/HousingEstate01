using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat : Person
    {
        private int numberOfFlat;
        private string area;
        private int numberOfRooms;
        private List<Person> peoples;
        public Flat(int NumberOfFlat, string Area, int NumberOfRooms, string Name, string Surname, int Age) : base(Name, Surname, Age)
        {
            numberOfFlat = NumberOfFlat;
            area = Area;
            numberOfRooms = NumberOfRooms;
        


            peoples = new List<Person>
            {
                new Person("Peter", "Hodás", 18),
                new Person("Pavol", "Hodás", 16),
                new Person("Miloš", "Hodás", 46),
                new Person("katarína", "Hodásová", 41)
            };
        }
        public string Show()
        {
            foreach (var people in peoples)
            {
                return $"{people}";
            }
            return null;
        }
        public string ToString()
        {
            return $"{numberOfFlat}, {area}, {numberOfRooms}, {name}, {surname}, {age}";
        }

    }
}
