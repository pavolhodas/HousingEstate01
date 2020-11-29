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
        public List<Person> habitantList = new List<Person>() { };
        public Flat(int NumberOfFlat, string Area, int NumberOfRooms)
        {
            numberOfFlat = NumberOfFlat;
            area = Area;
            numberOfRooms = NumberOfRooms;


            habitantList = new List<Person>
            {
                new Person("Palo", "Hodás", 16),
                new Person("Miloš", "Hodás", 46),
                new Person("Pter", "Hodás", 18),
                new Person("Katarína", "Hodásová", 41)
            };
        }
        private string ShowHabitants()
        {
            string buffer = "";
            foreach (Person o in habitantList)
            {
                buffer += o.ToString();
                buffer += " - ";
            }
            return buffer.Remove(buffer.Length - 3);
        }

        public string Tostring()
        {
            return $"{numberOfFlat}, {area}, {numberOfRooms}";
        }


        public void AddHabitant(Person habitant, Flat flat)
        {
            Console.WriteLine(habitant + flat.ToString());
        }



        public string GetInfoAboutAllHabitants()
        {
            return ShowHabitants();
        }
    }
}
