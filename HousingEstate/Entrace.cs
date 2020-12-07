using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrace
    {
        public int nameOfEntrace;
        public int numberOfFloors;
        public int numberOfFlats;
        public Entrace(int NameOfEntrace,int NumberOfFloors, int NumberOfFlats)
        {
            nameOfEntrace = NameOfEntrace;
            numberOfFloors = NumberOfFloors;
            numberOfFlats = NumberOfFlats;
        }
        public string GetInfoAboutEntrace()
        {
            if (nameOfEntrace%2 == 0)
            {
                return "Side of road: R";
            }
            if (nameOfEntrace%2 != 0)
            {
                return "Side of road: L";
            }
            else
            {
                return "This entrace don´t exist.";
            }
        }
        public override string ToString()
        {
            return $"{nameOfEntrace}, {numberOfFloors}, {numberOfFlats}, {GetInfoAboutEntrace()}";
        }
    }
}
