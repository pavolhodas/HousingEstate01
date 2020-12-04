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
        public List<Habitant> habitantList = new List<Habitant>() { };
        public Flat(int NumberOfFlat, string Area, int NumberOfRooms)
        {
            numberOfFlat = NumberOfFlat;
            area = Area;
            numberOfRooms = NumberOfRooms;


            habitantList = new List<Habitant>
            {
                new Habitant("Palo", "Hodás", 16),
                new Habitant("Miloš", "Hodás", 46),
                new Habitant("Pter", "Hodás", 18),
                new Habitant("Katarína", "Hodásová", 41)
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


        public void AddHabitant(Habitant habitant, Flat flat)
        {
            Console.WriteLine(habitant + " - " + flat.Tostring());
        }



        public string GetInfoAboutAllHabitants()
        {
            return ShowHabitants();
        }
    }
}
