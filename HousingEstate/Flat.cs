using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        //private List<Person> persons { get; }
        public int NumberOfFlat { get; }
        public int Entrace { get; }
        public List<Person> persons = new List<Person> { };


        public Flat(int entrace, int numberOfFlat)
        {
            Entrace = entrace;
            NumberOfFlat = numberOfFlat;
        }
        public override string ToString()
        {
            return $"{Entrace} enterace flats: 1-10." + $" Im going to flat number {NumberOfFlat}";
        }
        
        public void Persons()
        {

            Console.WriteLine(persons);
        }
    }
}
