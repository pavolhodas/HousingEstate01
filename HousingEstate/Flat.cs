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
        }


        public string Tostring()
        {
            return $"{numberOfFlat}, {area}, {numberOfRooms}";
        }


        //public string Show()
        //{
        //    string buffer = "";
        //    foreach (Person person in habitantList)
        //    {
        //        buffer += person.Name + person.Surname + person.Age.ToString();
        //        buffer += " ";
        //    }
        //    return buffer;
        //}


        public void AddHabitant(Person habitant)
        {
            Console.WriteLine(habitant);
        }



        public string GetInfoAboutAllHabitants()
        {
            string buffer = "";
            foreach (Person o in habitantList)
            {
                buffer += o.Name + o.Surname + o.Age.ToString();
                buffer += " ";
            }
            return buffer;
        }
    }
}
