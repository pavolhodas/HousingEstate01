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
        public List<Entrace> entraceList = new List<Entrace>() { };

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


        public void AddHabitant(Habitant habitant, Flat flat, Entrace entrace)
        {
            Console.WriteLine(habitant + "  -  " + flat.Tostring() + "  -  " + entrace.ToString());
        }



        public string GetInfoAboutAllHabitants()
        {
            return ShowHabitants();
        }

        //public string GetInfoAboutEntrace(Entrace entrace)
        //{
        //    if(entrace.sideOfStreet == "R")
        //    {
        //        return entrace.sideOfStreet;
        //    }
        //    if (entrace.sideOfStreet == "L")
        //    {
        //        return entrace.sideOfStreet;
        //    }
        //    else
        //    {
        //        return "This entrace don´t exist.";
        //    }
        //}
    }
}
