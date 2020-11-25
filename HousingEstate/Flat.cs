using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        private int numberOfFlat { get; }
        private string area { get; }
        private int numberOfRooms { get; }
        public List<Person> persons = new List<Person>() { };
        public Flat(int NumberOfFlat, string Area, int NumberOfRooms) 
        {
            numberOfFlat = NumberOfFlat;
            area = Area;
            numberOfRooms = NumberOfRooms;



            persons = new List<Person>
            {
                new Person("Peter ", "Hodás ", 18),
                new Person("Pavol ", "Hodás ", 16),
                new Person("Miloš ", "Hodás ", 46),
                new Person("katarína ", "Hodásová ", 41)
            };
        }
        private string Show()
        {
            string buffer = "";
            foreach (Person person in persons)
            {
                buffer += person.Name + person.Surname + person.Age.ToString();
            }
            return buffer;
        }
        public  string GetPersonInformation()
        {
            return $"{Show()}";
        }
        public string ToString(int position)
        {
            return $"Flat number:{numberOfFlat}, {area}, {numberOfRooms}    persons who live here:{persons[position].ToString()}";
        }
        public void AddHabitant(Person habitant)
        {
            //foreach (var habitant in persons)
            //{
            //    Console.WriteLine(habitant);
            //}
        }
    }
}
